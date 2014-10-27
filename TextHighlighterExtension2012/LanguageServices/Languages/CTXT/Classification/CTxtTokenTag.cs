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

namespace CTxtLanguage
{    
    [Export(typeof(ITaggerProvider))]
    [ContentType("ctxt")]
    [TagType(typeof(CTxtKeywordTokenTag))]

    internal sealed class CTxtTokenTagProvider : ITaggerProvider
    {
        public ITagger<T> CreateTagger<T>(ITextBuffer buffer) where T : ITag {
            
            return new BatTokenTagger(buffer) as ITagger<T>;
        }
    }

    public enum TagType {

        UNDEFINED,
        BEFORE,
        AFTER,
        SPACE,
        OPERATOR,
        REGULAR_LINE
    }

    public class CTxtKeywordTokenTag : ITag  {

        public string w;
        public int Position;
        public TagType Type = TagType.UNDEFINED;
        public string Color;

        public CTxtKeywordTokenTag(string w, int position, TagType tagType, string color)            
        {
            this.Type = tagType;
            this.Color = color;
            this.w = w;
            this.Position = position;
        }
    }

    internal /*sealed*/ class BatTokenTagger : ITagger<CTxtKeywordTokenTag>
    {

        ITextBuffer _buffer;        
        //TextHighlighterExtension.BatColorEngine _BatColorEngine; 

        internal BatTokenTagger(ITextBuffer buffer)
        {            
            _buffer         = buffer;
            //_BatColorEngine = new TextHighlighterExtension.BatColorEngine();
        }

        public event EventHandler<SnapshotSpanEventArgs> TagsChanged
        {
            add { }
            remove { }
        }

        private void Out(string s)
        {
            System.Diagnostics.Debug.WriteLine(s);
        }

        public IEnumerable<ITagSpan<CTxtKeywordTokenTag>> GetTags(NormalizedSnapshotSpanCollection spans)
        {
            var colorizedTokens = new List<ITagSpan<CTxtKeywordTokenTag>>();

            try
            {
                foreach (SnapshotSpan curSpan in spans)
                {
                    ITextSnapshotLine containingLine = curSpan.Start.GetContainingLine();
                    int curLoc                       = containingLine.Start.Position;
                    string line                      = containingLine.GetText();

                    var r = ConfigurationEngine.Singleton.CTxtDefinition.Eval(line);
                                        
                    if(r.Passed)
                    {                        
                        if(r.Entry.Type == CTxt.CTxtEntryType.HEADER)
                        {
                            if(r.SpaceLen > 0)
                            {
                                var spaceTokenSpan = new SnapshotSpan(curSpan.Snapshot, new Span(curLoc, r.SpaceLen));
                                curLoc            += r.SpaceLen;
                                if (spaceTokenSpan.IntersectsWith(curSpan))
                                    colorizedTokens.Add(new TagSpan<CTxtKeywordTokenTag>(spaceTokenSpan, new CTxtKeywordTokenTag(r.SpaceText, 0, TagType.SPACE, null)));
                            }

                            var beforeTokenSpan = new SnapshotSpan(curSpan.Snapshot, new Span(curLoc, r.BeforeLen));
                            curLoc            += r.BeforeLen;
                            if (beforeTokenSpan.IntersectsWith(curSpan))
                                colorizedTokens.Add(new TagSpan<CTxtKeywordTokenTag>(beforeTokenSpan, new CTxtKeywordTokenTag(r.BeforeText, 0, TagType.BEFORE, r.Entry.BeforeColor)));

                            var operatorTokenSpan = new SnapshotSpan(curSpan.Snapshot, new Span(curLoc, r.OperatorLen));
                            curLoc            += r.OperatorLen;
                            if (operatorTokenSpan.IntersectsWith(curSpan))
                                colorizedTokens.Add(new TagSpan<CTxtKeywordTokenTag>(operatorTokenSpan, new CTxtKeywordTokenTag(r.OperatorText, 0, TagType.OPERATOR, null)));

                            var afterTokenSpan = new SnapshotSpan(curSpan.Snapshot, new Span(curLoc, r.AfterLen));
                            curLoc            += r.AfterLen;
                            if (afterTokenSpan.IntersectsWith(curSpan))
                                colorizedTokens.Add(new TagSpan<CTxtKeywordTokenTag>(afterTokenSpan, new CTxtKeywordTokenTag(r.AfterText, 0, TagType.AFTER, r.Entry.AfterColor)));
                        }
                        if(r.Entry.Type == CTxt.CTxtEntryType.LINE)
                        {
                            var tokenSpan = new SnapshotSpan(curSpan.Snapshot, new Span(curLoc, line.Length));
                            curLoc += line.Length;
                            if (tokenSpan.IntersectsWith(curSpan))
                                colorizedTokens.Add(new TagSpan<CTxtKeywordTokenTag>(tokenSpan, new CTxtKeywordTokenTag(line, 0, TagType.REGULAR_LINE, r.Entry.AfterColor)));
                        }
                    }
                    else
                    {
                        var tokenSpan = new SnapshotSpan(curSpan.Snapshot, new Span(curLoc, line.Length));
                        curLoc += line.Length;
                        if (tokenSpan.IntersectsWith(curSpan))
                            colorizedTokens.Add(new TagSpan<CTxtKeywordTokenTag>(tokenSpan, new CTxtKeywordTokenTag(line, 0, TagType.REGULAR_LINE, null)));
                    }
                }
            }
            catch (System.Exception ex)
            {
                this.Out(ex.ToString());
            }
            return colorizedTokens;
        }
       
    }
}
