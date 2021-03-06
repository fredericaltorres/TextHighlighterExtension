using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace TextHighlighterExtension
{

    public class LinePosition
    {
        public int      Line;
        public int      Position;
        public string   TextLine;
        public char     Char;

        public static LinePosition GetGrandParentBaseOnTab(List<string> source, int lineIndex) { 

            LinePosition parent = GetParentBaseOnTab(source, lineIndex);
            return GetParentBaseOnTab(source, parent.Line);
        }

        public static string GetTabPrefix(string s) {

            string PreFix = "";
            int i = 0;
            while (true)
            {
                if ((s[i] == ' ') || (s[i] == '\t'))
                {
                    PreFix += s[i];
                    i++;
                }
                else break;
            }
            return PreFix;
        }

        public static LinePosition GetParentBaseOnTab(List<string> source, int lineIndex)
        {
            string s = source[lineIndex];

            if(String.IsNullOrEmpty(s)) return null;
            string PreFix = GetTabPrefix(s);
            if (String.IsNullOrEmpty(PreFix)) return null;
                        
            int i = lineIndex;
            while (i >= 0) {
                if (source[i].StartsWith(PreFix))
                    i--;
                else
                {
                    LinePosition r = new LinePosition();        
                    r.Line = i;
                    r.TextLine = source[i];
                    r.Position = 0;                    
                    return r;
                }
            }            
            return null;
        }
        public LinePosition() { 

        }
        public LinePosition(List<string> source, int globalPosition)
        {
            int CurrentPosition = 0;

            for (int i = 0; i < source.Count; i++)
            {

                if (CurrentPosition + source[i].Length >= globalPosition)
                {

                    this.Line       = i;
                    this.Position   = globalPosition - CurrentPosition;
                    this.TextLine   = source[i].Substring(0, this.Position);
                    this.Char       = this.TextLine[this.TextLine.Length-1];
                    return;
                }
                else { 
                    CurrentPosition += source[i].Length;
                }
            }
        }
    }
}
