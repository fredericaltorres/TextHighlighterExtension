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
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Classification;

namespace TextHighlighterExtension {

    public class TextHighlighterExtensionClassifier : IClassifier {

        IClassificationTypeRegistryService _classificationTypeRegistry;

        private string _FileExtension;

        internal TextHighlighterExtensionClassifier(IClassificationTypeRegistryService registry, string fileExtension)
        {
            this._classificationTypeRegistry = registry;
            this._FileExtension              = fileExtension;
            TextHighlighterExtension.ConfigurationEngine.PurgeSingleton();
        }
        #pragma warning disable 67
        public event EventHandler<ClassificationChangedEventArgs> ClassificationChanged;
        #pragma warning restore 67
        
        /// <summary>
        /// Classify the given spans, which, for diff files, classifies
        /// a line at a time.
        /// </summary>
        /// <param name="span">The span of interest in this projection buffer.</param>
        /// <returns>The list of <see cref="ClassificationSpan"/> as contributed by the source buffers.</returns>
        public IList<ClassificationSpan> GetClassificationSpans(SnapshotSpan span)
        {
            ITextSnapshot snapshot          = span.Snapshot;
            List<ClassificationSpan> spans  = new List<ClassificationSpan>();

            if(snapshot.Length == 0) return spans;

            int startno = span.Start.GetContainingLine().LineNumber;
            int endno   = (span.End - 1).GetContainingLine().LineNumber;

            for (int i = startno; i <= endno; i++) {
                        
                ITextSnapshotLine line      = snapshot.GetLineFromLineNumber(i);
                IClassificationType type    = null;
                string Line                 = line.Snapshot.GetText(new SnapshotSpan(line.Start, line.Length));
                string Color                = TextHighlighterExtension.ConfigurationEngine.Singleton.GetColorForTextFile(Line, this._FileExtension);
                type                        = _classificationTypeRegistry.GetClassificationType("coloredtext."+Color.ToLower());

                if (type == null){

                    type = _classificationTypeRegistry.GetClassificationType("coloredtext.black");
                }                
                spans.Add(new ClassificationSpan(line.Extent, type));                
            }
            return spans;
        }
    }
}
