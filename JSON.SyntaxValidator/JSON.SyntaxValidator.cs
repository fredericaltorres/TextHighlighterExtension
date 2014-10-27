/*
 JSON Syntax Validator
 (C) Torres Frederic 2013

 Based on code from: How do I write my own parser? (for JSON) By Patrick van Bergen http://techblog.procurios.nl/k/618/news/view/14605/14863/How-do-I-write-my-own-parser-for-JSON.html
 My library heavily change Patrick van Bergen's code. 
 
 The library is release under the Mit Style License

 */
using System;
using System.Collections;
using System.Globalization;
using System.Text;
using DynamicSugar;
using System.Collections.Generic;
 
namespace JSON.SyntaxValidator
{
    /// <summary>
    /// This class encodes and decodes JSON strings.
    /// Spec. details, see http://www.json.org/
    ///
    /// JSON uses Arrays and Objects. These correspond here to the datatypes ArrayList and Hashtable.
    /// All numbers are parsed to doubles.
    /// </summary>
    public class Compiler : Tokenizer
    {
        public const string SYNTAX_ERROR_001 = @"Trailing coma not supported";
        public const string SYNTAX_ERROR_002 = @"Missing ']'";
        public const string SYNTAX_ERROR_003 = @"Missing '}'";
        public const string SYNTAX_ERROR_004 = @"Missing ':'";
        public const string SYNTAX_ERROR_005 = @"Missing ','";
        public const string SYNTAX_ERROR_006 = @"Missing '""'";
        public const string SYNTAX_ERROR_007 = @"String expected instead of ID";
        public const string SYNTAX_ERROR_008 = @"Invalid value:";
        public const string SYNTAX_ERROR_009 = @"Expected ',' or ']'";
        public const string SYNTAX_ERROR_010 = @"Expected ',' or '}'";
        public const string SYNTAX_ERROR_011 = @"Missing '}' or '""' expected";
        public const string SYNTAX_ERROR_012 = @"Missing value ',,' is invalid";
        public const string SYNTAX_ERROR_013 = @"',' unexpected";
        public const string SYNTAX_ERROR_014 = @"'{0}' unexpected";
        public const string SYNTAX_ERROR_015 = @"']' unexpected";
        public const string SYNTAX_ERROR_016 = @"'}' unexpected";
        public const string SYNTAX_ERROR_017 = @"'""' missing";
        public const string SYNTAX_ERROR_018 = @"Expected end of file";
        public const string SYNTAX_ERROR_019 = @"// Comment are not allowed in JSON strict mode";
        public const string SYNTAX_ERROR_020 = @"Invalid JSON date:""{0}""";

        private char[]  _charArray;
        private int     _index;
        private bool    _supportIDWithNoQuote;
        private bool    _supportTrailingComa;
        private bool    _supportStartComment;
        private bool    _supportSlashComment;

        private const int BUILDER_CAPACITY = 2000;

        /// <summary>
        /// Parses the string json into a value
        /// </summary>
        /// <param name="json">A JSON string.</param>
        /// <returns>An ArrayList, a Hashtable, a double, a string, null, true, or false</returns>
        public object Validate(string json, bool supportStartComment = false, bool relaxMode = false, CommentInfos commentInfos = null)
        {
            bool success              = true;
            this._supportStartComment = supportStartComment;

            if (commentInfos == null) // Optimization for the TextHighlighter extension
            {                         // So we do not have parse the comment twice if possible
                commentInfos = new CommentParser().Parse(json);
            }

            _supportIDWithNoQuote = (relaxMode) || (commentInfos.IsRelax);
            _supportTrailingComa  = _supportIDWithNoQuote;
            _supportSlashComment  = _supportIDWithNoQuote;

            return Compile(json, ref success);
        }

        /// <summary>
        /// Parses the string json into a value; and fills 'success' with the successfullness of the parse.
        /// </summary>
        /// <param name="json">A JSON string.</param>
        /// <param name="success">Successful parse?</param>
        /// <returns>An ArrayList, a Hashtable, a double, a string, null, true, or false</returns>
        public object Compile(string json, ref bool success)
        {
            success = true;
            if (json != null)
            {
                this._charArray   = json.ToCharArray();
                this._index       = 0;
                object value      = ParseValue(ref success);
                var tokenAHead    = LookAhead(this._charArray, this._index, this._supportStartComment, this._supportSlashComment);
                if (tokenAHead != TOKENS.NONE)
                {
                    this.ThrowError(SYNTAX_ERROR_014.format(TOKEN_STRING[tokenAHead]), this._index);
                }

                // Make sure there is nothing at the end of the file once we parsed
                // the object or array
                EatWhitespace(this._charArray, ref this._index, this._supportStartComment, this._supportSlashComment);
                if(this._index < this._charArray.Length)
                {
                    this.ThrowError(SYNTAX_ERROR_018, this._index);
                }
                return value;
            }
            else
            {
                return null;
            }
        }

        private  int GetLine(int index)
        {
            return Tokenizer.GetLine(this._charArray, index);
        }

        private int GetColumn(int index)
        {
            return Tokenizer.GetColumn(this._charArray, index);         
        }

        private void ThrowError(string message, int index)
        {
            var ex = new ParserException(message, GetLine(index), GetColumn(index), index);
            throw ex;
        }

        private Hashtable ParseObject(ref bool success)
        {
            var table                      = new Hashtable();
            var done                       = false;
            TOKENS token;

            // {
            NextToken(_charArray, ref _index, this._supportStartComment, this._supportSlashComment);

            var tokenAHead = LookAhead(_charArray, _index, this._supportStartComment , this._supportSlashComment);
            // Check for [{]
            // Check for {,
            if (tokenAHead.In(TOKENS.SQUARED_CLOSE, TOKENS.COMA, TOKENS.COLON))
            {
                NextToken(_charArray, ref _index, this._supportStartComment , this._supportSlashComment);
                this.ThrowError(SYNTAX_ERROR_014.format(TOKEN_STRING[tokenAHead]),  _index);
            }

            while (!done)
            {
                token = LookAhead(_charArray, _index, this._supportStartComment , this._supportSlashComment);
                 
                if (token == TOKENS.NONE)
                {
                    this.ThrowError(SYNTAX_ERROR_011, this._index);
                }
                else if (token == TOKENS.COMA)
                {
                    NextToken(_charArray, ref _index, this._supportStartComment, this._supportSlashComment);
                    if (LookAhead(_charArray, _index, this._supportStartComment, this._supportSlashComment).In(TOKENS.CURLY_CLOSE))
                    {
                        if (!this._supportTrailingComa)
                            this.ThrowError(SYNTAX_ERROR_001, this._index);
                    }
                }
                else if (token == TOKENS.CURLY_CLOSE)
                {
                    NextToken(_charArray, ref _index, this._supportStartComment, this._supportSlashComment);
                    return table;
                }
                else
                {
                    // name with or without id
                    string name = "";

                    if (token == TOKENS.ID && this._supportIDWithNoQuote)
                    {
                        name = ParseID(this._charArray, ref _index, ref success, this._supportStartComment, this._supportSlashComment).ToString();
                    }
                    else if (token == TOKENS.STRING)
                    {
                        var s = ParseString(ref _index, ref success);
                        if (s == null)
                        {                
                            this.ThrowError(SYNTAX_ERROR_017, this._index);
                        }
                        else
                        {
                            name = s.ToString();
                        }
                    }
                    else
                    {
                        success = false;
                    }

                    if (!success)
                    {
                        var tmpTok = NextToken(_charArray, ref _index, this._supportStartComment , this._supportSlashComment);
                        this.ThrowError(SYNTAX_ERROR_007, this._index);
                    }

                    // :
                    token = NextToken(_charArray, ref _index, this._supportStartComment , this._supportSlashComment);
                    if (token != TOKENS.COLON)
                    {
                        this.ThrowError(SYNTAX_ERROR_004, this._index);
                    }

                    // value
                    object value = ParseValue(ref success);
                    if (!success)
                    {
                        this.ThrowError(SYNTAX_ERROR_008, this._index);
                    }

                    
                    var next2Tokens = GetNext2TokensAHead();
                    if (next2Tokens.Count >= 1 && (!next2Tokens[0].In(TOKENS.COMA, TOKENS.CURLY_CLOSE)))
                    {
                        this.ThrowError(SYNTAX_ERROR_010, this._index);
                    } // Check for ,, after an value
                    else if (next2Tokens.Count == 2 && next2Tokens[0] == TOKENS.COMA && next2Tokens[1] == TOKENS.COMA)
                    {
                        this.ThrowError(SYNTAX_ERROR_012, this._index);
                    }
                    else if (next2Tokens.Count == 2 && next2Tokens[0] == TOKENS.COMA && next2Tokens[1] == TOKENS.SQUARED_CLOSE)
                    {
                        if (!this._supportTrailingComa)
                            this.ThrowError(SYNTAX_ERROR_001, this._index);
                    }
                    else if (next2Tokens.Count == 2 && next2Tokens[0] == TOKENS.NONE && next2Tokens[1] == TOKENS.NONE)
                    {   // If we are missing a } but are at the eof
                        this.ThrowError(SYNTAX_ERROR_003, this._index);
                    }

                    table[name] = value;
                }
            }
            return table;
        }

        private List<TOKENS> GetNext2TokensAHead()
        {
            var l = new List<TOKENS>();
            int index2 = _index;
            l.Add(NextToken(this._charArray, ref _index, this._supportStartComment , this._supportSlashComment));
            l.Add(NextToken(_charArray, ref _index, this._supportStartComment , this._supportSlashComment));
            _index = index2;
            return l;
        }

        private ArrayList ParseArray(ref bool success)
        {
            var array = new ArrayList();
           
            // [
            NextToken(_charArray, ref _index, this._supportStartComment, this._supportSlashComment);

            bool done = false;

            var tokenAHead = LookAhead(_charArray, _index, this._supportStartComment, this._supportSlashComment);

            // Check for [,
            // Check for [}
            if (tokenAHead.In(TOKENS.COMA, TOKENS.CURLY_CLOSE))
            {
                NextToken(_charArray, ref _index, this._supportStartComment, this._supportSlashComment);
                this.ThrowError(SYNTAX_ERROR_014.format(TOKEN_STRING[tokenAHead]), this._index);
            }

            while (!done)
            {
                var token = LookAhead(_charArray, _index, this._supportStartComment, this._supportSlashComment);
  

                if (token == TOKENS.NONE)
                {
                    this.ThrowError(SYNTAX_ERROR_002, this._index);
                }
                else if (token == TOKENS.COMA)
                {
                    NextToken(_charArray, ref _index, this._supportStartComment , this._supportSlashComment);
                    if (LookAhead(_charArray, _index, this._supportStartComment , this._supportSlashComment).In(TOKENS.CURLY_CLOSE))
                    {
                        if (!this._supportTrailingComa)
                            this.ThrowError(SYNTAX_ERROR_001, this._index);
                    }
                }
                else if (token == TOKENS.SQUARED_CLOSE)
                {
                    NextToken(_charArray, ref _index, this._supportStartComment , this._supportSlashComment);
                    break;
                }
                else
                {
                    object value = ParseValue(ref success);
                    if (!success)
                    {
                        this.ThrowError(SYNTAX_ERROR_008, this._index);
                    }
                    array.Add(value);

                    var nextToken = LookAhead(_charArray, _index, this._supportStartComment, this._supportSlashComment);
                    if (nextToken != TOKENS.SQUARED_CLOSE && nextToken != TOKENS.COMA)
                    {
                        this.ThrowError(SYNTAX_ERROR_009, this._index);
                    }

                    // Check for ,, after an value
                    var next2Tokens = GetNext2TokensAHead();
                    if (next2Tokens.Count == 2 && next2Tokens[0] == TOKENS.COMA && next2Tokens[1] == TOKENS.COMA)
                    {
                        this.ThrowError(SYNTAX_ERROR_012, this._index);
                    }
                    if (next2Tokens.Count == 2 && next2Tokens[0] == TOKENS.COMA && next2Tokens[1] == TOKENS.SQUARED_CLOSE)
                    {
                        if (!this._supportTrailingComa)
                            this.ThrowError(SYNTAX_ERROR_001, this._index);
                    }
                }
            }
            return array;
        }

        private object ParseValue(ref bool success)
        {
            var token = LookAhead(_charArray, _index, this._supportStartComment, this._supportSlashComment);
            switch (token)
            {
                case TOKENS.STRING:
                    return ParseString(ref _index, ref success);
                case TOKENS.NUMBER:
                    return ParseNumber(this._charArray, ref _index, ref success, this._supportStartComment, this._supportSlashComment);
                case TOKENS.CURLY_OPEN:
                    return ParseObject(ref success);
                case TOKENS.SQUARED_OPEN:
                    return ParseArray(ref success);
                case TOKENS.TRUE:
                    NextToken(this._charArray, ref _index, this._supportStartComment , this._supportSlashComment);
                    return true;
                case TOKENS.FALSE:
                    NextToken(this._charArray, ref _index, this._supportStartComment , this._supportSlashComment);
                    return false;
                case TOKENS.NULL:
                    NextToken(this._charArray, ref _index, this._supportStartComment , this._supportSlashComment);
                    return null;
                case TOKENS.NONE:
                    break;
            }
            this.ThrowError(SYNTAX_ERROR_014.format(TOKEN_STRING[token]), this._index);
            return null; // will never be executed
        }

        private object ParseString(ref int index, ref bool success)
        {
            var indexSaved = index;
            StringBuilder s = new StringBuilder(BUILDER_CAPACITY);
            char c;

            EatWhitespace(_charArray, ref index, this._supportStartComment, this._supportSlashComment);

            c = _charArray[index++];

            bool complete = false;
            while (!complete)
            {
                if (index == _charArray.Length)
                {
                    break;
                }

                c = _charArray[index++];
                if (c == '"')
                {
                    complete = true;
                    break;
                }
                else if (c == '\\')
                {
                    if (index == _charArray.Length)
                    {
                        break;
                    }
                    c = _charArray[index++];
                    if (c == '"')
                    {
                        s.Append('"');
                    }
                    else if (c == '\\')
                    {
                        s.Append('\\');
                    }
                    else if (c == '/')
                    {
                        s.Append('/');
                    }
                    else if (c == 'b')
                    {
                        s.Append('\b');
                    }
                    else if (c == 'f')
                    {
                        s.Append('\f');
                    }
                    else if (c == 'n')
                    {
                        s.Append('\n');
                    }
                    else if (c == 'r')
                    {
                        s.Append('\r');
                    }
                    else if (c == 't')
                    {
                        s.Append('\t');
                    }
                    else if (c == 'u')
                    {
                        int remainingLength = _charArray.Length - index;
                        if (remainingLength >= 4)
                        {
                            // parse the 32 bit hex into an integer codepoint
                            uint codePoint;
                            if (!(success = UInt32.TryParse(new string(_charArray, index, 4), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out codePoint)))
                            {
                                return "";
                            }
                            // convert the integer codepoint to a unicode char and add to string
                            s.Append(Char.ConvertFromUtf32((int)codePoint));
                            // skip 4 chars
                            index += 4;
                        }
                        else
                        {
                            break;
                        }
                    }

                }
                else
                {
                    s.Append(c);
                }
            }

            if (!complete)
            {
                index   = indexSaved; // Restore the position where we started parsing the string, this give a better error message
                success = false;
                return null;
            }

            var val = s.ToString();
            if (IsJsonDate(val)) {
                try {
                    return ParseJsonDateTime(val);
                }
                catch(System.ArgumentException aex) {                   
                   this.ThrowError(SYNTAX_ERROR_020.format(val), this._index);
                    return null;
                }
            }
            else
                return val;
        }
    }
}

