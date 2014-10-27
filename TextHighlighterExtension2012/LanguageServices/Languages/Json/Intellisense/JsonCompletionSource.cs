#region License - TextHighLighterExtension v 1.x - Copyright (c) 2010 Frederic Torres
/*
Text syntax Highlighting for Visual Studio 2010 (.txt, .log, .bat, .ini)
http://www.frederictorres.net
 
LICENSE

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
*/
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.Language.Intellisense;
using System.Collections.ObjectModel;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Tagging;
using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Utilities;
using DynamicSugar;
using System.Reflection;
using System.Drawing;
using System.Windows.Media.Imaging;
using TextHighlighterExtension;

namespace JsonLanguage
{
    [Export(typeof(ICompletionSourceProvider))]
    [ContentType("json")]
    [Name("jsonCompletion")]
    class JsonCompletionSourceProvider : ICompletionSourceProvider
    {
        public ICompletionSource TryCreateCompletionSource(ITextBuffer textBuffer)
        {
            return new JsonCompletionSource(textBuffer);
        }
    }

    class JsonCompletionSource : ICompletionSource
    {
        private ITextBuffer _buffer;
        private bool        _disposed = false;

        public JsonCompletionSource(ITextBuffer buffer)
        {
            _buffer = buffer;
        }

        private void Out(string s)
        {
            System.Diagnostics.Debug.WriteLine(s);
        }

        public void AugmentCompletionSession(ICompletionSession session, IList<CompletionSet> completionSets)
        {
            try {
                if (_disposed)
                    throw new ObjectDisposedException("JsonCompletionSource");

                ITextSnapshot snapshot          = _buffer.CurrentSnapshot;
                var triggerPoint                = (SnapshotPoint)session.GetTriggerPoint(snapshot);

                if (triggerPoint == null) 
                    return;

                var lineSnapshot                = triggerPoint.GetContainingLine();
                var allText                     = lineSnapshot.Snapshot.GetText();
                var comments                    = new JSON.SyntaxValidator.CommentParser().Parse(allText, numberOfCommentToParse: 1);
                var activateJsonIntellisense    = (comments.Count > 0 && comments[0].Text.Contains("intellisense:true"));
               
                SnapshotPoint start             = triggerPoint;
                SnapshotPoint start2            = triggerPoint;
                var lineNumber                  = snapshot.GetLineNumberFromPosition(start.Position);
                var completions                 = new List<Completion>();
               
                if (activateJsonIntellisense)
                {
                    var jsonIdForintellisense = GetJsonIdRequestedByIntellisense(lineSnapshot, start, ref start2);
                    this.Out("Activate Intellisene for:{0}".format(jsonIdForintellisense));
                    if (jsonIdForintellisense != null) // Make sure we found a string id on the left of the cursor
                    {
                        completions = this.GetJsonBasicIntellisenseForPropertyValue();
                        if (completions.Count > 0)
                        {
                            var applicableTo = snapshot.CreateTrackingSpan(new SnapshotSpan(start, triggerPoint), SpanTrackingMode.EdgeInclusive);
                            completionSets.Add(new CompletionSet("All", "All", applicableTo, completions, Enumerable.Empty<Completion>()));
                        }
                    }
                }
            }
            catch(System.Exception ex) {

                this.Out(ex.ToString());
            }
        }

        static System.Windows.Media.ImageSource _completionIcon                                  = null;
        static List<Completion>                 _completionJsonBasicIntellisenseForPropertyValue = null;

        public List<Completion> GetJsonBasicIntellisenseForPropertyValue()
        {          
            var completions = new List<Completion>();
            _completionJsonBasicIntellisenseForPropertyValue = completions;

            if (_completionIcon == null)
                _completionIcon = Util.Utility.GetBitmapImage("json.png");

            var jsondateFormat = ": \"{0:0000}-{1:00}-{2:00}T{3:00}:{4:00}:{5:00}Z\", ";
            var d = DateTime.Now;
            var jsonNowLocal = jsondateFormat.format(d.Year, d.Month, d.Day, d.Hour, d.Minute, d.Second);
            d = DateTime.UtcNow;
            var jsonNowUtc = jsondateFormat.format(d.Year, d.Month, d.Day, d.Hour, d.Minute, d.Second);

            completions.Add(new Completion() { DisplayText = "\"\"",  IconSource = _completionIcon });
            completions.Add(new Completion() { DisplayText = "true",  IconSource = _completionIcon });
            completions.Add(new Completion() { DisplayText = "false", IconSource = _completionIcon });    
            completions.Add(new Completion() { DisplayText = "Date",    InsertionText = jsonNowUtc,     IconSource = _completionIcon });
            completions.Add(new Completion() { DisplayText = "Object", InsertionText = ": { }, ", IconSource = _completionIcon });
            completions.Add(new Completion() { DisplayText = "Array", InsertionText = ": [ ], ", IconSource = _completionIcon });
           
            completions.Add(new Completion() { DisplayText = "1",     IconSource = _completionIcon });
            completions.Add(new Completion() { DisplayText = "1.2",   IconSource = _completionIcon });
            completions.Add(new Completion() { DisplayText = "null",  IconSource = _completionIcon });
            completions.Add(new Completion() { DisplayText = ":",  IconSource = _completionIcon });
          
            foreach (var c in completions)
            {
                if (String.IsNullOrEmpty(c.InsertionText))
                    c.InsertionText = ": {0}, ".format(c.DisplayText);
            }
          
            return completions;
        }

        
      

        private string GetJsonIdRequestedByIntellisense(ITextSnapshotLine lineSnapshot,  SnapshotPoint start, ref SnapshotPoint start2)
        {
            var jsonStringIdFound = false;

            // Make sure the token to the left of the : is a string
            // "Adress"    : { "Street" : "", ZipCode : },  

            start -= 1;

            // Eat the space on the left of the :
            while (start > lineSnapshot.Start)
            {
                if (char.IsWhiteSpace((start - 1).GetChar()))
                {
                    start -= 1;
                }
                else
                {
                    if ((start - 1).GetChar() == '"')
                    {
                        start -= 1; // We find the last " 
                        break;
                    }
                    else
                        return null;
                }
            }

            string jsonStringID = "";

            // Now parse in reverse the  string
            while (start > lineSnapshot.Start)
            {
                // TODO: Need to support \" in string
                if (token.IsDoubleQuote((start - 1).GetChar()))
                {
                    if (start.Position-2 > lineSnapshot.Start.Position && (start - 2).GetChar() == '\\') // test case of double quote in ta string
                    {
                        start -= 1;
                        jsonStringID = "\"" + jsonStringID;
                    }
                    else
                    {
                        jsonStringIdFound = true; // We find the " starting the string s
                        break;
                    }
                }
                else
                {
                    jsonStringID = (start - 1).GetChar().ToString() + jsonStringID;
                }
                start -= 1;
            }
            return jsonStringIdFound ? jsonStringID : null;
        }

        private string GetJsonFirstPreviousCharRequestedByIntellisense(string allText, int pos)
        {
            while (pos > 0)
            {
                if (char.IsWhiteSpace(allText[pos]))
                {
                    pos--;
                }
                else
                {
                    return allText[pos].ToString();
                }
            }
            return null;
        }
         
        public void Dispose()
        {
            _disposed = true;
        }
    }
}
