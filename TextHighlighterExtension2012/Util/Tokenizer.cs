using System;
using System.Collections.Generic;

namespace  TextHighlighterExtension {

        /// <summary>
        /// 
        /// </summary>    
        public enum TokenType{
            ID, // Identifer
            INTEGER, // INTEGER
            OP, // :{}[]|\/+-.
            OTHER, // Space Tab
            UNDEFINED, 
            STRING,
            SINGLE_QUOTE_STRING
        }
        /// <summary>
        /// 
        /// </summary>
        public class token {

            public TokenType Type;
            public string   Value;
            public int      Position;
            public int      Length;
            public   int AbsolutePosition;

            public bool IsSlashComment() {
                return this.Type == TokenType.OP && this.Value == "/";
            }

            public bool IsJsonPunctuation() {
                return this.Type == TokenType.OP && (this.Value == "[" || this.Value == "]" || this.Value == "{" || this.Value == "}" || this.Value == ":" || this.Value == ","); 
            }
            public bool IsOp(string v)  { return this.Type==TokenType.OP && this.Value==v;      }
            public bool IsID()          { return this.Type==TokenType.ID;                       }
            public bool IsInteger()     { return this.Type==TokenType.INTEGER;                  }
            public bool IsOther()       { return this.Type==TokenType.OTHER;                    }
            public bool IsID(string id) { return this.IsID(id, false);                          }

            public bool IsWhite() { 

                if(this.Type==TokenType.OTHER){

                    if(String.IsNullOrEmpty(Value)){ return true; }
                    if(String.IsNullOrEmpty(Value.Trim())){ return true; }
                }
                return false;
            }
            public bool IsID(string id, bool ignoreCase) {  

                if(ignoreCase){
                    return this.Type== TokenType.ID && this.Value.ToLower()==id.ToLower();
                }
                else{
                    return this.Type== TokenType.ID && this.Value==id;   
                }
            }
            public token(TokenType type, string value, int position, int absolutePosition){

                this.Value      = value;
                this.Position   = position;
                this.Type       = type;
                this.AbsolutePosition = absolutePosition;

                if(!String.IsNullOrEmpty(this.Value)){

                    this.Length = Value.Length;
                }                
            }
            public override string ToString() {

                return String.Format("t:{0},p:{1},v:{2},l:{3}", Type, Position, Value, Length);
            }
            public static bool IsOp(char c){

                return (char.IsSymbol(c)||char.IsPunctuation(c)) && (c!='"');
            }
            public static bool IsInteger(char c){

                return char.IsDigit(c);
            }
            public static bool IsID(char c) {

                return IsID(c, null);
            }
            public static bool IsDoubleQuote(char c)
            {
                return c == '"';
            }
            public static bool IsID(char c, string extraCharForID){

                return char.IsLetterOrDigit(c) || c == '_' || c == '-' || InString(c, extraCharForID);
            }
            public static bool IsIDFirstLetter(char c) {

                return IsIDFirstLetter(c, null);
            }
            public static bool IsIDFirstLetter(char c, string extraCharForID) {

                return char.IsLetter(c) || c == '_' || InString(c, extraCharForID);
            }
            public static bool IsSingleQuoteStringDelimiter(char c)
            {
                return c =='\'';
            }
            public static bool IsStringDelimiter(char c)
            {
                return c =='"';
            }
            public static bool IsOther(char c) {

                return IsOther(c, null);
            }
            public static bool IsOther(char c, string extraCharForID){

                return (!IsStringDelimiter(c)) && (!IsInteger(c)) && (!IsOp(c)) && (!IsID(c, extraCharForID)) && (!IsIDFirstLetter(c));
            }
            private static bool InString(char c, string s) {
                if (s == null) return false;
                foreach (char cc in s) {
                    if (c == cc) return true;
                }
                return false;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public class Tokens : List<token> {

            public int Index                        = 0;
            private string _extraCharForID          = "";
            private string _extraCharForIDFirstChar = "";            
            const string DQUOTE                     = "\"";
            Stack<int> _stack = new Stack<int>();

            public bool EOToken {
                get {
                    return this.Index >= this.Count;
                }
            }
            public void PushIndex() {

                this._stack.Push(this.Index);
            }
            public int PopIndex() {

                this.Index = this._stack.Pop();
                return this.Index;
            }

            public void NextToken() {

                NextToken(1);
            }
            public void NextToken(int s) {

                this.Index+=s;
            }

            public Util.MultiValue GetMultiLineString(bool readFirst3DoubleQuote) {
                    
                bool FindEndOfMultiLineString   = false;
                System.Text.StringBuilder b     = new System.Text.StringBuilder(1024);

                if(readFirst3DoubleQuote){

                    if((this.Current.Value==DQUOTE)&&(this.Next.Value==DQUOTE)&&(this.NextNext.Value==DQUOTE)){

                        Index+=3;
                    }
                    else return new Util.MultiValue().Add(false);
                }
                while(Index<this.Count){

                    if((this.Current.Value==DQUOTE)&&(this.Next.Value==DQUOTE)&&(this.NextNext.Value==DQUOTE)){

                        Index                      += 3;
                        FindEndOfMultiLineString    = true;
                        break;
                    }
                    b.Append(this[Index].Value);
                    this.NextToken();
                }
                return new Util.MultiValue().Add(true).Add(FindEndOfMultiLineString).Add(b.ToString());
            }

            public Util.MultiValue GetString() {
                    
                bool Ok = false;
                System.Text.StringBuilder b = new System.Text.StringBuilder(1024);

                if(this[Index].Value==DQUOTE){

                    this.NextToken();

                    while(Index<this.Count){

                        if(this[Index].Value==DQUOTE){

                            this.NextToken();
                            Ok = true;
                            break;                            
                        }
                        b.Append(this[Index].Value);
                        this.NextToken();
                    }
                    return new Util.MultiValue().Add(Ok).Add(b.ToString());
                }
                else return new Util.MultiValue().Add(false).Add(null);
            }
            public void SkipWhite(){

                while( (Index<this.Count)&&(this.Current.IsWhite()) ){

                    this.NextToken();
                }
            }
            public string GetUpToSpaceOrCRLF(){
                
                return GetUpTo(' ', System.Environment.NewLine[0]);
            }
            public bool Goto(string value, string beforeValue){

                int beforeValueCounter = 0;
                                    
                while(Index<this.Count){

                    if(this[Index].Value==beforeValue){
                        beforeValueCounter++;                                            
                    }
                    if(this[Index].Value==value){
                        if(beforeValueCounter==0){
                            return true;                        
                        }
                        else{
                            beforeValueCounter--;
                        }
                    }
                    this.NextToken();
                }
                return false;
            }
            public string GetUpTo(char value) {

                return GetUpTo(value, null);
            }
            public string GetUpTo(char value, object value2) {   
                 
                string v = "";
                while(Index<this.Count){

                    if(this[Index].Value==value.ToString()) {

                        v += this[Index].Value; break;
                    }
                    if ((value2!=null)&&(this[Index].Value == value2.ToString())){

                        v += this[Index].Value; break;
                    }
                    v += this[Index].Value;
                    this.NextToken();
                }
                return v;
            }
            public bool Contains(TokenType type, string value) {

                int i=0;

                while(i<this.Count){

                    if((this[i].Type==type)&&(this[i].Value.ToLower()==value.ToLower())){

                        return true;                        
                    }
                    i++;
                }
                return false;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public List<string> GetAll() {
                List<string> L = new List<string>();
                foreach(token t in this){
                    L.Add(t.Value);
                }
                return L;
            }
            public token GetLast(TokenType type) {

                int i=this.Count-1;
                while(i>=0){
                    if(this[i].Type==type){
                        return this[i];
                    }
                    i--;
                }
                return this.BlankToken;
            }

            public token GetNext(TokenType type) {

                while(this.Index<this.Count){

                    if(this[this.Index].Type==type) {
                        return this[this.Index];
                    }
                    this.NextToken();
                }
                return this.BlankToken;
            }

            public token GetFirst(TokenType type) {

                int i = 0;

                while(i<this.Count){

                    if(this[i].Type==type){
                        return this[i];
                    }
                    i++;
                }
                return this.BlankToken;
            }
            public string CurrentToEndValue() {

                System.Text.StringBuilder b = new System.Text.StringBuilder();
                int i=Index;
                while(i<this.Count){
                    b.Append(this[i].Value);
                    i++;
                }
                return b.ToString();
            }
            public string CurrentNextValue(){

                return this.Current.Value + this.Next.Value;
            }
            public string CurrentNextNextValue(){

                return this.Current.Value + this.Next.Value + this.NextNext.Value ;
            }
            public token Current{
                get{
                    if(this.Index<this.Count){

                        return this[this.Index];
                    }
                    else{
                        return this.BlankToken;
                    }
                }
            }
            public token BlankToken{
                get{
                    return new token(TokenType.UNDEFINED, null, 0, 0);
                }
            }
            public token Previous{
                get{
                    try{
                        return this[this.Index-1];
                    }
                    catch{
                        token blank = new token( TokenType.UNDEFINED, null, 0, 0 ); 
                        return blank;
                    }
                }
            }
            public token PreviousPrevious{
                get{
                    try{
                        return this[this.Index-2];
                    }
                    catch{
                        return this.BlankToken;
                    }
                }
            }
            public token Next{
                get{
                    try{
                        return this[this.Index+1];
                    }
                    catch{                        
                        return this.BlankToken;
                    }
                }
            }
            public token NextIgnoreOther
            {
                get
                {
                    try
                    {
                        this.Index++;
                        while (this.Index < this.Count)
                        {
                            if (this[this.Index].IsOther())
                                this.Index++;
                            else
                                break;
                        }
                        return this[this.Index];
                    }
                    catch
                    {
                        return this.BlankToken;
                    }
                }
            }
            public token NextNext{
                get{
                    try{
                        return this[this.Index+2];
                    }
                    catch{
                        return this.BlankToken;
                    }
                }
            }
            public void ParseReverse(string text)
            {
                ParseReverse(text, text.Length-1);
            }
            public void ParseReverse(string text, int offSet){
                try{
                    int i = offSet;

                    while(i>=0){

                        if(token.IsIDFirstLetter(text[i])){

                            this.Add( new token( TokenType.ID, GetIDReverse(text, ref i),0,i) ) ;
                        }
                        else if(token.IsInteger(text[i])){

                            this.Add( new token( TokenType.INTEGER, GetIntegerReverse(text, ref i),0, i) ) ;
                        }
                        else if(token.IsOp(text[i])){

                            this.Add( new token( TokenType.OP, text[i].ToString(),0, i) );
                            i--;
                        }                    
                        else if(token.IsOther(text[i])){

                            this.Add( new token( TokenType.OTHER, GetOtherReverse(text, ref i),0, i) ) ;
                        }
                        else{

                            this.Add( new token( TokenType.UNDEFINED, text[i].ToString(),0, i) );
                            i--;
                        }
                    }
                }
                catch {
                    #if DEBUG
                        throw;
                    #endif
                }
            }
            public Tokens(){

            }
            public Tokens(string text, int curPos) : this(text, curPos, "", "") {

            }
            public Tokens(string text, int curPos, string extraCharForID, string extraCharForIDFirstChar, bool supportSignleQuoteString = false) {
                try{
                    int i                         = 0;
                    this._extraCharForID          = extraCharForID;
                    this._extraCharForIDFirstChar = extraCharForIDFirstChar;
                    
                    while(i<text.Length){

                        if(supportSignleQuoteString && token.IsSingleQuoteStringDelimiter(text[i])) { 
                            i++;
                            var tmpS = GetString(text, ref i, '\'');

                            if (tmpS.Ok)
                            {                           
                                this.Add(new token(TokenType.SINGLE_QUOTE_STRING, tmpS.Value, curPos, i));
                            }
                            else
                            {   // Syntax error end quote is missing, parse it as other
                                this.Add(new token(TokenType.OTHER, tmpS.Value, curPos, i));
                            }
                        }
                        else if (token.IsStringDelimiter(text[i]))
                        {
                            i++;
                            var tmpS = GetString(text, ref i);

                            if (tmpS.Ok)
                            {                           
                                this.Add(new token(TokenType.STRING, tmpS.Value, curPos, i));
                            }
                            else
                            {   // Syntax error end quote is missing, parse it as other
                                this.Add(new token(TokenType.OTHER, tmpS.Value, curPos, i));
                            }
                        }
                        else if (token.IsIDFirstLetter(text[i], this._extraCharForIDFirstChar)) {

                            this.Add( new token( TokenType.ID, GetID(text, ref i), curPos, i) ) ;
                        }
                        else if(token.IsInteger(text[i])){

                            this.Add( new token( TokenType.INTEGER, GetInteger(text, ref i), curPos, i) ) ;
                        }
                        else if(token.IsOp(text[i])){

                            this.Add( new token( TokenType.OP, text[i].ToString(), curPos, i) );
                            i++;
                        }                    
                        else {
                            
                            this.Add( new token( TokenType.OTHER, GetOther(text, ref i), curPos, i) ) ;
                        }
                        curPos += this[this.Count-1].Length;
                    }
                }
                catch{
                 
                    #if DEBUG
                        throw;
                    #endif
                }
            }
            private string GetInteger(string text, ref int i){

                string t = "";
                while((i<text.Length)&&(token.IsInteger(text[i]))){
                    t += text[i];
                    i++;
                }
                return t;
            }
            class ParseStringResult {
                public string Value;
                public bool Ok;
            }
            private ParseStringResult GetString(string text, ref int i, char stringDelimiter = '"')
            {
                var r = new ParseStringResult();
                var t = "";
                while (i < text.Length)
                {
                    if (text[i] == stringDelimiter)
                    { // End of string
                        i++;
                        r.Ok = true;
                        break;
                    }
                    else if (text[i] == '\\' && i < text.Length-1 && text[i + 1] == stringDelimiter) // Escape string
                    {
                        t += "\\" + stringDelimiter;
                        i++;
                    }
                    else // Regular char
                        t += text[i];
                    i++;
                }
                r.Value = stringDelimiter + t + stringDelimiter;
                return r;
            }
            private string GetID(string text, ref int i){

                string t = "";
                while((i<text.Length)&&(token.IsID(text[i], this._extraCharForID))){
                    t += text[i];
                    i++;
                }
                return t;
            }
            private string GetOther(string text, ref int i){

                string t = "";
                while((i<text.Length)&&(token.IsOther(text[i]))){
                    t += text[i];
                    i++;
                }
                return t;
            }
            public override string ToString() {

                System.Text.StringBuilder b = new System.Text.StringBuilder(1024);
                foreach(token t in this){
                    b.AppendFormat("({0}),", t.ToString());
                }
                if(b.ToString().Length>0){
                    return Util.Utility.RemoveLastChar(b.ToString());
                }
                else{
                    return b.ToString();
                }
            }
            private string GetIntegerReverse(string text, ref int i){

                string t = "";
                while((i>=0)&&(token.IsInteger(text[i]))){
                    t = text[i] + t;
                    i--;
                }
                return t;
            }
            private string GetIDReverse(string text, ref int i){

                string t = "";
                while((i>=0)&&(token.IsID(text[i]))){
                    t = text[i] + t;
                    i--;
                }
                return t;
            }
            private string GetOtherReverse(string text, ref int i){

                string t = "";
                while((i>=0)&&(token.IsOther(text[i]))){
                    t = text[i] + t;
                    i--;
                }
                return t;
            }
        }
}
