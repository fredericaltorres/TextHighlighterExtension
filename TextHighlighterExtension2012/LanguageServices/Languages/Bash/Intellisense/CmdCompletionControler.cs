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
//using System.Diagnostics;
//using Microsoft.VisualStudio.Editor;
//using Microsoft.VisualStudio.Language.Intellisense;
//using Microsoft.VisualStudio.OLE.Interop;
//using Microsoft.VisualStudio.Text;
//using Microsoft.VisualStudio.Text.Editor;
//using Microsoft.VisualStudio.TextManager.Interop;
//using Microsoft.VisualStudio.Utilities;
//using Microsoft.VisualStudio;
//using System.Windows;
//using System.Runtime.InteropServices;
//using DynamicSugar;
//using TextHighlighterExtension;

//namespace CmdLanguage
//{
//    #region Command Filter

//    [Export(typeof(IVsTextViewCreationListener))]
//    [ContentType("cmd")]
//    [TextViewRole(PredefinedTextViewRoles.Interactive)]
//    internal sealed class CmdVsTextViewCreationListener : IVsTextViewCreationListener
//    {
//        [Import]
//        IVsEditorAdaptersFactoryService AdaptersFactory = null;

//        [Import]
//        ICompletionBroker CompletionBroker = null;

//        private void Out(string s)
//        {
//            System.Diagnostics.Debug.WriteLine(s);
//        }

//        public void VsTextViewCreated(IVsTextView textViewAdapter)
//        {
//            this.Out("VsTextViewCreated");
//            IWpfTextView view = AdaptersFactory.GetWpfTextView(textViewAdapter);
//            Debug.Assert(view != null);
//            var filter = new BatLanguage.CommandFilter(view, CompletionBroker);
//            IOleCommandTarget next;
//            textViewAdapter.AddCommandFilter(filter, out next);
//            filter.Next = next;
//        }
//    }

//    #endregion
//}
