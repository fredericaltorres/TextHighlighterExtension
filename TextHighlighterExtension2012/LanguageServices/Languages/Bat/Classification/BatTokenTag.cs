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


namespace BatLanguage{
        
    [Export(typeof(ITaggerProvider))]
    [ContentType("bat")]
    [TagType(typeof(BatKeywordTokenTag))]

    internal sealed class BatTokenTagProvider : ITaggerProvider {

        public ITagger<T> CreateTagger<T>(ITextBuffer buffer) where T : ITag {
            
            return new BatTokenTagger(buffer) as ITagger<T>;
        }
    }

    public enum TagType 
    {
        UNDEFINED ,
        VAR       ,
        LABEL     ,
        PARAMETER ,
        KEYWORD   ,
        COMMENT   ,
        STRING    ,
        MACRO_VAR ,
        POWERSHELL,
        PUNCTUTATION
    }

    public class BatKeywordTokenTag : ITag  {

        public string w;
        public int Position;
        public TagType Type = TagType.UNDEFINED;

        public BatKeywordTokenTag(string w, int position){

            //// Util.TRACER.TRACE_METHOD(w);
            this.w = w;
            this.Position = position;
        }
        public BatKeywordTokenTag(string w, int position, TagType tagType):this(w, position){

            //// Util.TRACER.TRACE_METHOD(w);
            this.Type = tagType;
        }
    }

    internal /*sealed*/ class BatTokenTagger : ITagger<BatKeywordTokenTag>
    {

        ITextBuffer _buffer;        
        TextHighlighterExtension.BatColorEngine _BatColorEngine; 

        internal BatTokenTagger(ITextBuffer buffer)
        {            
            _buffer         = buffer;
            _BatColorEngine = new TextHighlighterExtension.BatColorEngine(ConfigurationEngine.Singleton.GetBatKeywordDescription());
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

        private const string POWERSHELL_WORD = "powershell";

        public IEnumerable<ITagSpan<BatKeywordTokenTag>> GetTags(NormalizedSnapshotSpanCollection spans)
        {
            var colorizedTokens = new List<ITagSpan<BatKeywordTokenTag>>();
            try
            {
                foreach (SnapshotSpan curSpan in spans)
                {
                    ITextSnapshotLine containingLine = curSpan.Start.GetContainingLine();
                    int curLoc = containingLine.Start.Position;
                    string line = containingLine.GetText();
                    var Tokens = new TextHighlighterExtension.Tokens(line, curLoc);
                    string Value = null;
                    bool insertCurrentToken = false;

                    bool isFirstTokenEcho = (Tokens.Index == 0) && (Tokens.Count > 0) && (Tokens.Current.Value != null) && (Tokens.Current.Value.ToLower() == "echo");

                    while (Tokens.Index < Tokens.Count)
                    {
                        // White Space
                        if (Tokens.Current.Type == TokenType.OTHER && Tokens.Current.Value == " ")
                        {
                            insertCurrentToken = true;
                        }
                        // Stop color coding the line if it start with powershell
                        else if (Tokens.PreviousPrevious.IsID(POWERSHELL_WORD, true))
                        {
                            var tokenSpan = new SnapshotSpan(curSpan.Snapshot, new Span(curLoc, line.Length - POWERSHELL_WORD.Length));
                            curLoc += line.Length - POWERSHELL_WORD.Length;
                            if (tokenSpan.IntersectsWith(curSpan))
                                colorizedTokens.Add(new TagSpan<BatKeywordTokenTag>(tokenSpan, new BatKeywordTokenTag(Tokens.Current.Value, Tokens.Index, TagType.POWERSHELL)));
                            break;
                        }
                        // :: as comment and @rem as comment
                        else if (
                            ((Tokens.Current.IsOp(":")) && (Tokens.Next.IsOp(":"))) ||
                            ((Tokens.Current.IsOp("@")) && (Tokens.Next.Value != null) && (Tokens.Next.Value.ToLower() == "rem"))
                            )
                        {
                            var tokenSpan = new SnapshotSpan(curSpan.Snapshot, new Span(curLoc, line.Length));
                            curLoc += line.Length;
                            if (tokenSpan.IntersectsWith(curSpan))
                                colorizedTokens.Add(new TagSpan<BatKeywordTokenTag>(tokenSpan, new BatKeywordTokenTag(Tokens.Current.Value, Tokens.Index, TagType.COMMENT)));
                            break;
                        }
                        // :ID
                        else if ((Tokens.Index == 0) && (Tokens.Current.IsOp(":")) && (Tokens.Next.IsID()))
                        {
                            Value = Tokens.CurrentNextValue();
                            var tokenSpan = new SnapshotSpan(curSpan.Snapshot, new Span(curLoc, line.Length));
                            curLoc += line.Length;
                            if (tokenSpan.IntersectsWith(curSpan))
                                colorizedTokens.Add(new TagSpan<BatKeywordTokenTag>(tokenSpan, new BatKeywordTokenTag(Value, Tokens.Index, TagType.LABEL)));
                            break;
                        }
                        // else if ((Tokens.Index == 0)&&(_BatColorEngine.IsBuiltIn(Tokens.Current.Value)))
                        else if (
                            ((!isFirstTokenEcho) && (_BatColorEngine.IsKeyword(Tokens.Current.Value))) ||
                            (Tokens.Current.Value.ToLower() == "echo")
                            )
                        {
                            // REM ----
                            if ((_BatColorEngine.IsComment(Tokens.Current.Value)))
                            {
                                var tokenSpan = new SnapshotSpan(curSpan.Snapshot, new Span(curLoc, line.Length));
                                curLoc += line.Length;
                                if (tokenSpan.IntersectsWith(curSpan))
                                    colorizedTokens.Add(new TagSpan<BatKeywordTokenTag>(tokenSpan, new BatKeywordTokenTag(Tokens.Current.Value, Tokens.Index, TagType.COMMENT)));
                                break;
                            }
                            else
                            {
                                var tokenSpan = new SnapshotSpan(curSpan.Snapshot, new Span(curLoc, Tokens.Current.Length));
                                curLoc += Tokens.Current.Value.Length;
                                if (tokenSpan.IntersectsWith(curSpan))
                                    colorizedTokens.Add(new TagSpan<BatKeywordTokenTag>(tokenSpan, new BatKeywordTokenTag(Tokens.Current.Value, Tokens.Index, TagType.KEYWORD)));
                            }
                        }
                        // %ID% any where in the string
                        else if ((Tokens.Current.IsOp("%")) && (Tokens.Next.IsID()) && (Tokens.NextNext.IsOp("%")))
                        {
                            Value = Tokens.CurrentNextNextValue();
                            var tokenSpan = new SnapshotSpan(curSpan.Snapshot, new Span(curLoc, Value.Length));
                            curLoc += Value.Length;
                            if (tokenSpan.IntersectsWith(curSpan))
                                colorizedTokens.Add(new TagSpan<BatKeywordTokenTag>(tokenSpan, new BatKeywordTokenTag(Value, Tokens.Index, TagType.MACRO_VAR)));

                            Tokens.Index += 2;
                        }
                        // %1
                        else if (((Tokens.Current.IsOp("%")) && (Tokens.Next.IsInteger())))
                        {
                            Value = Tokens.CurrentNextValue();
                            var tokenSpan = new SnapshotSpan(curSpan.Snapshot, new Span(curLoc, Value.Length));
                            curLoc += Value.Length;
                            if (tokenSpan.IntersectsWith(curSpan))
                                colorizedTokens.Add(new TagSpan<BatKeywordTokenTag>(tokenSpan, new BatKeywordTokenTag(Value, Tokens.Index, TagType.MACRO_VAR)));
                            Tokens.Index += 1;
                        }
                        // %%f
                        else if (((Tokens.Current.IsOp("%")) && (Tokens.Next.IsOp("%")) && (Tokens.NextNext.IsID())))
                        {
                            Value = Tokens.CurrentNextNextValue();
                            var tokenSpan = new SnapshotSpan(curSpan.Snapshot, new Span(curLoc, Value.Length));
                            curLoc += Value.Length;
                            if (tokenSpan.IntersectsWith(curSpan))
                                colorizedTokens.Add(new TagSpan<BatKeywordTokenTag>(tokenSpan, new BatKeywordTokenTag(Value, Tokens.Index, TagType.MACRO_VAR)));
                            Tokens.Index += 2;
                        }
                        // set VAR=43324 color VAR
                        else if ((Tokens.Current.IsID()) && (Tokens.PreviousPrevious.IsID("set", true)))
                        {
                            Value = Tokens.Current.Value;
                            var tokenSpan = new SnapshotSpan(curSpan.Snapshot, new Span(curLoc, Value.Length));
                            curLoc += Value.Length;
                            if (tokenSpan.IntersectsWith(curSpan))
                                colorizedTokens.Add(new TagSpan<BatKeywordTokenTag>(tokenSpan, new BatKeywordTokenTag(Value, Tokens.Index, TagType.VAR)));
                        }
                            // goto not at the beginning of a line - color the goto keyword
                        else if ((!isFirstTokenEcho) && (Tokens.Current.IsID()) && (Tokens.Current.IsID("goto", true)))
                        {
                            Value = Tokens.Current.Value;
                            var tokenSpan = new SnapshotSpan(curSpan.Snapshot, new Span(curLoc, Value.Length));
                            curLoc += Value.Length;
                            if (tokenSpan.IntersectsWith(curSpan))
                                colorizedTokens.Add(new TagSpan<BatKeywordTokenTag>(tokenSpan, new BatKeywordTokenTag(Value, Tokens.Index, TagType.KEYWORD)));
                        }
                            // goto LABEL - color the label
                        else if ((!isFirstTokenEcho) && (Tokens.Current.IsID()) && (Tokens.PreviousPrevious.IsID("goto", true)))
                        {
                            Value = Tokens.Current.Value;
                            var tokenSpan = new SnapshotSpan(curSpan.Snapshot, new Span(curLoc, Value.Length));
                            curLoc += Value.Length;

                            if (tokenSpan.IntersectsWith(curSpan))
                                colorizedTokens.Add(new TagSpan<BatKeywordTokenTag>(tokenSpan, new BatKeywordTokenTag(Value, Tokens.Index, TagType.LABEL)));
                        }
                            // net START
                        else if ((Tokens.Current.IsID()) && (Tokens.PreviousPrevious.IsID("net", true)))
                        {
                            Value = Tokens.Current.Value;
                            var tokenSpan = new SnapshotSpan(curSpan.Snapshot, new Span(curLoc, Value.Length));
                            curLoc += Value.Length;

                            if (tokenSpan.IntersectsWith(curSpan))
                                colorizedTokens.Add(new TagSpan<BatKeywordTokenTag>(tokenSpan, new BatKeywordTokenTag(Value, Tokens.Index, TagType.PARAMETER)));
                        }
                            // /b
                        else if ((Tokens.Current.IsOp("/")) && (Tokens.Next.IsID()))
                        {
                            Value = Tokens.CurrentNextValue();
                            var tokenSpan = new SnapshotSpan(curSpan.Snapshot, new Span(curLoc, Value.Length));
                            curLoc += Value.Length;
                            if (tokenSpan.IntersectsWith(curSpan))
                                colorizedTokens.Add(new TagSpan<BatKeywordTokenTag>(tokenSpan, new BatKeywordTokenTag(Value, Tokens.Index)));
                            Tokens.Index++;
                        }
                        else if ((Tokens.Current.Type == TokenType.STRING))
                        {
                            Value = Tokens.Current.Value;
                            var tokenSpan = new SnapshotSpan(curSpan.Snapshot, new Span(curLoc, Value.Length));
                            curLoc += Value.Length;
                            if (tokenSpan.IntersectsWith(curSpan))
                                colorizedTokens.Add(new TagSpan<BatKeywordTokenTag>(tokenSpan, new BatKeywordTokenTag(Value, Tokens.Index, TagType.STRING)));
                        }
                        else
                        {
                            insertCurrentToken = true;
                        }

                        if (insertCurrentToken) // Tokenize anything      
                        {
                            SnapshotSpan tokenSpan = new SnapshotSpan();
                            insertCurrentToken     = false;         
                            // Make sure we do not get beyond the snap shot
                            // When we are on the last line of the text we were off by one
                            var len = Tokens.Current.Length;
                            if(curLoc + len >= curSpan.Snapshot.Length) {
                                len--;
                            }
                            tokenSpan = new SnapshotSpan(curSpan.Snapshot, new Span(curLoc, len));
                            curLoc   += Tokens.Current.Length;
                            if (tokenSpan.IntersectsWith(curSpan))
                                colorizedTokens.Add(new TagSpan<BatKeywordTokenTag>(tokenSpan, new BatKeywordTokenTag(Tokens.Current.Value, Tokens.Index)));
                        }
                        Tokens.Index++;
                    }
                }
            }
            catch (System.Exception ex)
            {
                this.Out(ex.ToString());
                #if DEBUG
                    Util.Utility.MsgBox(": (", ex);
                #endif
            }

           
            return colorizedTokens;
        }

        public IEnumerable<ITagSpan<BatKeywordTokenTag>> __GetTags(NormalizedSnapshotSpanCollection spans){

            foreach (SnapshotSpan curSpan in spans) {

                ITextSnapshotLine containingLine    = curSpan.Start.GetContainingLine();
                int curLoc                          = containingLine.Start.Position;
                string line                         = containingLine.GetText();
                var tokens                          = new TextHighlighterExtension.Tokens(line, curLoc);
                string value                        = null;
                bool insertCurrentToken             = false;
                                    
                while(tokens.Index < tokens.Count){

                        // White Space
                        if (tokens.Current.Type == TokenType.OTHER && tokens.Current.Value == " ")
                        {
                            insertCurrentToken = true;
                        }
                        // :ID
                        else if((tokens.Index==0)&&(tokens.Current.IsOp(":"))&&(tokens.Next.IsID())) {

                            value           = tokens.CurrentNextValue();
                            var tokenSpan   = new SnapshotSpan(curSpan.Snapshot, new Span(curLoc, line.Length));
                            curLoc         += line.Length;
                            if( tokenSpan.IntersectsWith(curSpan) )
                                yield return new TagSpan<BatKeywordTokenTag>(tokenSpan, new BatKeywordTokenTag(value, tokens.Index));                            
                            break;
                        }
                        else if(
                                ( // Rule to detect keyword when they are in the first position
                                    (tokens.Index==0)&&(tokens.Current.IsID()) && (_BatColorEngine.IsKeyword(tokens.Current.Value))
                                ) ||
                                (
                                    (tokens.Current.IsID()) && (tokens.Current.Value.ToLower()=="goto")
                                )                            
                            ) {

                            // REM ----
                            if((_BatColorEngine.IsComment(tokens.Current.Value))){

                                var tokenSpan   = new SnapshotSpan(curSpan.Snapshot, new Span(curLoc, line.Length));
                                curLoc         += line.Length;
                                if( tokenSpan.IntersectsWith(curSpan) ) 
                                    yield return new TagSpan<BatKeywordTokenTag>(tokenSpan, new BatKeywordTokenTag(tokens.Current.Value, tokens.Index));
                                break;
                            }
                            else {                            
                                insertCurrentToken  = true;
                            }
                        }                            
                        // %ID% any where in the string
                        else if((tokens.Current.IsOp("%"))&&(tokens.Next.IsID())&&(tokens.NextNext.IsOp("%"))){
                            
                            value           = tokens.CurrentNextNextValue();
                            var tokenSpan   = new SnapshotSpan(curSpan.Snapshot, new Span(curLoc, value.Length));
                            curLoc         += value.Length;
                            if( tokenSpan.IntersectsWith(curSpan) )
                                yield return new TagSpan<BatKeywordTokenTag>(tokenSpan, new BatKeywordTokenTag(value, tokens.Index));
                            tokens.Index   += 2;
                        }    
                        // %1
                        else if((tokens.Current.IsOp("%"))&&(tokens.Next.IsInteger())){
                            
                            value           = tokens.CurrentNextValue();
                            var tokenSpan   = new SnapshotSpan(curSpan.Snapshot, new Span(curLoc, value.Length));
                            curLoc         += value.Length;
                            if( tokenSpan.IntersectsWith(curSpan) )
                                yield return new TagSpan<BatKeywordTokenTag>(tokenSpan, new BatKeywordTokenTag(value, tokens.Index));
                            tokens.Index   += 1;
                        }
                        // set VAR=43324 color VAR
                        else if((tokens.Current.IsID())&&(tokens.PreviousPrevious.IsID("set", true))){
                            
                            value           = tokens.Current.Value;
                            var tokenSpan   = new SnapshotSpan(curSpan.Snapshot, new Span(curLoc, value.Length));
                            curLoc         += value.Length;
                            if( tokenSpan.IntersectsWith(curSpan) )
                                yield return new TagSpan<BatKeywordTokenTag>(tokenSpan, new BatKeywordTokenTag(value, tokens.Index, TagType.VAR));
                            tokens.Index   += 1;
                        }
                        // goto LABEL - color the label
                        else if((tokens.Current.IsID())&&(tokens.PreviousPrevious.IsID("goto", true))){
                            
                            value           = tokens.Current.Value;
                            var tokenSpan   = new SnapshotSpan(curSpan.Snapshot, new Span(curLoc, value.Length));
                            curLoc         += value.Length;
                                
                            if( tokenSpan.IntersectsWith(curSpan) )
                                yield return new TagSpan<BatKeywordTokenTag>(tokenSpan, new BatKeywordTokenTag(value, tokens.Index, TagType.LABEL));
                            tokens.Index   += 1;
                        }
                        // net START
                        else if ((tokens.Current.IsID()) && (tokens.PreviousPrevious.IsID("net", true)))
                        {
                            value = tokens.Current.Value;
                            var tokenSpan = new SnapshotSpan(curSpan.Snapshot, new Span(curLoc, value.Length));
                            curLoc += value.Length;

                            if (tokenSpan.IntersectsWith(curSpan))
                                yield return new TagSpan<BatKeywordTokenTag>(tokenSpan, new BatKeywordTokenTag(value, tokens.Index, TagType.PARAMETER));
                            tokens.Index += 1;
                        }
                        // /b
                        else if((tokens.Current.IsOp("/"))&&(tokens.Next.IsID())){
                            
                            value           = tokens.CurrentNextValue();
                            var tokenSpan   = new SnapshotSpan(curSpan.Snapshot, new Span(curLoc, value.Length));
                            curLoc         +=value.Length;
                            if( tokenSpan.IntersectsWith(curSpan) )
                                yield return new TagSpan<BatKeywordTokenTag>(tokenSpan, new BatKeywordTokenTag(value, tokens.Index));
                            tokens.Index++;
                        }
                        else{
                            insertCurrentToken = true;
                        }                    
                        if(insertCurrentToken){
                            insertCurrentToken   = false; // Tokenize anything                            
                            var tokenSpan        = new SnapshotSpan(curSpan.Snapshot, new Span(curLoc, tokens.Current.Length));
                            curLoc              +=tokens.Current.Length;
                            if( tokenSpan.IntersectsWith(curSpan) ) 
                            yield return new TagSpan<BatKeywordTokenTag>(tokenSpan, new BatKeywordTokenTag(tokens.Current.Value, tokens.Index));
                        }
                        tokens.Index++;
                }                
            }    
        }
    }
}
