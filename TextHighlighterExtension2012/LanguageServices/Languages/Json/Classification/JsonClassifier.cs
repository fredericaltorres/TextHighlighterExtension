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

namespace JsonLanguage {

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using Microsoft.VisualStudio.Text;
    using Microsoft.VisualStudio.Text.Classification;
    using Microsoft.VisualStudio.Text.Editor;
    using Microsoft.VisualStudio.Text.Tagging;
    using Microsoft.VisualStudio.Utilities;

    [Export(typeof(ITaggerProvider))]
    [ContentType("json")]
    [TagType(typeof(ClassificationTag))]
    internal sealed class JsonClassifierProvider : ITaggerProvider {
    
        [Export]
        [Name("json")]
        [BaseDefinition("code")]
        internal static ContentTypeDefinition OokContentType = null;

        [Export]
        [FileExtension(".json")]
        [ContentType("json")]
        internal static FileExtensionToContentTypeDefinition OokFileType = null;

        [Import]
        internal IClassificationTypeRegistryService ClassificationTypeRegistry = null;

        [Import]
        internal IBufferTagAggregatorFactoryService aggregatorFactory = null;

        public ITagger<T> CreateTagger<T>(ITextBuffer buffer) where T : ITag
        {
            ITagAggregator<JsonKeywordTokenTag> ookTagAggregator = aggregatorFactory.CreateTagAggregator<JsonKeywordTokenTag>(buffer);
            return new JsonClassifier(buffer, ookTagAggregator, ClassificationTypeRegistry) as ITagger<T>;
        }
    }

    internal /*sealed*/ class JsonClassifier : ITagger<ClassificationTag>
    {
        ITextBuffer                             _buffer;
        ITagAggregator<JsonKeywordTokenTag>     _aggregator;
        IClassificationType                     _PunctationClassificationType;
        IClassificationType                     _DefaultClassificationType;        
        IClassificationType                     _IdClassificationType;
        IClassificationType                     _StringClassificationType;
        IClassificationType                     _NullClassificationType;
        IClassificationType                     _NumberClassificationType;
        IClassificationType                     _CommentClassificationType;
        IClassificationType                     _BooleanClassificationType;
        IClassificationType                     _DateClassificationType;


        internal JsonClassifier(ITextBuffer buffer, ITagAggregator<JsonKeywordTokenTag> batTagAggregator, IClassificationTypeRegistryService typeService)
        {
            Init(buffer, batTagAggregator, typeService);
        }

        protected void Init(ITextBuffer buffer, ITagAggregator<JsonKeywordTokenTag> batTagAggregator, IClassificationTypeRegistryService typeService)
        {
            _buffer                       = buffer;
            _aggregator                   = batTagAggregator;

            TextHighlighterExtension.ConfigurationEngine.PurgeSingleton();

            _PunctationClassificationType = typeService.GetClassificationType("coloredtext." + TextHighlighterExtension.ConfigurationEngine.Singleton.GetJsonColor("Punctation"));
            _IdClassificationType         = typeService.GetClassificationType("coloredtext." + TextHighlighterExtension.ConfigurationEngine.Singleton.GetJsonColor("Id"));
            _CommentClassificationType    = typeService.GetClassificationType("coloredtext." + TextHighlighterExtension.ConfigurationEngine.Singleton.GetJsonColor("Comment"));
            _StringClassificationType     = typeService.GetClassificationType("coloredtext." + TextHighlighterExtension.ConfigurationEngine.Singleton.GetJsonColor("String"));
            _BooleanClassificationType    = typeService.GetClassificationType("coloredtext." + TextHighlighterExtension.ConfigurationEngine.Singleton.GetJsonColor("Boolean"));
            _NumberClassificationType     = typeService.GetClassificationType("coloredtext." + TextHighlighterExtension.ConfigurationEngine.Singleton.GetJsonColor("Number"));
            _NullClassificationType       = typeService.GetClassificationType("coloredtext." + TextHighlighterExtension.ConfigurationEngine.Singleton.GetJsonColor("Null"));
            _DateClassificationType       = typeService.GetClassificationType("coloredtext." + TextHighlighterExtension.ConfigurationEngine.Singleton.GetJsonColor("Date"));     
            _DefaultClassificationType    = typeService.GetClassificationType("coloredtext." + TextHighlighterExtension.ConfigurationEngine.Singleton.GetJsonColor("Default"));        
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

                    if (tagSpan.Tag.Type == TagType.PUNCTUATION)
                    { 
                        ClassificationType = _PunctationClassificationType;
                    }
                    else if (tagSpan.Tag.Type == TagType.ID)
                    {
                        ClassificationType = _IdClassificationType;
                    }
                    else if(tagSpan.Tag.Type==TagType.NUMBER) { // Must be run first as the var name could be viewed as a keyword

                        ClassificationType = _NumberClassificationType;
                    }
                    else if(tagSpan.Tag.Type==TagType.STRING) { // Must be run first as the var name could be viewed as a keyword

                        ClassificationType = _StringClassificationType;
                    }
                    else if (tagSpan.Tag.Type == TagType.DATE)
                    { // Must be run first as the var name could be viewed as a keyword

                        ClassificationType = _DateClassificationType;
                    }
                    else if (tagSpan.Tag.Type == TagType.BOOLEAN)
                    {
                        ClassificationType = _BooleanClassificationType;
                    }
                    else if (tagSpan.Tag.Type == TagType.COMMENT)
                    {
                        ClassificationType = _CommentClassificationType;
                    }
                    else if (tagSpan.Tag.Type == TagType.NULL)
                    { // Must be run first as the var name could be viewed as a keyword
                        ClassificationType = _NullClassificationType;
                    }
                          
                   // yield return new TagSpan<ClassificationTag>(tagSpans[0], new ClassificationTag(ClassificationType));
                    l.Add(new TagSpan<ClassificationTag>(tagSpans[0], new ClassificationTag(ClassificationType)));
                }
            }
            catch (System.Exception ex)
            {  
                #if DEBUG
                    System.Diagnostics.Debugger.Break();
                #endif
            }
            return l;
        }
    }
}

