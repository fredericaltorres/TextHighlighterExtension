using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DynamicSugar;

namespace Json
{
    public class JsonValidator
    {
        public class JsonErrorInfo
        {
            public int AbsPosition = 0;
            public int LineNumber = 0;
            public int LinePosition = 0;
            public string Message;

            public System.Exception ex = null;

            public bool Valid
            {
                get { return this.ex == null; }
            }
            public override string ToString()
            {
                return "Err AbsPos:{0}[line:{1},Col:{2}]{3}".format(this.AbsPosition, this.LineNumber, this.LinePosition, this.Message);
            }
        }

        public static JsonErrorInfo ValidateJson(string text, JSON.SyntaxValidator.CommentInfos comments, bool relaxMode)
        {
            var r = new JsonErrorInfo();
            try
            {
                var o = new JSON.SyntaxValidator.Compiler().Validate(text, supportStartComment:true, relaxMode:relaxMode, commentInfos:comments);
            }
            catch (JSON.SyntaxValidator.ParserException ex)
            {
                r.ex = ex;
                r.LineNumber = ex.Line;
                r.LinePosition = ex.Col;
                r.Message = ex.Message;
                r.AbsPosition = ex.AbsolutePosition;
                System.Diagnostics.Debug.WriteLine("PARSING_ERR:"+r.ToString());
            }
            catch (System.Exception ex)
            {
                r.ex = ex;
                r.LineNumber = -1;
                r.LinePosition = -1;
                r.Message = ex.Message;
                r.AbsPosition = -1;
                System.Diagnostics.Debug.WriteLine("PARSING_ERR:"+r.ToString());
            }
            return r;
        }
         
    }
}
