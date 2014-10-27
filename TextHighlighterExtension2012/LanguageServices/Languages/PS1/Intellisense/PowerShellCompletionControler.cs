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
using TextHighlighterExtension;

namespace Ps1Language
{
    #region Command Filter

    [Export(typeof(IVsTextViewCreationListener))]
    [ContentType("ps1")]
    [TextViewRole(PredefinedTextViewRoles.Interactive)]
    internal sealed class Ps1VsTextViewCreationListener : IVsTextViewCreationListener
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
            IWpfTextView view = AdaptersFactory.GetWpfTextView(textViewAdapter);
            Debug.Assert(view != null);
            CommandFilter filter = new CommandFilter(view, CompletionBroker);
            IOleCommandTarget next;
            textViewAdapter.AddCommandFilter(filter, out next);
            filter.Next = next;
        }
    }
    
    [Export(typeof(IVsTextViewCreationListener))]
    [ContentType("psm1")]
    [TextViewRole(PredefinedTextViewRoles.Interactive)]
    internal sealed class Psm1VsTextViewCreationListener : IVsTextViewCreationListener
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
            IWpfTextView view = AdaptersFactory.GetWpfTextView(textViewAdapter);
            Debug.Assert(view != null);
            CommandFilter filter = new CommandFilter(view, CompletionBroker);
            IOleCommandTarget next;
            textViewAdapter.AddCommandFilter(filter, out next);
            filter.Next = next;
        }
    }
    
    [Export(typeof(IVsTextViewCreationListener))]
    [ContentType("psd1")]
    [TextViewRole(PredefinedTextViewRoles.Interactive)]
    internal sealed class Psd1VsTextViewCreationListener : IVsTextViewCreationListener
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
            IWpfTextView view = AdaptersFactory.GetWpfTextView(textViewAdapter);
            Debug.Assert(view != null);
            CommandFilter filter = new CommandFilter(view, CompletionBroker);
            IOleCommandTarget next;
            textViewAdapter.AddCommandFilter(filter, out next);
            filter.Next = next;
        }
    }


    internal sealed class CommandFilter : IOleCommandTarget
    {
        ICompletionSession _currentSession;

        private void Out(string s)
        {
            System.Diagnostics.Debug.WriteLine(s);
        }

        public CommandFilter(IWpfTextView textView, ICompletionBroker broker)
        {
            this.Out("CommandFilter");
            _currentSession = null;
            TextView        = textView;
            Broker          = broker;
        }

        public IWpfTextView TextView { get; private set; }
        public ICompletionBroker Broker { get; private set; }
        public IOleCommandTarget Next { get; set; }

        private char GetTypeChar(IntPtr pvaIn)
        {
            this.Out("GetTypeChar");
            return (char)(ushort)Marshal.GetObjectForNativeVariant(pvaIn);
        }

        private bool _processDoubleQuote = true;
        private char _lastCharEntered;

        public static string IntellisensePreviousWord = null;
        public static string IntellisenseChar = null;
        public static List<string> IntellisensePreviousWordAlreadyUsedParameters = new List<string>();

        public int Exec(ref Guid pguidCmdGroup, uint nCmdID, uint nCmdexecopt, IntPtr pvaIn, IntPtr pvaOut)
        {
            try {
                this.Out("Exec");
                bool handled = false;
                int hresult = VSConstants.S_OK;
                IntellisensePreviousWord = null;
                IntellisenseChar = null;

                // 1. Pre-process
                if (pguidCmdGroup == VSConstants.VSStd2K)
                {
                    switch ((VSConstants.VSStd2KCmdID)nCmdID)
                    {
                        case VSConstants.VSStd2KCmdID.TYPECHAR:
                            char ch = GetTypeChar(pvaIn);
                       
                            //if (ch == '"')
                            //{                        
                            //    if(_processDoubleQuote) {
                                
                            //        System.Windows.Forms.SendKeys.Send("\"{LEFT}");
                            //    }
                            //    _processDoubleQuote = !_processDoubleQuote;
                            //}        
                        
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
                                if (ch == '-') {

                                    var lastword = GetWordAtTheBeginningOfLine(Ps1Language.CommandFilter.IntellisensePreviousWordAlreadyUsedParameters);
                                    
                                    if(ConfigurationEngine.Singleton.IntellisenseManager.PowerShellDefinitions.IsRelevantToTriggerIntellisense(lastword)) {

                                        Ps1Language.CommandFilter.IntellisensePreviousWord = lastword.ToLower();
                                        Ps1Language.CommandFilter.IntellisenseChar         = "-";
                                        this.StartSession();
                                    }                                    
                                }
                                    /*
                                else if(ch == ' ') {
                                    var lastword = GetWordOnTheLeft();
                                    lastword = lastword == null ? null : lastword.ToLowerInvariant();

                                    // Check the word entered is part of the intelissense metadata
                                    if(ConfigurationEngine.Singleton.IntellisenseManager.BatDefinitions.ContainsKey(lastword)) {

                                        BatLanguage.CommandFilter.IntellisensePreviousWord = lastword;
                                        StartSession(); 
                                    }
                                }
                                     */
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
            catch(System.Exception ex) {
                #if DEBUG
                    Util.Utility.MsgBox(": (", ex);
                #endif
            }
            return VSConstants.E_FAIL;
        }

        string GetWordAtTheBeginningOfLine(List<string> powerShellParameters)
        {                
            SnapshotPoint caret         = TextView.Caret.Position.BufferPosition;
            ITextSnapshot snapshot      = caret.Snapshot;
            ICompletionSession session  = null;
            powerShellParameters.Clear();

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

                    var pipePos = t1.LastIndexOf('|');
                    if(pipePos != -1) 
                        t1 = t1.Substring(pipePos+1).Trim();

                    var parts            = t1.Split(DS.Array(Environment.NewLine), StringSplitOptions.None);
                    var theLine          = parts[parts.Length-1];                    
                    var parts2           = theLine.Split(' ');
                    powerShellParameters.AddRange(GetListOfDashParameter(theLine));
                    return parts2[0];
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

        /// <summary>
        /// Extract all the -param and return them into a list.
        /// This for the intellisense do not offer parameters already used
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        private List<string> GetListOfDashParameter(string line) {

            var parameters = new List<string>();
            var tokens = new Tokens(line, 0, "-", "-", true);
            while(!tokens.EOToken) {
                if(tokens.Current.Type == TokenType.ID && tokens.Current.Value.StartsWith("-")) {
                    parameters.Add(tokens.Current.Value.ToLower().Substring(1));
                }
                tokens.Index++;
            }
            return parameters;
        }
        
        string GetWordOnTheLeft()
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
                        var words = t1.Split( DS.List(' ','\n','\r','\t').ToArray());
                        if(words.Length==0)
                            return null;
                        return words[words.Length-2];
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

        private void Filter()
        {
            this.Out("Filter");
            if (_currentSession == null)
                return;
            if (_currentSession.SelectedCompletionSet == null)
                return;
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

            if (_currentSession.SelectedCompletionSet == null)
                return false;

            if (!_currentSession.SelectedCompletionSet.SelectionStatus.IsSelected && !force)
            {
                _currentSession.Dismiss();
                _currentSession = null;
                return false;
            }
            else
            {
                _currentSession.Commit();
                _currentSession = null;
                return true;
            }
        }

        bool StartSession()
        {
            this.Out("StartSession");
            if (_currentSession != null) return false;

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
            _currentSession.Start();
            _currentSession.Dismissed += (sender, args) => _currentSession = null;
            return true;
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

