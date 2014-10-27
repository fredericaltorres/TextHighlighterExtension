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
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.Language.Intellisense;

namespace TextHighlighterExtension {

    class BashColorEngine {

        private Dictionary<string, string> _BuiltInDescription = new Dictionary<string, string>();
        private Dictionary<string, string> _ReservedKeywordDescription = new Dictionary<string, string>();

        private static System.Windows.Media.Imaging.BitmapImage _batchIconBlack = null;

        public static System.Windows.Media.Imaging.BitmapImage BatchIconBlack{
            get{
                if(_batchIconBlack==null)
                    _batchIconBlack = new System.Windows.Media.Imaging.BitmapImage(new Uri(Util.Utility.GetFQNPathForImage("bat.png")));
                return _batchIconBlack;
            }
        }

        private static System.Windows.Media.Imaging.BitmapImage _batchIconBlue = null;
        public static System.Windows.Media.Imaging.BitmapImage BatchIconBlue{
            get{
                if(_batchIconBlue==null)
                    _batchIconBlue = new System.Windows.Media.Imaging.BitmapImage(new Uri(Util.Utility.GetFQNPathForImage("bat.blue.png")));
                return _batchIconBlue;
            }
        }

        private static System.Windows.Media.Imaging.BitmapImage _powerShellIcon = null;
        public static System.Windows.Media.Imaging.BitmapImage PowerShellIcon{
            get{
                if(_powerShellIcon==null)
                    _powerShellIcon = new System.Windows.Media.Imaging.BitmapImage(new Uri(Util.Utility.GetFQNPathForImage("PS1.png")));
                return _powerShellIcon;
            }
        }

        private static System.Windows.Media.Imaging.BitmapImage _batchIconOrange = null;
        public static System.Windows.Media.Imaging.BitmapImage BatchIconOrange{
            get{
                if(_batchIconOrange==null)
                    _batchIconOrange = new System.Windows.Media.Imaging.BitmapImage(new Uri(Util.Utility.GetFQNPathForImage("bat.orange.png")));
                return _batchIconOrange;
            }
        }

        private void Add(List<Completion>  L, string values){

            this.Add(L, values, true);
        }
        private void Add(List<Completion>  L, string values, bool loweCase){

            foreach(string s in values.Split(',')){

                if(!String.IsNullOrEmpty(s)){

                    if(!String.IsNullOrEmpty(s.Trim())){
                    
                        string ss = loweCase ? s.ToLower() : s;

                        Completion c        = new Completion(ss);
                        c.IconSource        = BatchIconBlack;
                        c.Description       = GetDescription(s.Trim());
                        L.Add(c);
                    }
                }
            }
        }
        public List<Completion> GetIntellisenseForPhrase(string line, List<string> labels, List<string> variables){

            List<Completion> L = new List<Completion>();

            //TextHighlighterExtension.tokens Tokens = new TextHighlighterExtension.tokens(line, 0);

            //Util.TRACER.TRACE("Tokens:{0}", Tokens.ToString());

            //if(Tokens.Count>0){

            //    token LastTok  = Tokens.GetLast(TokenType.ID);
            //    token FirstTok = Tokens.GetFirst(TokenType.ID);

            //    if(line.EndsWith(" %")){
            //        LastTok.Value = "%";
            //    }

            //    List<string> l = TextHighlighterExtension.PythonConfigurationEngine.Instance.GetBATIntellisense(FirstTok.Value.ToLower(), LastTok.Value.ToLower(), Tokens.GetAll());
            //    foreach(string k in l){

            //        if(k=="~labels~"){

            //            foreach(string la in labels) this.Add(L, la, false);
            //        }
            //        else if(k=="~variables~"){

            //            foreach(string la in Sort(variables)) this.Add(L, String.Format("%{0}%", la), false);

            //            System.Collections.IDictionary EnvVars = System.Environment.GetEnvironmentVariables();
            //            foreach(string ev in Sort(GetKeys(EnvVars))){

            //                this.Add(L, String.Format("%{0}%", ev), false);
            //            }
            //        }
            //        else{
            //            this.Add(L, k);
            //        }
            //    }                 
            //}
            //if(L.Count==0){
            //    foreach(string k in this.Keyword){
            //        this.Add(L, k);
            //    }
            //}
            return L;
        }
        private List<string> GetKeys(System.Collections.IDictionary d) {

            List<string> L = new List<string>();
            foreach(string ev in d.Keys){
                L.Add(ev);
            }
            return L;
        }
        private List<string> Sort(List<string> l){

            System.Collections.Generic.SortedList<string, string> SortedL = new SortedList<string,string>();
            foreach(string s in l) SortedL.Add(s,s);

            List<string> L = new List<string>();
            foreach(string k in SortedL.Keys){

                L.Add(k);
            }
            return L;            
        }
        public List<string> BuiltIns {
            get{
                return this._BuiltInDescription.Keys.ToList();
            }
        }
        public List<string> ReservedKeywords {
            get{
                return this._ReservedKeywordDescription.Keys.ToList();
            }
        }
        private string GetDescription(string w){

            w = w.Trim().ToLower();

            if(_BuiltInDescription.ContainsKey(w)){

                return _BuiltInDescription[w];
            }
            return null;
        }
        public BashColorEngine(Dictionary<string, string> builtInDescriptions, Dictionary<string, string> reservedKeywordDescriptions) {
 
            this._BuiltInDescription         = builtInDescriptions;
            this._ReservedKeywordDescription = reservedKeywordDescriptions;
        }
        public bool IsRedirection(string kWord){

            return (kWord.StartsWith(">"));
        }
        public bool IsParam(string kWord){

            return (kWord.StartsWith("/"));
        }
        public bool IsEcho(string kWord){

            return (kWord.ToUpper()=="ECHO")||kWord.ToUpper()=="@ECHO";
        }
        public bool IsEchoPhrase(string kWord){

            return kWord.ToUpper().StartsWith("ECHO ")||kWord.ToUpper().StartsWith("@ECHO ");
        }
        public bool IsEnvironmentVar(string kWord){

            return kWord.StartsWith("%") && kWord.EndsWith("%")&& kWord.Length>1;
        }
        public bool IsParameterReference(string kWord){

            return kWord.StartsWith("%") && kWord.Length>1;
        }
        public bool IsLabel(string kWord){

            return (kWord.ToUpper().StartsWith(":")&&(kWord.Length>1));
        }
        public bool IsComment(string kWord){

            return kWord.ToUpper()=="REM";
        }
        public bool IsCommentPhrase(string kWord){

            return kWord.ToUpper().StartsWith("REM ");
        }
        public bool IsKeywordNotInFirstPosition(string kWord){
                        
            return kWord.ToUpper()=="GOTO";
        }
        public bool IsBuiltIn(string kWord)
        {
            return this.BuiltIns.Contains(kWord) && (!IsReservedWorld(kWord));
        }
        public bool IsReservedWorld(string kWord){

            return this.ReservedKeywords.Contains(kWord);
        }
    }
}
