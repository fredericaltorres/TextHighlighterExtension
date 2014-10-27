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
using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.Text.Tagging;
using Microsoft.VisualStudio.Utilities;
using TextHighlighterExtension;
using DynamicSugar;
using System.Diagnostics;
using System.Windows;

namespace JsonLanguage {
        
    [Export(typeof(ITaggerProvider))]
    [ContentType("json")]
    [TagType(typeof(JsonKeywordTokenTag))]
    internal sealed class JsonTokenTagProvider : ITaggerProvider
    {
        public ITagger<T> CreateTagger<T>(ITextBuffer buffer) where T : ITag {
            
            return new JsonTokenTagger(buffer) as ITagger<T>;
        }
    }

    public enum TagType 
    {
        UNDEFINED  ,
        NUMBER     ,
        STRING     ,
        COMMENT    ,
        PUNCTUATION,
        ID         ,
        DATE       ,
        BOOLEAN    ,
        NULL       ,
        ERROR      ,
    }

    public class JsonKeywordTokenTag : ITag
    {
        public string w;
        public int Position;
        public TagType Type = TagType.UNDEFINED;
        public JsonKeywordTokenTag(string w, int position)  { this.w = w; this.Position = position;  }
        public JsonKeywordTokenTag(string w, int position, TagType tagType) : this(w, position) { this.Type = tagType; }
    }
   
    internal /*sealed*/ class JsonTokenTagger : ITagger<JsonKeywordTokenTag>
    {
        ITextBuffer _buffer;        

        internal JsonTokenTagger(ITextBuffer buffer)
        {            
            _buffer = buffer;
        }

        public event EventHandler<SnapshotSpanEventArgs> TagsChanged
        {
            add { }
            remove { }
        }
 
        private void Out(string s) {

            System.Diagnostics.Debug.WriteLine(s);
        }

        //https://ironpython.svn.codeplex.com/svn/IronPython_Main/Tools/IronStudio/IronPythonToolsCore/IronPythonToolsCore/OutliningTaggerProvider.cs

        private static int __explorerOpenInstanceCounter = 0;

        public IEnumerable<ITagSpan<JsonKeywordTokenTag>> GetTags(NormalizedSnapshotSpanCollection spans)
        {
            var colorizedTokens = new List<ITagSpan<JsonKeywordTokenTag>>();
            try
            {
                foreach (SnapshotSpan curSpan in spans)
                {
                    ITextSnapshotLine containingLine = curSpan.Start.GetContainingLine();
                    int curLocStart                  = containingLine.Start.Position;
                    int curLocEnd                    = containingLine.End.Position;
                    string line                      = containingLine.GetText();
                    string allText                   = containingLine.Snapshot.GetText();
                    Tokens Tokens                    = new Tokens(line, curLocStart, "$", "$");
                    string Value                     = null;
                    bool insertCurrentToken          = false;
                    var comments                     = new JSON.SyntaxValidator.CommentParser().Parse(allText);

                    #if DEBUG
                        //this.Out("\nColorCoding:[{0},{1}]{2}".format(curLocStart, curLocEnd, line));
                        this.Out("CC Parse:"+line);
                    #endif

                    if (comments.IsPositionInComment(curLocStart) && comments.IsPositionInComment(curLocEnd)) {
                        
                        var tokenSpan = new SnapshotSpan(curSpan.Snapshot, new Span(curLocStart, line.Length));
                        curLocStart += line.Length;
                        if (tokenSpan.IntersectsWith(curSpan))
                            colorizedTokens.Add(new TagSpan<JsonKeywordTokenTag>(tokenSpan, new JsonKeywordTokenTag(Tokens.Current.Value, Tokens.Index, TagType.COMMENT)));
                        return colorizedTokens;
                    }

                    while (Tokens.Index < Tokens.Count)
                    {
                        if (comments.IsPositionInComment(Tokens.Current.Position))
                        {
                            Value = Tokens.Current.Value;
                            var tokenSpan = new SnapshotSpan(curSpan.Snapshot, new Span(curLocStart, Value.Length));
                            curLocStart += Value.Length;
                            if (tokenSpan.IntersectsWith(curSpan))
                                colorizedTokens.Add(new TagSpan<JsonKeywordTokenTag>(tokenSpan, new JsonKeywordTokenTag(Tokens.Current.Value, Tokens.Index, TagType.COMMENT)));
                            
                        }
                        else if (Tokens.Current.Type == TokenType.OTHER) //&& Tokens.Current.Value == " "
                        {
                            insertCurrentToken = true;
                        }
                        else if (Tokens.Current.IsSlashComment() && Tokens.Next.IsSlashComment())
                        {
                            // The position of the token is wrong, if the // is in the middle of the string, we have to go back
                            // 2 + 1 for start at 0. if it is at the begining of the line the postion is 0
                            var slashSlashPos = Tokens.Current.AbsolutePosition;
                            if(slashSlashPos<0)
                                slashSlashPos = 0;
                            Value = line.Substring(slashSlashPos);

                            var tokenSpan = new SnapshotSpan(curSpan.Snapshot, new Span(curLocStart, Value.Length));
                            curLocStart += Value.Length;
                            if (tokenSpan.IntersectsWith(curSpan))
                                colorizedTokens.Add(new TagSpan<JsonKeywordTokenTag>(tokenSpan, new JsonKeywordTokenTag(Value, Tokens.Index, TagType.COMMENT)));
                            break;
                        }
                        // []{}:,
                        else if (Tokens.Current.IsJsonPunctuation())
                        {
                            Value = Tokens.Current.Value;
                            var tokenSpan = new SnapshotSpan(curSpan.Snapshot, new Span(curLocStart, Value.Length));
                            curLocStart += Value.Length;
                            if (tokenSpan.IntersectsWith(curSpan))
                                colorizedTokens.Add(new TagSpan<JsonKeywordTokenTag>(tokenSpan, new JsonKeywordTokenTag(Value, Tokens.Index, TagType.PUNCTUATION)));
                        }
                        else if (Tokens.Current.Type == TokenType.STRING)
                        {
                            TagType tagType = TagType.STRING;
                            Tokens.PushIndex();
                            if (Tokens.NextIgnoreOther.IsOp(":"))
                                tagType = TagType.ID;
                            Tokens.PopIndex();

                            if (JSON.SyntaxValidator.Tokenizer.IsJsonDate(Tokens.Current.Value))
                            {
                                tagType = TagType.DATE;
                            }

                            Value = Tokens.Current.Value;//.Replace(@"""", @"\""");
                            var tokenSpan = new SnapshotSpan(curSpan.Snapshot, new Span(curLocStart, Value.Length));
                            curLocStart += Value.Length;
                            if (tokenSpan.IntersectsWith(curSpan))
                                colorizedTokens.Add(new TagSpan<JsonKeywordTokenTag>(tokenSpan, new JsonKeywordTokenTag(Tokens.Current.Value, Tokens.Index, tagType)));
                        }
                        else if (Tokens.Current.Type == TokenType.INTEGER)
                        {
                            Value = Tokens.Current.Value;
                            var tokenSpan = new SnapshotSpan(curSpan.Snapshot, new Span(curLocStart, Value.Length));
                            curLocStart += Value.Length;
                            if (tokenSpan.IntersectsWith(curSpan))
                                colorizedTokens.Add(new TagSpan<JsonKeywordTokenTag>(tokenSpan, new JsonKeywordTokenTag(Tokens.Current.Value, Tokens.Index, TagType.NUMBER)));
                        }
                        else if (Tokens.Current.Type == TokenType.ID)
                        {
                            Value = Tokens.Current.Value;
                            var tagType = ((Value == "true") || (Value == "false")) ? TagType.BOOLEAN : TagType.ID;

                            if (Value == "null")
                                tagType = TagType.NULL;

                            var tokenSpan = new SnapshotSpan(curSpan.Snapshot, new Span(curLocStart, Value.Length));
                            curLocStart += Value.Length;
                            if (tokenSpan.IntersectsWith(curSpan))
                                colorizedTokens.Add(new TagSpan<JsonKeywordTokenTag>(tokenSpan, new JsonKeywordTokenTag(Tokens.Current.Value, Tokens.Index, tagType)));
                        }
                        //// Comment as //   or /* */ for now second syntax must be on one line
                        //else if ((Tokens.Current.IsOp("/") && Tokens.Next.IsOp("*")))
                        //{
                        //    var tokenSpan = new SnapshotSpan(curSpan.Snapshot, new Span(curLocStart, line.Length));
                        //    curLocStart += line.Length;
                        //    if (tokenSpan.IntersectsWith(curSpan))
                        //        colorizedTokens.Add(new TagSpan<JsonKeywordTokenTag>(tokenSpan, new JsonKeywordTokenTag(Tokens.Current.Value, Tokens.Index, TagType.COMMENT)));
                        //    break;
                        //}
                        else
                        {
                            insertCurrentToken = true;
                        }

                        if (insertCurrentToken)
                        {
                            insertCurrentToken = false; // Tokenize anything                            
                            var tokenSpan = new SnapshotSpan(curSpan.Snapshot, new Span(curLocStart, Tokens.Current.Length));
                            curLocStart += Tokens.Current.Length;
                            if (tokenSpan.IntersectsWith(curSpan))
                                colorizedTokens.Add(new TagSpan<JsonKeywordTokenTag>(tokenSpan, new JsonKeywordTokenTag(Tokens.Current.Value, Tokens.Index)));
                        }
                        Tokens.Index++;
                    }
                }          
            }
            catch (System.Exception ex)
            {
                this.Out(ex.ToString());
                #if DEBUG
                    //System.Diagnostics.Debugger.Break();
                #endif
            }
            return colorizedTokens;
        }

    }
}
