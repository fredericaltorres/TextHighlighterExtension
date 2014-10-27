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



namespace Log4jPropertiesLanguage {

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using Microsoft.VisualStudio.Text;
    using Microsoft.VisualStudio.Text.Classification;
    using Microsoft.VisualStudio.Text.Editor;
    using Microsoft.VisualStudio.Text.Tagging;
    using Microsoft.VisualStudio.Utilities;

    [Export(typeof(ITaggerProvider))]
    [ContentType("properties")]
    [TagType(typeof(ClassificationTag))]
    internal sealed class Log4jPropertiesClassifierProvider : ITaggerProvider {
    
        [Export]
        [Name("properties")]
        [BaseDefinition("code")]
        internal static ContentTypeDefinition OokContentType = null;

        [Export]
        //[FileExtension(".ook")]
        [FileExtension(".properties")]
        [ContentType("properties")]
        internal static FileExtensionToContentTypeDefinition OokFileType = null;

        [Import]
        internal IClassificationTypeRegistryService ClassificationTypeRegistry = null;

        [Import]
        internal IBufferTagAggregatorFactoryService aggregatorFactory = null;

        public ITagger<T> CreateTagger<T>(ITextBuffer buffer) where T : ITag
        {
            ITagAggregator<Log4jPropertiesKeywordTokenTag> ookTagAggregator = aggregatorFactory.CreateTagAggregator<Log4jPropertiesKeywordTokenTag>(buffer);
            return new Log4jPropertiesClassifier(buffer, ookTagAggregator, ClassificationTypeRegistry) as ITagger<T>;
        }
    }

    internal sealed class Log4jPropertiesClassifier : ITagger<ClassificationTag>
    {
        ITextBuffer                         _buffer;
        ITagAggregator<Log4jPropertiesKeywordTokenTag>  _aggregator;

        IClassificationType
            _EqualClassificationType,
            _CommentClassificationType,
            _VarClassificationType,
            _ValueClassificationType,
            _SectionClassificationType;


        internal Log4jPropertiesClassifier(ITextBuffer buffer, ITagAggregator<Log4jPropertiesKeywordTokenTag> batTagAggregator, IClassificationTypeRegistryService typeService){

            #if DEBUG && TRACEON
                        Util.TRACER.START_TRACE();
            #endif
                       

            _buffer                         = buffer;
            _aggregator                     = batTagAggregator;            

            TextHighlighterExtension.ConfigurationEngine.PurgeSingleton();

            _CommentClassificationType      = typeService.GetClassificationType("coloredtext."+TextHighlighterExtension.ConfigurationEngine.Singleton.GetIniColor("Comment"));
            _VarClassificationType          = typeService.GetClassificationType("coloredtext." + TextHighlighterExtension.ConfigurationEngine.Singleton.GetIniColor("Variable"));
            _ValueClassificationType        = typeService.GetClassificationType("coloredtext." + TextHighlighterExtension.ConfigurationEngine.Singleton.GetIniColor("Value"));
            _SectionClassificationType      = typeService.GetClassificationType("coloredtext." + TextHighlighterExtension.ConfigurationEngine.Singleton.GetIniColor("Section"));
            _EqualClassificationType        = typeService.GetClassificationType("coloredtext." + TextHighlighterExtension.ConfigurationEngine.Singleton.GetIniColor("Equal"));

            
        }

        public event EventHandler<SnapshotSpanEventArgs> TagsChanged
        {
            add { }
            remove { }
        }

        public IEnumerable<ITagSpan<ClassificationTag>> GetTags(NormalizedSnapshotSpanCollection spans) {
            var l = new List<ITagSpan<ClassificationTag>>();

            try{
                foreach (var tagSpan in this._aggregator.GetTags(spans)) {

                    var tagSpans                = tagSpan.Span.GetSpans(spans[0].Snapshot);
                    SnapshotSpan snapshotSpan   = tagSpans[0];
                    string  text                = snapshotSpan.GetText();
               
                    IClassificationType ClassificationType = _ValueClassificationType;
                
                    if(tagSpan.Tag.Type==TagType.VAR){ // Must be run first as the var name could be viewed as a keyword

                        ClassificationType = _VarClassificationType;
                    }              
                    else if(tagSpan.Tag.Type==TagType.SECTION){

                        ClassificationType = _SectionClassificationType;
                    }              
                    else if(tagSpan.Tag.Type==TagType.EQUAL){

                        ClassificationType = _EqualClassificationType;
                    }       
                    else if(tagSpan.Tag.Type==TagType.COMMENT){ // Must be run first as the var name could be viewed as a keyword

                        ClassificationType = _CommentClassificationType;
                    }              
                    else if(tagSpan.Tag.Type==TagType.VALUE){

                        ClassificationType = _ValueClassificationType;
                    }              

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

