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
using System.Text.RegularExpressions;

namespace JSON.SyntaxValidator
{
    public class Tokenizer
    {
        protected static Dictionary<TOKENS, string> TOKEN_STRING = new Dictionary<TOKENS, string>() { 

          { TOKENS.NONE         , ""     },
          { TOKENS.CURLY_OPEN   , "{"    },
          { TOKENS.CURLY_CLOSE  , "}"    },
          { TOKENS.SQUARED_OPEN , "["    },
          { TOKENS.SQUARED_CLOSE, "]"    },
          { TOKENS.COLON        , ":"    },
          { TOKENS.COMA         , ","    },
          { TOKENS.STRING       , ""     },
          { TOKENS.NUMBER       , ""     },
          { TOKENS.TRUE         , "true" },
          { TOKENS.FALSE        , "false"},
          { TOKENS.NULL         , "null" },
          { TOKENS.ID           , "Id"   },
        };

        private static Regex _JsonDateRegEx_UTCTimeNoMilliSecond                 = new Regex(@"^\d\d\d\d-\d\d-\d\dT\d\d:\d\d:\d\dZ", System.Text.RegularExpressions.RegexOptions.Compiled);
        private static Regex _JsonDateRegEx_UTCTimeWithMilliSecond               = new Regex(@"^\d\d\d\d-\d\d-\d\dT\d\d:\d\d:\d\d\.\d{1,3}Z", System.Text.RegularExpressions.RegexOptions.Compiled);
        private static Regex _JsonDateRegEx_LocalTimeNoMilliSecondNoTimeZone     = new Regex(@"^\d\d\d\d-\d\d-\d\dT\d\d:\d\d:\d\d$", System.Text.RegularExpressions.RegexOptions.Compiled);
        private static Regex _JsonDateRegEx_LocalTimeWithMilliSecondNoTimeZone   = new Regex(@"^\d\d\d\d-\d\d-\d\dT\d\d:\d\d:\d\d.\d{1,3}$", System.Text.RegularExpressions.RegexOptions.Compiled);
        private static Regex _JsonDateRegEx_LocalTimeWithMilliSecondWithTimeZone = new Regex(@"^\d\d\d\d-\d\d-\d\dT\d\d:\d\d:\d\d.\d{1,3}-\d\d:\d\d$", System.Text.RegularExpressions.RegexOptions.Compiled);

        public static bool IsJsonDate(string v)
        {
            if (v.StartsWith("\""))
                v = v.Substring(1);
            if (v.EndsWith("\""))
                v = v.Substring(0, v.Length - 1);
            if(_JsonDateRegEx_UTCTimeNoMilliSecond.IsMatch(v)) 
                return true;
            if(_JsonDateRegEx_UTCTimeWithMilliSecond.IsMatch(v))
                return true;
            if(_JsonDateRegEx_LocalTimeNoMilliSecondNoTimeZone.IsMatch(v))
                return true;
            if(_JsonDateRegEx_LocalTimeWithMilliSecondNoTimeZone.IsMatch(v))
                return true;
            if(_JsonDateRegEx_LocalTimeWithMilliSecondWithTimeZone.IsMatch(v))
                return true;
            return false;
        }

        protected static int ValidateIntOrThrowError(string v, string errorMessage)
        {
            int i;
            if (int.TryParse(v, out i))
                return i;
            throw new ArgumentException(String.Format(errorMessage, v));
        }
        /// <summary>
        /// http://en.wikipedia.org/wiki/ISO_8601
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        protected static DateTime ParseJsonDateTime(string s)
        {
            // Torres Frederic
            // Added Support for  new Date("2012-09-17T22:33:03Z");
            // Z mean UTC date according NODEJS
            if (s.Contains("T") && s.EndsWith("Z"))
            {
                var parts       = s.Split('T');
                var dateParts   = parts[0].Split('-');
                var timeParts   = parts[1].Replace("Z", "").Split(':');
                var year        = ValidateIntOrThrowError(dateParts[0], "Invalid Date (year):" + s);
                var mon         = ValidateIntOrThrowError(dateParts[1], "Invalid Date (month):" + s);
                var mday        = ValidateIntOrThrowError(dateParts[2], "Invalid Date (day):" + s);
                var hour        = ValidateIntOrThrowError(timeParts[0], "Invalid Date (hour)" + s);
                var min         = ValidateIntOrThrowError(timeParts[1], "Invalid Date (minute)" + s);
                int milli       = 0;
                int sec         = 0;
                if (timeParts[2].Contains("."))
                {
                    var SecMillParts = timeParts[2].Split('.');
                    sec              = ValidateIntOrThrowError(SecMillParts[0], "Invalid Date (second)" + s);
                    milli            = ValidateIntOrThrowError(SecMillParts[1], "Invalid Date (milli-second)" + s);
                }
                else
                {
                    sec = ValidateIntOrThrowError(timeParts[2], "Invalid Date (second)" + s);
                }
                DateTime d = new DateTime(year, mon, mday, hour, min, sec, milli, DateTimeKind.Utc);
                return d;
            }
            else if (s.Contains("T") && (!s.EndsWith("Z")))
            {
                // It is local time with possible a timezone defintion
                // "2013-04-20T11:59:48.5820883-04:00"
                var parts           = s.Split('T');
                var dateParts       = parts[0].Split('-');
                var timeParts       = parts[1].Replace("Z", "").Split(':');
                var year            = ValidateIntOrThrowError(dateParts[0], "Invalid Date (year):" + s);
                var mon             = ValidateIntOrThrowError(dateParts[1], "Invalid Date (month):" + s);
                var mday            = ValidateIntOrThrowError(dateParts[2], "Invalid Date (day):" + s);
                var hour            = ValidateIntOrThrowError(timeParts[0], "Invalid Date (hour)" + s);
                var min             = ValidateIntOrThrowError(timeParts[1], "Invalid Date (minute)" + s);
                
                // Analyse Second.millisecond-TimeZone
                var secondsString   = timeParts[2];
                int milli           = 0;
                int sec             = 0;
                int timeZoneHours   = 0;
                int timeZoneMinutes = 0;

                if (secondsString.Contains("."))
                {
                    var secMillParts = secondsString.Split('.');
                    sec              = ValidateIntOrThrowError(secMillParts[0], "Invalid Date (second)" + s);
                    var milliSeconds = secMillParts[1];
                    if(milliSeconds.Contains("-")) { // We are having a time zone
                        var milliParts      = milliSeconds.Split('-');
                        milli               = ValidateIntOrThrowError(milliParts[0], "Invalid Date (milli second)" + s);
                        var timeZoneParts   = milliParts[1].Split(':');
                        timeZoneHours       = ValidateIntOrThrowError(timeZoneParts[0], "Invalid Date (milli second)" + s);
                        timeZoneMinutes     = ValidateIntOrThrowError(timeZoneParts[1], "Invalid Date (milli second)" + s);
                    }
                    else {
                        milli = ValidateIntOrThrowError(milliSeconds, "Invalid Date (milli-second)" + s);
                    }
                }
                else
                {
                    sec = ValidateIntOrThrowError(secondsString, "Invalid Date (second)" + s);
                }
                var d = new DateTime(year, mon, mday, hour, min, sec, milli, DateTimeKind.Local);
                return d;
            }
            else
                throw new ArgumentException("Invalid JSON date:{0}".format(s));
        }

        protected static bool IsIdChar(char c)
        {
            return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || (c >= '0' && c <= '9') ||
                   (c == '_') || (c == '$');
        }

        protected static bool IsIdForFirstChar(char c)
        {
            return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') ||
                   (c == '_') || (c == '$');
        }

        protected static string ParseID(char[] json, ref int index, ref bool success, bool supportStarsComment, bool supportSlashComment)
        {
            EatWhitespace(json, ref index, supportStarsComment, supportSlashComment);
            var b = new StringBuilder(100);

            if (!IsIdForFirstChar(json[index]))
            {
                return null;
            }
            while (IsIdChar(json[index]))
            {
                b.Append(json[index]);
                index++;
            }
            if (b.ToString().Length == 0)
                return null;
            return b.ToString();
        }

        protected static double ParseNumber(char[] json, ref int index, ref bool success, bool supportStarsComment , bool supportSlashComment)
        {
            EatWhitespace(json, ref index, supportStarsComment, supportSlashComment);

            int lastIndex = GetLastIndexOfNumber(json, index);
            int charLength = (lastIndex - index) + 1;

            double number;
            success = Double.TryParse(new string(json, index, charLength), NumberStyles.Any, CultureInfo.InvariantCulture, out number);

            index = lastIndex + 1;
            return number;
        }

        protected static int GetLastIndexOfNumber(char[] json, int index)
        {
            int lastIndex;

            for (lastIndex = index; lastIndex < json.Length; lastIndex++)
            {
                if ("0123456789+-.eE".IndexOf(json[lastIndex]) == -1)
                {
                    break;
                }
            }
            return lastIndex - 1;
        }

        protected static void EatWhitespace(char[] json, ref int index, bool supportStarsComment, bool supportSlashComment)
        {
            for (; index < json.Length; index++)
            {
                if (" \t\n\r".IndexOf(json[index]) == -1)
                {
                    if(supportStarsComment)
                        EatComment(json, ref index, supportStarsComment, supportSlashComment);
                    break;
                }
            }
        }

        
        protected static int GetLine(char [] charArray,int index)
        {
            int lineCounter = 0;
            for (int i = 0; i < index; i++)
            {
                if (charArray[i] == '\n')
                    lineCounter++;
            }
            return lineCounter + 1;
        }

        protected static int GetColumn(char [] charArray, int index)
        {
            int i = index;
            if (i >= charArray.Length)
            {
                i = charArray.Length - 1;
            }
            while (i >= 0 && charArray[i] != '\n')
            {
                i--;
            }
            if (i == -1)
            {
                i = 0;
            }
            else
            {
                i++;
            }
            var col = index - i;
            return col;
        }


        private static bool IsCrOrLf(char c)
        {
            return c == '\r' || c == '\n';
        }

        protected static void EatComment(char[] json, ref int index, bool supportStarsComment, bool supportSlashComment)
        { 
            if (index < json.Length - 1)
            {
                if(supportStarsComment) {
                    if (index < json.Length-1 && json[index] == '/' && json[index + 1] == '*')
                    {
                        while (index < json.Length && (!(json[index] == '*' && json[index + 1] == '/')))
                        {
                            index++;
                        }
                        index += 2;
                        EatWhitespace(json, ref index, supportStarsComment, supportSlashComment);
                    }
                }
                if(supportSlashComment) 
                {
                    if (index < json.Length-1 && json[index] == '/' && json[index + 1] == '/')
                    {
                        while (index < json.Length && (!IsCrOrLf(json[index])))
                        {
                            index++;
                        }
                        index += 2;
                        EatWhitespace(json, ref index, supportStarsComment, supportSlashComment);
                    }
                }
                else 
                {
                    if (index < json.Length-1 && json[index] == '/' && json[index + 1] == '/')
                    {
                        throw new JSON.SyntaxValidator.ParserException(JSON.SyntaxValidator.Compiler.SYNTAX_ERROR_019, GetLine(json, index), GetColumn(json, index), index);
                    }
                }
            }
        }

        protected static bool LookAheadForId(char[] json, int index, bool supportStarsComments , bool supportSlashComment)
        {
            int saveIndex = index;
            bool success = false;
            return ParseID(json, ref saveIndex, ref success, supportStarsComments, supportSlashComment) != null;
        }

        protected static TOKENS LookAhead(char[] json, int index, bool supportStarsComment , bool supportSlashComment)
        {
            int saveIndex = index;
            return NextToken(json, ref saveIndex, supportStarsComment, supportSlashComment);
        }

        protected static TOKENS NextToken(char[] json, ref int index, bool supportStarsComment , bool supportSlashComment)
        {
            EatWhitespace(json, ref index, supportStarsComment, supportSlashComment);

            if (index == json.Length)
            {
                return TOKENS.NONE;
            }

            char c = json[index];
            index++;
            switch (c)
            {
                case '{':
                    return TOKENS.CURLY_OPEN;
                case '}':
                    return TOKENS.CURLY_CLOSE;
                case '[':
                    return TOKENS.SQUARED_OPEN;
                case ']':
                    return TOKENS.SQUARED_CLOSE;
                case ',':
                    return TOKENS.COMA;
                case '"':
                    return TOKENS.STRING;
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '-':
                    return TOKENS.NUMBER;
                case ':':
                    return TOKENS.COLON;
            }
            index--;

            int remainingLength = json.Length - index;

            // false
            if (remainingLength >= 5)
            {
                if (json[index] == 'f' && json[index + 1] == 'a' && json[index + 2] == 'l' && json[index + 3] == 's' && json[index + 4] == 'e')
                {
                    index += 5;
                    return TOKENS.FALSE;
                }
            }

            // true
            if (remainingLength >= 4)
            {
                if (json[index] == 't' && json[index + 1] == 'r' && json[index + 2] == 'u' && json[index + 3] == 'e')
                {
                    index += 4;
                    return TOKENS.TRUE;
                }
            }

            // null
            if (remainingLength >= 4)
            {
                if (json[index] == 'n' && json[index + 1] == 'u' && json[index + 2] == 'l' && json[index + 3] == 'l')
                {
                    index += 4;
                    return TOKENS.NULL;
                }
            }
            if (LookAheadForId(json, index, supportStarsComment, supportSlashComment))
            {
                return TOKENS.ID;
            }
            return TOKENS.NONE;
        }
    }
 
}

