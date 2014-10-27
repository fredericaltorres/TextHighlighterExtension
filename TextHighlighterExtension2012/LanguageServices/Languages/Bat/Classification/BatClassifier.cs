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

namespace BatLanguage {

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using Microsoft.VisualStudio.Text;
    using Microsoft.VisualStudio.Text.Classification;
    using Microsoft.VisualStudio.Text.Editor;
    using Microsoft.VisualStudio.Text.Tagging;
    using Microsoft.VisualStudio.Utilities;

    [Export(typeof(ITaggerProvider))]
    [ContentType("bat")]
    [TagType(typeof(ClassificationTag))]
    internal sealed class BatClassifierProvider : ITaggerProvider {
    
        [Export]
        [Name("bat")]
        [BaseDefinition("code")]
        internal static ContentTypeDefinition OokContentType = null;

        [Export]        
        [FileExtension(".bat")]
        [ContentType("bat")]
        internal static FileExtensionToContentTypeDefinition OokFileType = null;

        [Import]
        internal IClassificationTypeRegistryService ClassificationTypeRegistry = null;

        [Import]
        internal IBufferTagAggregatorFactoryService aggregatorFactory = null;

        public ITagger<T> CreateTagger<T>(ITextBuffer buffer) where T : ITag
        {
            ITagAggregator<BatKeywordTokenTag> ookTagAggregator = 
                                            aggregatorFactory.CreateTagAggregator<BatKeywordTokenTag>(buffer);

            return new BatClassifier(buffer, ookTagAggregator, ClassificationTypeRegistry) as ITagger<T>;
        }
    }

    internal /*sealed*/ class BatClassifier : ITagger<ClassificationTag>
    {
        ITextBuffer                         _buffer;
        ITagAggregator<BatKeywordTokenTag>  _aggregator;

        IClassificationType                 _KeyWordClassificationType;
        IClassificationType                 _DefaultClassificationType;        
        IClassificationType                 _CommentClassificationType;
        IClassificationType                 _LabelClassificationType;
        IClassificationType                 _ParameterClassificationType;
        IClassificationType                 _EnvVarClassificationType;
        IClassificationType                 _FlagClassificationType;
        IClassificationType                 _StringClassificationType;
        IClassificationType                 _RedirectionClassificationType;
        IClassificationType                 _PunctuationClassificationType;

        TextHighlighterExtension.BatColorEngine          _BatColorEngine;

        internal BatClassifier(ITextBuffer buffer, ITagAggregator<BatKeywordTokenTag> batTagAggregator, IClassificationTypeRegistryService typeService){

            Init(buffer, batTagAggregator, typeService);
        }

        protected void Init(ITextBuffer buffer, ITagAggregator<BatKeywordTokenTag> batTagAggregator, IClassificationTypeRegistryService typeService) {
#if DEBUG && TRACEON
                Util.TRACER.START_TRACE();
#endif

            _buffer                        = buffer;
            _aggregator                    = batTagAggregator;

            TextHighlighterExtension.ConfigurationEngine.PurgeSingleton();
            _KeyWordClassificationType     = typeService.GetClassificationType("coloredtext." + TextHighlighterExtension.ConfigurationEngine.Singleton.GetBatColor("Keyword"));
            _CommentClassificationType     = typeService.GetClassificationType("coloredtext." + TextHighlighterExtension.ConfigurationEngine.Singleton.GetBatColor("Comment"));
            _FlagClassificationType        = typeService.GetClassificationType("coloredtext." + TextHighlighterExtension.ConfigurationEngine.Singleton.GetBatColor("Flag"));
            _LabelClassificationType       = typeService.GetClassificationType("coloredtext." + TextHighlighterExtension.ConfigurationEngine.Singleton.GetBatColor("Label"));
            _EnvVarClassificationType      = typeService.GetClassificationType("coloredtext." + TextHighlighterExtension.ConfigurationEngine.Singleton.GetBatColor("EnvVar"));
            _RedirectionClassificationType = typeService.GetClassificationType("coloredtext." + TextHighlighterExtension.ConfigurationEngine.Singleton.GetBatColor("Redirection"));
            _PunctuationClassificationType = typeService.GetClassificationType("coloredtext." + TextHighlighterExtension.ConfigurationEngine.Singleton.GetBatColor("Punctuation"));
            _DefaultClassificationType     = typeService.GetClassificationType("coloredtext." + TextHighlighterExtension.ConfigurationEngine.Singleton.GetBatColor("Default"));
            _ParameterClassificationType   = typeService.GetClassificationType("coloredtext." + TextHighlighterExtension.ConfigurationEngine.Singleton.GetBatColor("Parameter"));
            _StringClassificationType      = typeService.GetClassificationType("coloredtext." + TextHighlighterExtension.ConfigurationEngine.Singleton.GetBatColor("String"));

            _BatColorEngine                = new TextHighlighterExtension.BatColorEngine(TextHighlighterExtension.ConfigurationEngine.Singleton.GetBatKeywordDescription());
        }

        public event EventHandler<SnapshotSpanEventArgs> TagsChanged
        {
            add { }
            remove { }
        }

        public IEnumerable<ITagSpan<ClassificationTag>> GetTags(NormalizedSnapshotSpanCollection spans) {

            var l = new List<ITagSpan<ClassificationTag>>();
            try {
                foreach (var tagSpan in this._aggregator.GetTags(spans)) {

                    var tagSpans                = tagSpan.Span.GetSpans(spans[0].Snapshot);
                    SnapshotSpan snapshotSpan   = tagSpans[0];
                    string  text                = snapshotSpan.GetText();

                    IClassificationType ClassificationType = _DefaultClassificationType;
                    if (text == " ")
                    {

                    }
                    else if (tagSpan.Tag.Type == TagType.POWERSHELL)
                    {
                        ClassificationType = _StringClassificationType;
                    }
                    else if (tagSpan.Tag.Type == TagType.PUNCTUTATION)
                    {
                        ClassificationType = _PunctuationClassificationType;
                    }
                    else if (tagSpan.Tag.Type == TagType.KEYWORD)
                    { 
                        ClassificationType = _KeyWordClassificationType;
                    }
                    else if (tagSpan.Tag.Type == TagType.COMMENT)
                    {
                        ClassificationType = _CommentClassificationType;
                    }
                    else if (tagSpan.Tag.Type == TagType.STRING)
                    {
                        ClassificationType = _StringClassificationType;
                    }
                    else if(tagSpan.Tag.Type==TagType.VAR) { // Must be run first as the var name could be viewed as a keyword

                        ClassificationType = _EnvVarClassificationType;
                    }
                    else if(tagSpan.Tag.Type==TagType.LABEL) { // Must be run first as the var name could be viewed as a keyword

                        ClassificationType = _LabelClassificationType;
                    }
                    else if (tagSpan.Tag.Type == TagType.MACRO_VAR)
                    {
                        ClassificationType = _EnvVarClassificationType;
                    }
                    else if (tagSpan.Tag.Type == TagType.PARAMETER)
                    { // Must be run first as the var name could be viewed as a keyword
                        ClassificationType = _ParameterClassificationType;
                    }
                    else if(_BatColorEngine.IsRedirection(text)) {
                    
                        ClassificationType = _RedirectionClassificationType;
                    }                   
                    else if(_BatColorEngine.IsParameterReference(text)){
                    
                        ClassificationType = _EnvVarClassificationType;
                    }                                                                           
                    else if(_BatColorEngine.IsParam(text)){

                        ClassificationType = _FlagClassificationType;
                    }
                               
                    l.Add(new TagSpan<ClassificationTag>(tagSpans[0], new ClassificationTag(ClassificationType)));
                }
            }
            catch (System.Exception ex)
            {  
                #if DEBUG
                    Util.Utility.MsgBox(": (", ex);
                #endif
            }
            return l;
        }
    }
}

