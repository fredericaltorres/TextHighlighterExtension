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
using System.Collections;
using TextHighlighterExtension;

namespace Ps1Language
{
    [Export(typeof(ICompletionSourceProvider))]    
    [ContentType("ps1")]
    [Name("ps1Completion")]
    class BatCompletionSourceProvider : ICompletionSourceProvider
    {
        public ICompletionSource TryCreateCompletionSource(ITextBuffer textBuffer)
        {
            return new ps1CompletionSource(textBuffer);
        }
    }

    [Export(typeof(ICompletionSourceProvider))]    
    [ContentType("psm1")]
    [Name("psm1Completion")]
    class Psm1CompletionSourceProvider : ICompletionSourceProvider
    {
        public ICompletionSource TryCreateCompletionSource(ITextBuffer textBuffer)
        {
            return new ps1CompletionSource(textBuffer);
        }
    }

    [Export(typeof(ICompletionSourceProvider))]    
    [ContentType("psd1")]
    [Name("psd1Completion")]
    class Psd1CompletionSourceProvider : ICompletionSourceProvider
    {
        public ICompletionSource TryCreateCompletionSource(ITextBuffer textBuffer)
        {
            return new ps1CompletionSource(textBuffer);
        }
    }


    class ps1CompletionSource : ICompletionSource
    {
        private ITextBuffer _buffer;
        private bool        _disposed = false;

        public ps1CompletionSource(ITextBuffer buffer)
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
                    throw new ObjectDisposedException("BatCompletionSource");

                ITextSnapshot snapshot  = _buffer.CurrentSnapshot;
                var triggerPoint        = (SnapshotPoint)session.GetTriggerPoint(snapshot);

                if (triggerPoint == null)
                    return;

                var lineSnapshot             = triggerPoint.GetContainingLine();
                var allText                  = lineSnapshot.Snapshot.GetText();
                SnapshotPoint start          = triggerPoint;
                SnapshotPoint start2         = triggerPoint;
                var batDefinitions           = ConfigurationEngine.Singleton.IntellisenseManager.BatDefinitions;
                var line                     = lineSnapshot.GetText();
                List<Completion> completions = null;
                
                if(Ps1Language.CommandFilter.IntellisenseChar == "-") {

                    if(ConfigurationEngine.Singleton.IntellisenseManager.PowerShellDefinitions.IsRelevantToTriggerIntellisense(Ps1Language.CommandFilter.IntellisensePreviousWord)) {

                        completions = GetCompletionsListFromIntellisenseMetaData(Ps1Language.CommandFilter.IntellisensePreviousWord, Ps1Language.CommandFilter.IntellisensePreviousWordAlreadyUsedParameters);
                    }
                }
              
                if(completions != null && completions.Count>0){
            
                    var applicableTo = snapshot.CreateTrackingSpan(new SnapshotSpan(start, triggerPoint), SpanTrackingMode.EdgeInclusive);
                    completionSets.Add(new CompletionSet("All", "All", applicableTo, completions, Enumerable.Empty<Completion>()));
                }
                else {
                    // Set an empty intellisense list else it break the intellisense
                    var applicableTo = snapshot.CreateTrackingSpan(new SnapshotSpan(start, triggerPoint), SpanTrackingMode.EdgeInclusive);
                    completionSets.Add(new CompletionSet("All", "All", applicableTo, new List<Completion>(), Enumerable.Empty<Completion>()));
                }
            }
            catch(System.Exception ex) {
                this.Out(ex.ToString());
                #if DEBUG
                    Util.Utility.MsgBox(": (", ex);
                #endif
            }
        }

        private List<Completion> GetCompletionsListFromIntellisenseMetaData(string keyword, List<string> parameters)
        {
            keyword                   = keyword.ToLower();
            var completions           = new List<Completion>();
            var powerShellDefinitions = ConfigurationEngine.Singleton.IntellisenseManager.PowerShellDefinitions;

            if(powerShellDefinitions.ContainsKey(keyword)) {
                foreach(var def in powerShellDefinitions[keyword]) {
                    var completion = def.GetCompletion(true);
                    if(!completion.DisplayText.In(parameters)) {
                        completions.Add(completion); 
                    }
                }
            }
            if(completions.Count == 0) {
                completions.Add( new Completion() { DisplayText = "Nothing found" } );
            }
            return completions;
        }

        private List<Completion> GetCompletionsListOfVariables(string batSource) {
         
            var completions = new List<Completion>();
            var variables   = new TextHighlighterExtension.BatParser(batSource).GetVariables();

            foreach(var v in variables)
            {
                completions.Add(new Completion() { 
                    DisplayText        = "{0}".format(v), 
                    InsertionText      = "{0}%".format(v), 
                    Description        = null,//"{0}".format(v),
                    IconSource         = TextHighlighterExtension.BatColorEngine.BatchIconBlack,
                    IconAutomationText = "IconAutomationText"
                });
            }
            completions.AddRange(this.GetCompletionsListOfEnvironmentVariables());
            return completions;
        }

        private bool IsAllUppercase(string v) {

            return v == v.ToUpperInvariant();
        }

        private List<Completion> GetCompletionsListOfEnvironmentVariables() {
         
            var completions    = new List<Completion>();
            var upperCaseNames = new List<string>();
            var otherCaseNames = new List<string>();

            foreach (DictionaryEntry de in Environment.GetEnvironmentVariables())
            {
                if(IsAllUppercase(de.Key.ToString()))
                    upperCaseNames.Add(de.Key.ToString());
                else
                    otherCaseNames.Add(de.Key.ToString());
            }
            upperCaseNames.Sort();
            otherCaseNames.Sort();

            IDictionary environmentVariables = Environment.GetEnvironmentVariables();

            foreach(var name in otherCaseNames)
            {
                var v = environmentVariables[name];
                completions.Add(new Completion() { 
                    DisplayText        = "{0}".format(name), 
                    InsertionText      = "{0}%".format(name), 
                    Description        = "{0}".format(v.ToString()),
                    IconSource         = TextHighlighterExtension.BatColorEngine.BatchIconBlue,
                    IconAutomationText = "IconAutomationText"
                });
            }

            foreach(var name in upperCaseNames)
            {
                var v = environmentVariables[name];

                completions.Add(new Completion() { 
                    DisplayText        = "{0}".format(name), 
                    InsertionText      = "{0}%".format(name), 
                    Description        = "{0}".format(v.ToString()),
                    IconSource         = TextHighlighterExtension.BatColorEngine.BatchIconOrange,
                    IconAutomationText = "IconAutomationText"
                });
            }
            return completions;
        }
        
        private List<Completion> GetCompletionsListOfLabels(string batSource) {
         
            var completions = new List<Completion>();
            var labels      = new TextHighlighterExtension.BatParser(batSource).GetLabels();

            foreach(var v in labels) {

                completions.Add(new Completion() { 
                    DisplayText        = "{0}".format(v), 
                    InsertionText      = "{0}".format(v), 
                    Description        = null,//"{0}".format(v),
                    IconSource         = TextHighlighterExtension.BatColorEngine.BatchIconBlack,
                    IconAutomationText = "IconAutomationText"
                });
            }
            return completions;
        }

        public void Dispose()
        {
            _disposed = true;
        }
    }
}


/*
 
 
        private List<string> GetDeclaredVariables(string batSource) {

            const string SET_TAG = "set ";
            var l                = new List<string>();
            batSource            = batSource.Replace(Environment.NewLine, Environment.NewLine[0].ToString());
            var lines            = batSource.Split(Environment.NewLine[0]);

            foreach(var line in lines) {
                var line2 = line.Trim();
                if(line2.ToLowerInvariant().StartsWith(SET_TAG)) {
                    var line3 = line2.Substring(SET_TAG.Length);
                    var p = line3.IndexOf("=");
                    if(p != -1) {
                        var varName = line3.Substring(0, p).Trim();
                        l.Add(varName);
                    }
                }
            }
            l.Add("ERRORLEVEL");
            l.Sort();
            return l;
        }
        
        private List<string> GetDeclaredLabels(string batSource) {

            const string SET_TAG = ":";
            var l                = new List<string>();
            batSource            = batSource.Replace(Environment.NewLine, Environment.NewLine[0].ToString());
            var lines            = batSource.Split(Environment.NewLine[0]);

            foreach(var line in lines) {
                var line2 = line.Trim();
                if(line2.ToLowerInvariant().StartsWith(SET_TAG)) {
                    var line3 = line2.Substring(SET_TAG.Length);
                    l.Add(line3);
                }
            }
            l.Sort();
            return l;
        }
 */