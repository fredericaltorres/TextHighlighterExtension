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

namespace TextHighlighterExtension {

    class BashParser {

        private List<string> _FullSource;

        public BashParser(string batSource) {

            var l                = new List<string>();
            batSource            = batSource.Replace(Environment.NewLine, Environment.NewLine[0].ToString());
            this._FullSource     = batSource.Split(Environment.NewLine[0]).ToList();
        }

        public BashParser(List<string> fullSource) {

            this._FullSource = fullSource;
        }
        public List<string> GetLabels(){

            List<string> l = new List<string>();

            foreach(string s in this._FullSource){

                string label = this.ParseLabel(s);
                if(label!=null){

                    l.Add(label);
                }
            }
            l.Sort();
            return l;
        }
        
        public List<string> GetVariables(){

            List<string> l = new List<string>();

            foreach(string s in this._FullSource){
                var var = this.ParseVariable(s);
                if(var!=null)
                    if(!l.Contains(var))
                        l.Add(var);
            }
            l.Sort();
            return l;
        }
        private string ParseLabel(string l){

            TextHighlighterExtension.Tokens Tokens = new Tokens(l,0);

            Tokens.SkipWhite();

            if(Tokens.Current.IsOp(":")){

                if(Tokens.Next.IsID()){

                    return Tokens.Next.Value;
                }
            }
            return null;
        }
        private string ParseVariable(string l){

            TextHighlighterExtension.Tokens Tokens = new Tokens(l,0);

            Tokens.SkipWhite();

            if(Tokens.Current.IsID("SET", true)){

                if(Tokens.NextNext.IsID()){

                    return Tokens.NextNext.Value;
                }
            }
            return null;
        }
    }
}
