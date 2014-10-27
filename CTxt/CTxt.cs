using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace CTxt
{
    public class CTxtEntryEvalResult
    {
        public string Line;
        public string SpaceText, OperatorText, BeforeText, AfterText;
        public int  SpacePosition, OperatorPosition, BeforePosition, AfterPosition;
        public int  SpaceLen, OperatorLen, BeforeLen, AfterLen;
        public CTxtEntry Entry;        
        public bool Passed;
    }
    public enum CTxtEntryType 
    {
        HEADER,
        LINE
    }
    public class CTxtEntry
    {
        public string Expression, BeforeColor, AfterColor;
        public int Index;
        private Regex _rx;
        private string _rxString;
        public CTxtEntryType Type;

        public CTxtEntryEvalResult Eval(string line)
        {
            if (_rx == null)
                this._rx = new Regex(this.Expression, RegexOptions.Compiled);

            var match   = this._rx.Match(line);
            var r       = new CTxtEntryEvalResult();
            r.Line      = line;
            if (match.Groups.Count == 5)
            {
                r.SpaceText         = match.Groups["Space"].Value;
                r.SpaceLen          = match.Groups["Space"].Length;
                r.SpacePosition     = match.Groups["Space"].Index;

                r.BeforeText         = match.Groups["Before"].Value;
                r.BeforeLen          = match.Groups["Before"].Length;
                r.BeforePosition     = match.Groups["Before"].Index;

                r.AfterText         = match.Groups["After"].Value;
                r.AfterLen          = match.Groups["After"].Length;
                r.AfterPosition     = match.Groups["After"].Index;

                r.OperatorText        = match.Groups["Operator"].Value;
                r.OperatorLen         = match.Groups["Operator"].Length;
                r.OperatorPosition    = match.Groups["Operator"].Index;

                r.Entry         = this;
                r.Passed        = true;

                if((r.BeforeText.EndsWith("http")||r.BeforeText.EndsWith("https")) && r.OperatorText.StartsWith(":")) 
                {
                    r.Passed = false;
                }
            }
            if (match.Groups.Count == 3)
            {
                r.SpaceText         = match.Groups["Space"].Value;
                r.SpaceLen          = match.Groups["Space"].Length;
                r.SpacePosition     = match.Groups["Space"].Index;

                r.AfterText         = match.Groups["After"].Value;
                r.AfterLen          = match.Groups["After"].Length;
                r.AfterPosition     = match.Groups["After"].Index;
 
                r.Entry         = this;
                r.Passed        = true;
            }
            return r;
        }
    }

    public class CTxtDefinition : List<CTxtEntry>
    {
        public List<string> GetColorUsed()
        {
            var l = new List<string>();
            foreach(var e in this) 
            {
                if((!l.Contains(e.AfterColor))&&(e.AfterColor!=null)) l.Add(e.AfterColor);
                if((!l.Contains(e.BeforeColor))&&(e.BeforeColor!=null)) l.Add(e.BeforeColor);
            }
            return l;
        }
        public CTxtEntryEvalResult Eval(string line)
        {
            foreach(var e in this)
            {
                var r = e.Eval(line);
                if(r.Passed)
                    return r;
            }
            return null;
        }
        
        public CTxtDefinition(JObject config)
        {
            var levels = config["Levels"] as JArray;
            for (var i = 0; i < levels.Count; i++)
            {
                var jsonCTxtDef = levels[i] as JObject;
                if (jsonCTxtDef != null) // Ignore comment
                {
                    var e           = new CTxtEntry();
                    e.Expression    = jsonCTxtDef["Expression"] == null ? ":" : jsonCTxtDef["Expression"].ToString();
                    e.BeforeColor   = jsonCTxtDef["BeforeColor"] == null ? null : jsonCTxtDef["BeforeColor"].ToString();
                    e.AfterColor    = jsonCTxtDef["AfterColor"] == null ? null : jsonCTxtDef["AfterColor"].ToString();
                    e.Type          = e.BeforeColor == null ? CTxtEntryType.LINE : CTxtEntryType.HEADER;
                    this.Add(e);
                    e.Index = this.Count;
                }
            }
        }
    }
}
