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
using System.Diagnostics;
using Microsoft.VisualStudio.Editor;
using Microsoft.VisualStudio.Language.Intellisense;
using Microsoft.VisualStudio.OLE.Interop;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.TextManager.Interop;
using Microsoft.VisualStudio.Utilities;
using Microsoft.VisualStudio;
using System.Windows;
using System.Runtime.InteropServices;
using DynamicSugar;

namespace TextHighlighterExtension2012.Languages {

    internal class CommandFilterBaseClass
    {
        protected char GetTypeChar(IntPtr pvaIn)
        {
            this.Out("GetTypeChar");
            return (char) (ushort) Marshal.GetObjectForNativeVariant(pvaIn);
        }

        protected bool _processDoubleQuote = true;
        protected char _lastCharEntered;

        private TextHighlighterExtension2012.ConfigJson _configJson;

        private TextHighlighterExtension2012.ConfigJson configJson
        {
            get
            {
                if (_configJson == null)
                    _configJson = TextHighlighterExtension2012.ConfigJson.Load();
                return _configJson;
            }
        }

        protected void SendKeys(string keys)
        {
            if (configJson.JsonInsertClosingChar)
            {

                System.Windows.Forms.SendKeys.Send(keys);
            }
        }

        protected void Out(string s)
        {
            System.Diagnostics.Debug.WriteLine(s);
        }
    }
}
