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

using System.ComponentModel.Composition;
using System.Windows.Media;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace DiffClassifier {

    internal static class ExtensionDefinition {

            [Export]
            [Name("coloredtext")]
            [BaseDefinition("text")]
            internal static ContentTypeDefinition diffContentTypeDefinition = null;

            [Export]
            [FileExtension(".txt")]
            [ContentType("coloredtext")]
            internal static FileExtensionToContentTypeDefinition diffFileExtensionDefinition = null;

            [Export]
            [Name("coloredlog")]
            [BaseDefinition("text")]
            internal static ContentTypeDefinition diffContentTypeDefinitionLog = null;

            [Export]
            [FileExtension(".log")]
            [ContentType("coloredlog")]
            internal static FileExtensionToContentTypeDefinition patchFileExtensionDefinition = null;


    }
}