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

namespace Ps1Language {

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
    using System.Linq;

    [Export(typeof(ITaggerProvider))]
    [ContentType("ps1")]
    [TagType(typeof(ClassificationTag))]
    internal sealed class Ps1ClassifierProvider : ITaggerProvider {

        [Export]
        [Name("ps1")]
        [BaseDefinition("code")]
        internal static ContentTypeDefinition OokContentType = null;

        [Export]
        [FileExtension(".ps1")]
        [ContentType("ps1")]
        internal static FileExtensionToContentTypeDefinition OokFileType = null;

        [Import]
        internal IClassificationTypeRegistryService ClassificationTypeRegistry = null;

        [Import]
        internal IBufferTagAggregatorFactoryService aggregatorFactory = null;

        public ITagger<T> CreateTagger<T>(ITextBuffer buffer) where T : ITag {

            ITagAggregator<Ps1KeywordTokenTag> ookTagAggregator = aggregatorFactory.CreateTagAggregator<Ps1KeywordTokenTag>(buffer);

            return new Ps1Classifier(buffer, ookTagAggregator, ClassificationTypeRegistry) as ITagger<T>;
        }
    }

    internal /*sealed*/ class Ps1Classifier : ITagger<ClassificationTag> {

        ITextBuffer                             _buffer;
        ITagAggregator<Ps1KeywordTokenTag>      _aggregator;

        IClassificationType                     _KeyWordClassificationType;
        IClassificationType                     _CommandClassificationType;
        IClassificationType                     _CommentClassificationType;
        IClassificationType                     _ParameterClassificationType;
        IClassificationType                     _VariableClassificationType;
        IClassificationType                     _StringClassificationType;
        IClassificationType                     _DefaultClassificationType;
        IClassificationType                     _PunctationClassificationType;

        TextHighlighterExtension.Ps1ColorEngine _Ps1ColorEngine;

        internal Ps1Classifier(ITextBuffer buffer, ITagAggregator<Ps1KeywordTokenTag> batTagAggregator, IClassificationTypeRegistryService typeService) {

            this._buffer                       = buffer;
            this._aggregator                   = batTagAggregator;
            this._PunctationClassificationType = typeService.GetClassificationType("coloredtext." + ConfigurationEngine.Singleton.GetPowerShellColor("Punctuation"));
            this._KeyWordClassificationType    = typeService.GetClassificationType("coloredtext." + ConfigurationEngine.Singleton.GetPowerShellColor("Keyword"));
            this._CommandClassificationType    = typeService.GetClassificationType("coloredtext." + ConfigurationEngine.Singleton.GetPowerShellColor("Command"));
            this._CommentClassificationType    = typeService.GetClassificationType("coloredtext." + ConfigurationEngine.Singleton.GetPowerShellColor("Comment"));
            this._ParameterClassificationType  = typeService.GetClassificationType("coloredtext." + ConfigurationEngine.Singleton.GetPowerShellColor("Parameter"));
            this._VariableClassificationType   = typeService.GetClassificationType("coloredtext." + ConfigurationEngine.Singleton.GetPowerShellColor("Variable"));
            this._StringClassificationType     = typeService.GetClassificationType("coloredtext." + ConfigurationEngine.Singleton.GetPowerShellColor("String"));
            this._DefaultClassificationType    = typeService.GetClassificationType("coloredtext." + ConfigurationEngine.Singleton.GetPowerShellColor("Default"));
            
            this._Ps1ColorEngine = new TextHighlighterExtension.Ps1ColorEngine(
                ConfigurationEngine.Singleton.GetPowerShellKeywords().Keys.ToList(),
                ConfigurationEngine.Singleton.GetPowerShellCommands().Keys.ToList()
            );
        }

        public event EventHandler<SnapshotSpanEventArgs> TagsChanged {
            add         { }
            remove      { }
        }

        public IEnumerable<ITagSpan<ClassificationTag>> GetTags(NormalizedSnapshotSpanCollection spans) {

            // Util.TRACER.TRACE_METHOD(spans);


            foreach (var tagSpan in this._aggregator.GetTags(spans)) {

                var tagSpans              = tagSpan.Span.GetSpans(spans[0].Snapshot);
                SnapshotSpan snapshotSpan = tagSpans[0];
                string text               = snapshotSpan.GetText();

                IClassificationType ClassificationType = _DefaultClassificationType;

                if (tagSpan.Tag.Type == TagType.KEYWORD) {

                    ClassificationType = _KeyWordClassificationType;
                }
                else if (tagSpan.Tag.Type == TagType.PUNCTUATION) { 

                    ClassificationType = _PunctationClassificationType;
                }
                else if (tagSpan.Tag.Type == TagType.COMMAND) { 

                    ClassificationType = _CommandClassificationType;
                }
                else if (tagSpan.Tag.Type == TagType.STRING) {

                    ClassificationType = _StringClassificationType;
                }
                else if (tagSpan.Tag.Type == TagType.VARIABLE) {

                    ClassificationType = _VariableClassificationType;
                }
                else if (tagSpan.Tag.Type == TagType.PARAMETER) {

                    ClassificationType = _ParameterClassificationType;
                }
                else if (tagSpan.Tag.Type == TagType.COMMENT) { // Must be run first as the var name could be viewed as a keyword

                    ClassificationType = _CommentClassificationType;
                }
                yield return new TagSpan<ClassificationTag>(tagSpans[0], new ClassificationTag(ClassificationType));
            }
        }
    }
}
