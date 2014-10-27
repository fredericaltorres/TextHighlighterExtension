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

namespace CTxtLanguage {

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

    [Export(typeof(ITaggerProvider))]
    [ContentType("ctxt")]
    [TagType(typeof(ClassificationTag))]
    internal sealed class CTxtClassifierProvider : ITaggerProvider {
    
        [Export]
        [Name("ctxt")]
        [BaseDefinition("code")]
        internal static ContentTypeDefinition OokContentType = null;

        [Export]
        [FileExtension(".ctxt")]
        [ContentType("ctxt")]
        internal static FileExtensionToContentTypeDefinition OokFileType = null;

        [Import]
        internal IClassificationTypeRegistryService ClassificationTypeRegistry = null;

        [Import]
        internal IBufferTagAggregatorFactoryService aggregatorFactory = null;

        public ITagger<T> CreateTagger<T>(ITextBuffer buffer) where T : ITag
        {
            ITagAggregator<CTxtKeywordTokenTag> ookTagAggregator =
                                            aggregatorFactory.CreateTagAggregator<CTxtKeywordTokenTag>(buffer);

            return new CTxtClassifier(buffer, ookTagAggregator, ClassificationTypeRegistry) as ITagger<T>;
        }
    }

    internal /*sealed*/ class CTxtClassifier : ITagger<ClassificationTag>
    {
        ITextBuffer                         _buffer;
        ITagAggregator<CTxtKeywordTokenTag> _aggregator;

        IClassificationType                 _DefaultClassificationType;

        Dictionary<string, IClassificationType> _Classifications = new Dictionary<string,IClassificationType>();
        
        TextHighlighterExtension.BatColorEngine          _BatColorEngine;

        internal CTxtClassifier(ITextBuffer buffer, ITagAggregator<CTxtKeywordTokenTag> batTagAggregator, IClassificationTypeRegistryService typeService)
        {
            Init(buffer, batTagAggregator, typeService);
        }

        protected void Init(ITextBuffer buffer, ITagAggregator<CTxtKeywordTokenTag> batTagAggregator, IClassificationTypeRegistryService typeService)
        {
#if DEBUG && TRACEON
                Util.TRACER.START_TRACE();
#endif
            _buffer         = buffer;
            _aggregator     = batTagAggregator;
            var colorsUsed  = ConfigurationEngine.Singleton.CTxtDefinition.GetColorUsed();

            TextHighlighterExtension.ConfigurationEngine.PurgeSingleton();

            foreach(var color in colorsUsed)
            {
                var classification = typeService.GetClassificationType("coloredtext." + color);
                _Classifications.Add(color, classification);
            }

            _DefaultClassificationType     = typeService.GetClassificationType("coloredtext." + TextHighlighterExtension.ConfigurationEngine.Singleton.GetCTxtColor("Default"));
            
        }

        public event EventHandler<SnapshotSpanEventArgs> TagsChanged
        {
            add { }
            remove { }
        }

        public IEnumerable<ITagSpan<ClassificationTag>> GetTags(NormalizedSnapshotSpanCollection spans) {
             
            foreach (var tagSpan in this._aggregator.GetTags(spans)) {

                var tagSpans                = tagSpan.Span.GetSpans(spans[0].Snapshot);
                SnapshotSpan snapshotSpan   = tagSpans[0];
                string  text                = snapshotSpan.GetText();

                IClassificationType classificationType = _DefaultClassificationType;

                if (tagSpan.Tag.Type.In(TagType.SPACE, TagType.OPERATOR, TagType.UNDEFINED))
                { 
                    
                }
                else if (tagSpan.Tag.Type.In(TagType.BEFORE, TagType.AFTER, TagType.REGULAR_LINE))
                { 
                    if(_Classifications.ContainsKey(tagSpan.Tag.Color)) 
                        classificationType = _Classifications[tagSpan.Tag.Color];
                }                
                yield return new TagSpan<ClassificationTag>(tagSpans[0], new ClassificationTag(classificationType));
            }
        }
    }
}

