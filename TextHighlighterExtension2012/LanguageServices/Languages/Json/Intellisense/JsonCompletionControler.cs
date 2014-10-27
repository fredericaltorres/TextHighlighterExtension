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

namespace JsonLanguage
{
    #region Command Filter

    [Export(typeof(IVsTextViewCreationListener))]
    [ContentType("json")]
    [TextViewRole(PredefinedTextViewRoles.Interactive)]
    internal sealed class JsonVsTextViewCreationListener : IVsTextViewCreationListener
    {
        [Import]
        IVsEditorAdaptersFactoryService AdaptersFactory = null;

        [Import]
        ICompletionBroker CompletionBroker = null;

        private void Out(string s)
        {
            System.Diagnostics.Debug.WriteLine(s);
        }

        public void VsTextViewCreated(IVsTextView textViewAdapter)
        {
            this.Out("VsTextViewCreated");
            IWpfTextView view = AdaptersFactory.GetWpfTextView(textViewAdapter);
            Debug.Assert(view != null);
            CommandFilter filter = new CommandFilter(view, CompletionBroker);
            IOleCommandTarget next;
            textViewAdapter.AddCommandFilter(filter, out next);
            filter.Next = next;
        }
    }

    internal sealed class CommandFilter : TextHighlighterExtension2012.Languages.CommandFilterBaseClass, IOleCommandTarget
    {
        ICompletionSession _currentSession;

        public IWpfTextView         TextView { get; private set; }
        public ICompletionBroker    Broker { get; private set; }
        public IOleCommandTarget    Next { get; set; }

        public CommandFilter(IWpfTextView textView, ICompletionBroker broker)
        {
            this.Out("CommandFilter");
            _currentSession = null;
            TextView        = textView;
            Broker          = broker;
        }

        public int Exec(ref Guid pguidCmdGroup, uint nCmdID, uint nCmdexecopt, IntPtr pvaIn, IntPtr pvaOut)
        {
            this.Out("Exec");
            bool handled = false;
            int hresult = VSConstants.S_OK;

            // 1. Pre-process
            if (pguidCmdGroup == VSConstants.VSStd2K)
            {
                switch ((VSConstants.VSStd2KCmdID)nCmdID)
                {
                    case VSConstants.VSStd2KCmdID.TYPECHAR:
                        char ch = GetTypeChar(pvaIn);
                       
                        if (ch == '*' && this._lastCharEntered == '/')
                        {                        
                            this.SendKeys("  */{LEFT}{LEFT}{LEFT}");  
                        }
                        else if (ch == '{')
                        {                        
                            var charOnLeft = GetCharOnTheLeft();
                            if(charOnLeft.In(":", ",")) {
                                 this.SendKeys("  {}}, {LEFT}{LEFT}{LEFT}{LEFT}");
                            }
                            else {
                                 this.SendKeys("  {}}{LEFT}{LEFT}");
                            }
                        }
                        else if (ch == '[')
                        {        
                            var charOnLeft = GetCharOnTheLeft();
                            if(charOnLeft == ":") {
                                 this.SendKeys("], {LEFT}{LEFT}{LEFT}");
                            }
                            else {
                                 this.SendKeys("]{LEFT}");
                            }
                        }
                        else if (ch == '"')
                        {                        
                            if(_processDoubleQuote) {
                                var charOnLeft = GetCharOnTheLeft();
                                if(charOnLeft == ":") {
                                     this.SendKeys("\", {LEFT}{LEFT}{LEFT}");
                                }
                                else {
                                     this.SendKeys("\"{LEFT}");
                                }
                            }
                            _processDoubleQuote = !_processDoubleQuote;
                        }        
                        else if (ch == ':')
                        {
                            // handled = StartSession();
                        }              
                         _lastCharEntered = ch;
                        break;
                    case VSConstants.VSStd2KCmdID.AUTOCOMPLETE:
                    case VSConstants.VSStd2KCmdID.COMPLETEWORD:
                        handled = StartSession();
                        break;
                    case VSConstants.VSStd2KCmdID.RETURN:
                        handled = Complete(false);
                        break;
                    case VSConstants.VSStd2KCmdID.TAB:
                        handled = Complete(true);
                        break;
                    case VSConstants.VSStd2KCmdID.CANCEL:
                        handled = Cancel();
                        break;
                }
            }

            if (!handled)
                hresult = Next.Exec(pguidCmdGroup, nCmdID, nCmdexecopt, pvaIn, pvaOut);

            if (ErrorHandler.Succeeded(hresult))
            {
                if (pguidCmdGroup == VSConstants.VSStd2K)
                {
                    switch ((VSConstants.VSStd2KCmdID)nCmdID)
                    {
                        case VSConstants.VSStd2KCmdID.TYPECHAR:
                            char ch = GetTypeChar(pvaIn);
                            if (ch == ':')
                            {
                                //StartSession();
                            }
                            else if (_currentSession != null)
                                Filter();
                            break;
                        case VSConstants.VSStd2KCmdID.BACKSPACE:
                            Filter();
                            break;
                    }
                }
            }
            return hresult;
        }

        private void Filter()
        {
            this.Out("Filter");
            if (_currentSession == null)
                return;
            if (_currentSession.SelectedCompletionSet == null)
            {
                this.Out("_currentSession.SelectedCompletionSet SHOULD NOT BE NULL");
                return;
            }
            _currentSession.SelectedCompletionSet.SelectBestMatch();
            _currentSession.SelectedCompletionSet.Recalculate();
        }

        bool Cancel()
        {
            this.Out("Cancel");
            if (_currentSession == null)
                return false;
            _currentSession.Dismiss();
            return true;
        }

        bool Complete(bool force)
        {
            this.Out("Complete");
            if (_currentSession == null)
                return false;

            if(_currentSession.SelectedCompletionSet == null)
            {
                this.Out("_currentSession.SelectedCompletionSet SHOULD NOT BE NULL");
                return false;
            }

            if (!_currentSession.SelectedCompletionSet.SelectionStatus.IsSelected && !force)
            {
                _currentSession.Dismiss();
                return false;
            }
            else
            {
                _currentSession.Commit();
                return true;
            }
        }

        string GetCharOnTheLeft()
        {                
            SnapshotPoint caret         = TextView.Caret.Position.BufferPosition;
            ITextSnapshot snapshot      = caret.Snapshot;
            ICompletionSession session  = null;

            try {
                if (!Broker.IsCompletionActive(TextView)) {
                    session = Broker.CreateCompletionSession(TextView, snapshot.CreateTrackingPoint(caret, PointTrackingMode.Positive), true);
                }
                else {
                    session = Broker.GetSessions(TextView)[0];
                }
               
                var triggerPoint = (SnapshotPoint)session.GetTriggerPoint(snapshot);

                if(triggerPoint != null) {
              
                    var lineSnapshot  = triggerPoint.GetContainingLine();
                    var allText       = lineSnapshot.Snapshot.GetText();
                    var t1            = allText.Substring(0,caret.Position).Trim();
                    if(t1.Length>0) {
                        var r = t1[t1.Length-1].ToString();
                        return r;
                    }
                }
            }
            catch {
                // Swallo exception to avoid disrupting Visual Studio
            }
            finally{
                 session.Dismiss();
            }    
            return null;
         }

        bool StartSession()
        {
            this.Out("StartSession");
            // if (_currentSession != null) return false;

            SnapshotPoint caret    = TextView.Caret.Position.BufferPosition;
            ITextSnapshot snapshot = caret.Snapshot;

            if (!Broker.IsCompletionActive(TextView))
            {
                _currentSession = Broker.CreateCompletionSession(TextView, snapshot.CreateTrackingPoint(caret, PointTrackingMode.Positive), true);
            }
            else
            {
                _currentSession = Broker.GetSessions(TextView)[0];
            }

            // Session already started during the pre process
            _currentSession.Start();

            _currentSession.Dismissed += (sender, args) =>_currentSession = null;
            return _currentSession.SelectedCompletionSet != null;
            
        }

        public int QueryStatus(ref Guid pguidCmdGroup, uint cCmds, OLECMD[] prgCmds, IntPtr pCmdText)
        {
            if (pguidCmdGroup == VSConstants.VSStd2K)
            {
                switch ((VSConstants.VSStd2KCmdID)prgCmds[0].cmdID)
                {
                    case VSConstants.VSStd2KCmdID.AUTOCOMPLETE:
                    case VSConstants.VSStd2KCmdID.COMPLETEWORD:
                        prgCmds[0].cmdf = (uint)OLECMDF.OLECMDF_ENABLED | (uint)OLECMDF.OLECMDF_SUPPORTED;
                        return VSConstants.S_OK;
                }
            }
            return Next.QueryStatus(pguidCmdGroup, cCmds, prgCmds, pCmdText);
        }
    }

    #endregion
}
