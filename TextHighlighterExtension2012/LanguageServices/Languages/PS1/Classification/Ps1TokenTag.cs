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
using System.Linq;
using TextHighlighterExtension;
using DynamicSugar;

namespace Ps1Language {

    [Export(typeof(ITaggerProvider))]
    [ContentType("ps1")]
    [TagType(typeof(Ps1KeywordTokenTag))]

    internal sealed class Ps1TokenTagProvider : ITaggerProvider {

        public ITagger<T> CreateTagger<T>(ITextBuffer buffer) where T : ITag {
                       
            return new Ps1TokenTagger(buffer) as ITagger<T>;
        }
    }

    public enum TagType {

        UNDEFINED,
        KEYWORD,
        COMMAND,
        COMMENT,
        PARAMETER,
        VARIABLE,
        STRING,
        OTHER,
        PUNCTUATION
    }

    public class Ps1KeywordTokenTag : ITag {

        public string w;
        public int Position;
        public TagType Type = TagType.UNDEFINED;

        public Ps1KeywordTokenTag(string w, int position) {

            this.w = w;
            this.Position = position;
        }
        public Ps1KeywordTokenTag(string w, int position, TagType tagType) : this(w, position) {

            this.Type = tagType;
        }
    }

    
    internal /*sealed*/ class Ps1TokenTagger : ITagger<Ps1KeywordTokenTag> {

        ITextBuffer                             _buffer;
        TextHighlighterExtension.Ps1ColorEngine _Ps1ColorEngine;

        internal Ps1TokenTagger(ITextBuffer buffer) {
                        
            _buffer         = buffer;
            _Ps1ColorEngine = new TextHighlighterExtension.Ps1ColorEngine(
                ConfigurationEngine.Singleton.GetPowerShellKeywords().Keys.ToList(),
                ConfigurationEngine.Singleton.GetPowerShellCommands().Keys.ToList()
                );
        }

        private void Out(string s)
        {
            System.Diagnostics.Debug.WriteLine(s);
        }

        public event EventHandler<SnapshotSpanEventArgs> TagsChanged {

            add { } remove { }
        }

        private const string DQUOTE = "\"";
        private const string SQUOTE = "'";

        private bool _QuoteMode = false;

        enum MULTI_LINE_COMMENT_MODE { 
            ON_START_END_COMMENT,
            ON_END_START_COMMENT,
            OFF
        }

        // private MULTI_LINE_COMMENT_MODE _MultiLineCommentMode = MULTI_LINE_COMMENT_MODE.OFF;

        private bool IsCurrentTokenAPowerShellStaticNameSpaceReference(Tokens tokens) {
            try {
                tokens.PushIndex();
                if(tokens.Current.IsID() && (tokens.Previous.Value == "[" || tokens.PreviousPrevious.Value == "[")) {
                    while(!tokens.EOToken) {
                        if(tokens.Next.Type == TokenType.UNDEFINED) {
                            break;
                        }
                        else if(tokens.Next.IsOp(".") || tokens.Next.IsID()) {
                            tokens.Index ++;
                        }
                        else if(tokens.Next.Value == "]") {
                            return true;
                        }
                        else 
                            tokens.Index ++;
                    }
                }
            }
            finally {
                tokens.PopIndex();
            }
            return false;
        }
        /// <summary>
        /// http://blog.280z28.org/archives/2010/01/92/
        /// </summary>
        /// <param name="spans"></param>
        /// <returns></returns>
        public IEnumerable<ITagSpan<Ps1KeywordTokenTag>> GetTags(NormalizedSnapshotSpanCollection spans) {
            
            var colorizedTokens = new List<ITagSpan<Ps1KeywordTokenTag>>();

            try {

                foreach (SnapshotSpan curSpan in spans) {
            
                    ITextSnapshotLine containingLine = curSpan.Start.GetContainingLine();
                    int lineStartPosition            = containingLine.Start.Position;
                    string line                      = containingLine.GetText();
                    string allText                   = containingLine.Snapshot.GetText();
                    Tokens tokens                    = new Tokens(line, lineStartPosition, "-$", "-$", supportSignleQuoteString:true);
                    string Value                     = null;
                    bool InsertCurrentToken          = false;
                    bool parsingPSNameSpace          = false; // sample: [System.NET.NetworkInformation.IPGlobalProperties]::GetIPGlobalProperties()
                    var comments                     = new JSON.SyntaxValidator.CommentParser().Parse(allText, "<#", "#>");

                    if (comments.IsPositionInComment(lineStartPosition) && comments.IsPositionInComment(lineStartPosition)) {
                     
                        var tokenSpan = new SnapshotSpan(curSpan.Snapshot, new Span(lineStartPosition, line.Length));
                        lineStartPosition += line.Length;
                        if (tokenSpan.IntersectsWith(curSpan))
                            colorizedTokens.Add(new TagSpan<Ps1KeywordTokenTag>(tokenSpan, new Ps1KeywordTokenTag(tokens.Current.Value, tokens.Index, TagType.COMMENT)));
                        return colorizedTokens;
                    }

                    while (tokens.Index < tokens.Count) {
                  
                        // -- Double and single quote string
                        if (tokens.Current.Type.In(TokenType.STRING, TokenType.SINGLE_QUOTE_STRING)) {
                        
                            var tokenSpan = new SnapshotSpan(curSpan.Snapshot, new Span(lineStartPosition, tokens.Current.Value.Length));
                            lineStartPosition += tokens.Current.Value.Length;
                            if (tokenSpan.IntersectsWith(curSpan))
                                colorizedTokens.Add(new TagSpan<Ps1KeywordTokenTag>(tokenSpan, new Ps1KeywordTokenTag(tokens.Current.Value, tokens.Index, TagType.STRING)));
                        }

                        // Id with - and $
                        
                        else if (tokens.Current.IsID()) {

                            TagType tagType = TagType.OTHER;

                            if (_Ps1ColorEngine.Keywords.Contains(tokens.Current.Value, StringComparer.OrdinalIgnoreCase)) {
                            
                                tagType = TagType.KEYWORD;
                            }
                            else if (_Ps1ColorEngine.Commands.Contains(tokens.Current.Value, StringComparer.OrdinalIgnoreCase)) {
                            
                                tagType = TagType.COMMAND;
                            }
                            else if (tokens.Current.Value.StartsWith("-")) {

                                tagType = TagType.PARAMETER;
                            }
                            else if (tokens.Current.Value.StartsWith("$")) {

                                tagType = TagType.VARIABLE;
                            }
                            else if ((tokens.Previous.Value == ":") && (tokens.PreviousPrevious.Value == ":")) {

                                tagType = TagType.KEYWORD;
                            }
                            else if (tokens.PreviousPrevious.Value == "function")  {

                                tagType = TagType.COMMAND;
                            }
                            else if (tokens.Previous.Value == "[" || tokens.PreviousPrevious.Value == "[") {

                                if(this.IsCurrentTokenAPowerShellStaticNameSpaceReference(tokens)) {

                                    tagType            = TagType.KEYWORD;
                                    parsingPSNameSpace = true;
                                }
                            }
                            else if (parsingPSNameSpace) { // Is an Id part of a namespace

                                tagType = TagType.KEYWORD;
                                if (tokens.Previous.Value == "]")
                                    parsingPSNameSpace = false; // Found end of namespace declaration
                            }

                            Value = tokens.Current.Value;
                            var tokenSpan = new SnapshotSpan(curSpan.Snapshot, new Span(lineStartPosition, Value.Length));
                            lineStartPosition += Value.Length;
                            if (tokenSpan.IntersectsWith(curSpan))
                                colorizedTokens.Add(new TagSpan<Ps1KeywordTokenTag>(tokenSpan, new Ps1KeywordTokenTag(Value, tokens.Index, tagType)));
                        }
                        else if (tokens.Current.Value == "#") {

                            var tokenSpan = new SnapshotSpan(curSpan.Snapshot, new Span(lineStartPosition, line.Length));
                            lineStartPosition += line.Length;
                            if (tokenSpan.IntersectsWith(curSpan))
                                colorizedTokens.Add(new TagSpan<Ps1KeywordTokenTag>(tokenSpan, new Ps1KeywordTokenTag(tokens.Current.Value, tokens.Index, TagType.COMMENT)));
                            break;
                        }
                        else if (tokens.Current.Value.In("{", "}", "|", "[", "]", "`", "(", ")")) {

                            var tokenSpan = new SnapshotSpan(curSpan.Snapshot, new Span(lineStartPosition, tokens.Current.Value.Length));
                            lineStartPosition += tokens.Current.Value.Length;
                            if (tokenSpan.IntersectsWith(curSpan))
                                colorizedTokens.Add(new TagSpan<Ps1KeywordTokenTag>(tokenSpan, new Ps1KeywordTokenTag(tokens.Current.Value, tokens.Index, TagType.PUNCTUATION)));
                        }
                        else {
                            InsertCurrentToken = true;
                        }
                        if (InsertCurrentToken) {

                            InsertCurrentToken  = false; // Tokenize anything                            
                            var tokenSpan       = new SnapshotSpan(curSpan.Snapshot, new Span(lineStartPosition, tokens.Current.Length));
                            lineStartPosition  += tokens.Current.Length;
                            if (tokenSpan.IntersectsWith(curSpan))
                                colorizedTokens.Add(new TagSpan<Ps1KeywordTokenTag>(tokenSpan, new Ps1KeywordTokenTag(tokens.Current.Value, tokens.Index, TagType.OTHER)));
                        }
                        tokens.Index++;
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
    }
}


