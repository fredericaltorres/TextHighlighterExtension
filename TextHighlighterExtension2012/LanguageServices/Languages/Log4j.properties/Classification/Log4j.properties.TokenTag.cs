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
using FredericTorres.TextHighlighterPackage.Configuration;

namespace Log4jPropertiesLanguage{
        
    [Export(typeof(ITaggerProvider))]
    [ContentType("properties")]
    [TagType(typeof(Log4jPropertiesKeywordTokenTag))]

    internal sealed class IniTokenTagProvider : ITaggerProvider {

        public ITagger<T> CreateTagger<T>(ITextBuffer buffer) where T : ITag {
           
            return new IniTokenTagger(buffer) as ITagger<T>;
        }
    }

    public enum TagType {
        UNDEFINED,
        VAR,
        COMMENT,
        SECTION,
        VALUE,
        EQUAL
    }

    public class Log4jPropertiesKeywordTokenTag : ITag  {

        public string w;
        public int Position;
        public TagType Type = TagType.UNDEFINED;

        public Log4jPropertiesKeywordTokenTag(string w, int position){
                        
            this.w = w;
            this.Position = position;
        }
        public Log4jPropertiesKeywordTokenTag(string w, int position, TagType tagType):this(w, position){
                       
            this.Type = tagType;
        }
    }

    internal sealed class IniTokenTagger : ITagger<Log4jPropertiesKeywordTokenTag>
    {

        ITextBuffer _buffer;        
      
        internal IniTokenTagger(ITextBuffer buffer)
        {
            _buffer         = buffer;
            
        }

        private const string _Log4jProperties_CommentChar = "#";

        public event EventHandler<SnapshotSpanEventArgs> TagsChanged
        {
            add { }
            remove { }
        }

        string _iniFileCommentChars = TextHighlighterConfigApi.GetIniFileCommentChars();

        public IEnumerable<ITagSpan<Log4jPropertiesKeywordTokenTag>> GetTags(NormalizedSnapshotSpanCollection spans){

            // Util.TRACER.TRACE_METHOD(spans);

            foreach (SnapshotSpan curSpan in spans) {

                ITextSnapshotLine containingLine    = curSpan.Start.GetContainingLine();
                int curLoc                          = containingLine.Start.Position;
                string line                         = containingLine.GetText();
                Tokens Tokens                       = new Tokens(line, curLoc, ".", "", false);
                
                string Value                        = null;
                bool   InsertCurrentToken           = false;
                bool   VarFound                     = false;
                bool   EqualFound                   = false;
                
                                    
                while(Tokens.Index < Tokens.Count) {
                    
                    // Comment
                    if((!string.IsNullOrEmpty(Tokens.Current.Value)) && Tokens.Current.Value.Length > 0 && Tokens.Index == 0 && _Log4jProperties_CommentChar.Contains(Tokens.Current.Value[0].ToString())) {

                        var tokenSpan   = new SnapshotSpan(curSpan.Snapshot, new Span(curLoc, line.Length));
                        curLoc          +=line.Length;
                        if( tokenSpan.IntersectsWith(curSpan) ) 
                            yield return new TagSpan<Log4jPropertiesKeywordTokenTag>(tokenSpan, new Log4jPropertiesKeywordTokenTag(Tokens.Current.Value, Tokens.Index, TagType.COMMENT));
                        break;
                    }
                    // Section
                    else if(Tokens.Current.Value=="[") {

                        Value           = Tokens.GetUpTo(']');
                        var tokenSpan   = new SnapshotSpan(curSpan.Snapshot, new Span(curLoc, Value.Length));
                        curLoc          +=Value.Length;
                        if(tokenSpan.IntersectsWith(curSpan))
                            yield return new TagSpan<Log4jPropertiesKeywordTokenTag>(tokenSpan, new Log4jPropertiesKeywordTokenTag(Value, Tokens.Index, TagType.SECTION));
                    }
                    else if(Tokens.Current.IsID()) {

                        if(!VarFound){
                            VarFound        = true;
                            Value           = Tokens.Current.Value;
                            var tokenSpan   = new SnapshotSpan(curSpan.Snapshot, new Span(curLoc, Value.Length));
                            curLoc          +=Value.Length;
                            if( tokenSpan.IntersectsWith(curSpan) )
                                yield return new TagSpan<Log4jPropertiesKeywordTokenTag>(tokenSpan, new Log4jPropertiesKeywordTokenTag(Value, Tokens.Index, TagType.VAR));
                        }
                        else{
                            InsertCurrentToken = true;
                        }
                    }
                    // =
                    else if(Tokens.Current.IsOp("=")){
                            
                        if(!EqualFound) {
                            EqualFound      = true;
                            Value           = Tokens.Current.Value;
                            var tokenSpan   = new SnapshotSpan(curSpan.Snapshot, new Span(curLoc, Value.Length));
                            curLoc          +=Value.Length;
                            if(tokenSpan.IntersectsWith(curSpan))
                                yield return new TagSpan<Log4jPropertiesKeywordTokenTag>(tokenSpan, new Log4jPropertiesKeywordTokenTag(Value, Tokens.Index, TagType.EQUAL));
                        }
                        else {
                            InsertCurrentToken = true;
                        }
                    }    
                    else {
                        
                        InsertCurrentToken = true;
                    }                    
                    if(InsertCurrentToken) {
                        InsertCurrentToken   = false; // Tokenize anything                            
                        var tokenSpan        = new SnapshotSpan(curSpan.Snapshot, new Span(curLoc, Tokens.Current.Length));
                        curLoc              += Tokens.Current.Length;
                        if( tokenSpan.IntersectsWith(curSpan) ) 
                            yield return new TagSpan<Log4jPropertiesKeywordTokenTag>(tokenSpan, new Log4jPropertiesKeywordTokenTag(Tokens.Current.Value, Tokens.Index, TagType.VALUE));
                    }
                    Tokens.Index++;
                }
            }          
        }
    }
}
