//#region License - TextHighLighterExtension v 1.x - Copyright (c) 2010 Frederic Torres
///*
//Text syntax Highlighting for Visual Studio 2010 (.txt, .log, .bat, .ini)
//http://www.frederictorres.net
 
//LICENSE

//Permission is hereby granted, free of charge, to any person obtaining a copy
//of this software and associated documentation files (the "Software"), to deal
//in the Software without restriction, including without limitation the rights
//to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//copies of the Software, and to permit persons to whom the Software is
//furnished to do so, subject to the following conditions:

//The above copyright notice and this permission notice shall be included in
//all copies or substantial portions of the Software.

//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//THE SOFTWARE.
//*/
//#endregion

//using System;
//using System.Collections.Generic;
//using System.ComponentModel.Composition;
//using Microsoft.VisualStudio.Text;
//using Microsoft.VisualStudio.Text.Classification;
//using Microsoft.VisualStudio.Text.Editor;
//using Microsoft.VisualStudio.Text.Tagging;
//using Microsoft.VisualStudio.Utilities;
//using TextHighlighterExtension;
//using DynamicSugar;
//using JSON.SyntaxValidator;
//using System.Threading;

//namespace JsonLanguage
//{
//    [Export(typeof(ITaggerProvider))]
//    [ContentType("json")]
//    [TagType(typeof(JsonErrorTokenTag))]
//    internal sealed class JsonErrorTokenTagProvider : ITaggerProvider
//    {
//        public ITagger<T> CreateTagger<T>(ITextBuffer buffer) where T : ITag
//        {         
//            return new JsonErrorTokenTagger(buffer) as ITagger<T>;
//        }
//    }

//    public class JsonErrorTokenTag : ErrorTag
//    {
//        public string w;
//        public int Position;
//        public TagType Type = TagType.ERROR;

//        public JsonErrorTokenTag(string w, int position, string message) : base("JsonSyntaxError", message)
//        {
//            this.w = w; this.Position = position;
//        }
//    }

//    internal /*sealed*/ class JsonErrorTokenTagger : ITagger<JsonErrorTokenTag>
//    {
//        ITextBuffer _buffer;

//        internal JsonErrorTokenTagger(ITextBuffer buffer)
//        {
//            _buffer = buffer;
//        }

//        //public event EventHandler<SnapshotSpanEventArgs> TagsChanged
//        //{
//        //    add { }
//        //    remove { }
//        //}

//        private void Out(string s)
//        {
//            System.Diagnostics.Debug.WriteLine(s);
//        }

//        private bool _previousValidationFailed                          = false;
//        private JSON.SyntaxValidator.MD5Hash _previousCommentHash       = null;
//        private JSON.SyntaxValidator.MD5Hash _previousJsonSourceHash    = null;
//        private Json.JsonValidator.JsonErrorInfo _jsonErrorInfo         = null;
//        private Json.JsonValidator.JsonErrorInfo _previousJsonErrorInfo = new Json.JsonValidator.JsonErrorInfo();

//        private class BackgroundInfo {

//            public string Source;
//            public CommentInfos Comments;
//            public Json.JsonValidator.JsonErrorInfo JsonErrorInfo;
//        }

//        BackgroundInfo __BackgroundInfo;

//        bool _runningFromBkThread;

//        public void ThreadPoolCallback(Object threadContext) {

//            var backgroundInfo              = threadContext as BackgroundInfo;
//            backgroundInfo.JsonErrorInfo    = Json.JsonValidator.ValidateJson(backgroundInfo.Source, backgroundInfo.Comments);
//            _runningFromBkThread = true;
//            this.RequestFullRefresh();
//            _runningFromBkThread = false;
//        }

//        private void StartBackgroundValidation(string source, CommentInfos comments) {

//             ThreadPool.QueueUserWorkItem(this.ThreadPoolCallback, new BackgroundInfo() { Source = source, Comments = comments });
//        }

//        public IEnumerable<ITagSpan<JsonErrorTokenTag>> GetTags(NormalizedSnapshotSpanCollection spans)
//        {
//            var requestAFullRefresh                        = false;
//            var colorizedTokens                            = new List<ITagSpan<JsonErrorTokenTag>>();
//            JSON.SyntaxValidator.CommentInfos comments     = null;

//            if(_runningFromBkThread)
//            {
               
//            }
            
//            try
//            {
//                foreach (SnapshotSpan curSpan in spans) // << spans collection always contains 1 object
//                {
//                    ITextSnapshotLine containingLine = curSpan.Start.GetContainingLine();
//                    int curLocStart                  = containingLine.Start.Position;
//                    int curLocEnd                    = containingLine.End.Position;
//                    string line                      = containingLine.GetText();
//                    string allJsonSource             = containingLine.Snapshot.GetText();
//                    Tokens Tokens                    = new Tokens(line, curLocStart, "$", "$");

//                    if(comments == null) // Detect that we are processing the first tags
//                    { 
//                        comments = new JSON.SyntaxValidator.CommentParser().Parse(allJsonSource);
//                    }

//                    // Detect change in the comment as we may request a full refresh
//                    // Because of the comment metadata like "use relax" or minimap:true or :openconfig
//                    if ((!comments.Hash.Equals(_previousCommentHash)) && _previousCommentHash != null)
//                    {
//                        requestAFullRefresh = true;
//                    }
//                    _previousCommentHash = comments.Hash;

//                    // Detect if json source text changed, because if it does not we do not need to execute
//                    // the JSON syntax validation, we re use the previous result.
//                    var jsonSourceHash = MD5Hash.Make(allJsonSource);
//                    if(!jsonSourceHash.Equals(this._previousJsonSourceHash)) {

//                        _jsonErrorInfo               = Json.JsonValidator.ValidateJson(allJsonSource, comments);
//                        this._previousJsonSourceHash = jsonSourceHash;
//                        StartBackgroundValidation(allJsonSource, comments);
//                    }

//                    //this.Out("\nValidation:[curLocStart:{0},curLocEnd:{1}]{2}".format(curLocStart, curLocEnd, line));
                    
//                    if (_jsonErrorInfo.Valid)
//                    {                    
//                        if (_previousValidationFailed)
//                        {
//                            _previousValidationFailed   = false;
//                            requestAFullRefresh         = true;
//                        }
//                    }
//                    else
//                    {
//                        _previousValidationFailed = true;
                       
//                        if ((_jsonErrorInfo.AbsPosition >= curLocStart || _jsonErrorInfo.AbsPosition + 2 >= curLocStart) && _jsonErrorInfo.AbsPosition <= curLocEnd)
//                        {
//                            var tokenSpan = new SnapshotSpan(curSpan.Snapshot, new Span(curLocStart, line.Length));
//                            curLocStart  += line.Length;
//                            if (tokenSpan.IntersectsWith(curSpan))
//                                colorizedTokens.Add(new TagSpan<JsonErrorTokenTag>(tokenSpan, new JsonErrorTokenTag(Tokens.Current.Value, Tokens.Index, _jsonErrorInfo.Message)));
//                        }

//                        // If validation failed twice in a row for different reason we
//                        // need to request a full refresh
//                        if(_previousJsonErrorInfo.ToString() != _jsonErrorInfo.ToString()) {
//                            requestAFullRefresh = true;
//                        }
//                    }
//                }
//            }
//            catch (System.Exception ex)
//            {
//                this.Out(ex.ToString());
//                #if DEBUG
//                    //System.Diagnostics.Debugger.Break();
//                #endif
//            }

//            if(requestAFullRefresh)
//                this.RequestFullRefresh();

//            _previousJsonErrorInfo = _jsonErrorInfo;

//            return colorizedTokens;
//        }

//        // the Classifier tagger is translating buffer change events into TagsChanged events, so we don't have to
//        #pragma warning disable 67
//        public event EventHandler<SnapshotSpanEventArgs> TagsChanged;
//        #pragma warning restore

//        public void RequestFullRefresh()
//        {
//            var snapshot    = _buffer.CurrentSnapshot;
//            var tagsChanged = this.TagsChanged;
//            if (tagsChanged != null)
//            {
//                tagsChanged(this, new SnapshotSpanEventArgs(new SnapshotSpan(snapshot, new Span(0, snapshot.Length))));
//            }
//        }
//    }
//}
