using System;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DynamicSugar;
using Newtonsoft.Json.Linq;
using CTxt;

namespace CTxtUnitTests2012
{
    [TestClass]
    public class CTxtUnitTest
    {        
        [TestMethod]
        public void GetColorUsed()
        {
            var ctxtDef     = LoadDefinition();
            var colorsUsed  = ctxtDef.GetColorUsed();

            Assert.AreEqual(8, colorsUsed.Count);
            Assert.IsTrue(colorsUsed.Contains("SaddleBrown"));
            Assert.IsTrue(colorsUsed.Contains("DarkRed"));
            Assert.IsTrue(colorsUsed.Contains("DarkGreen"));
            Assert.IsTrue(colorsUsed.Contains("DarkBlue"));
            Assert.IsTrue(colorsUsed.Contains("bold.Chocolate"));
            Assert.IsTrue(colorsUsed.Contains("bold.Crimson"));
            Assert.IsTrue(colorsUsed.Contains("bold.Chartreuse"));
            Assert.IsTrue(colorsUsed.Contains("bold.Blue"));
            Assert.IsTrue(!colorsUsed.Contains("Blue"));
        }

        [TestMethod]
        public void LoadDefinitions()
        {
            var ctxtDef = LoadDefinition();

            Assert.AreEqual(8, ctxtDef.Count);

            foreach(var d in ctxtDef)
                Assert.IsTrue(d.Expression.Contains("Space") && d.Expression.Contains("After"));

            Assert.AreEqual("SaddleBrown",      ctxtDef[0].BeforeColor);
            Assert.AreEqual("DarkRed",          ctxtDef[1].BeforeColor);
            Assert.AreEqual("DarkGreen",        ctxtDef[2].BeforeColor);
            Assert.AreEqual("DarkBlue",         ctxtDef[3].BeforeColor);

            Assert.AreEqual("bold.Chocolate",   ctxtDef[0].AfterColor);
            Assert.AreEqual("bold.Crimson",     ctxtDef[1].AfterColor);
            Assert.AreEqual("bold.Chartreuse",  ctxtDef[2].AfterColor);
            Assert.AreEqual("bold.Blue",        ctxtDef[3].AfterColor);
        }

        [TestMethod]
        public void EvalHeaderStringIndentationWithSpaces()
        {
            var ctxtDef = LoadDefinition();  

            var r = ctxtDef.Eval("            aa:bb");
            Valid_aabb_String(r, "            ", 1);

            r = ctxtDef.Eval("        aa:bb");
            Valid_aabb_String(r, "        ", 2);

            r = ctxtDef.Eval("    aa:bb");
            Valid_aabb_String(r, "    ", 3);

            r = ctxtDef.Eval("aa:bb");
            Valid_aabb_String(r, "", 4);
        }

        [TestMethod]
        public void EvalHeaderStringIndentationWithTabs()
        {
            var ctxtDef = LoadDefinition();  

            var r = ctxtDef.Eval("\t\t\taa:bb");
            Valid_aabb_String(r, "\t\t\t", 1);

            r = ctxtDef.Eval("\t\taa:bb");
            Valid_aabb_String(r, "\t\t", 2);

            r = ctxtDef.Eval("\taa:bb");
            Valid_aabb_String(r, "\t", 3);

            r = ctxtDef.Eval("aa:bb");
            Valid_aabb_String(r, "", 4);
        }

        private void Valid_aabb_String(CTxtEntryEvalResult r, string space, int index)
        {
            Assert.AreEqual(":", r.OperatorText);
            Assert.AreEqual("aa", r.BeforeText);
            Assert.AreEqual("bb", r.AfterText);
            Assert.AreEqual(space, r.SpaceText);
            Assert.AreEqual(index, r.Entry.Index);
            Assert.AreEqual(CTxtEntryType.HEADER, r.Entry.Type);

            if(space ==  "\t\t\t") 
            {
                Assert.AreEqual(3, r.BeforePosition);
                Assert.AreEqual(2, r.BeforeLen);
                Assert.AreEqual(5, r.OperatorPosition);
                Assert.AreEqual(1, r.OperatorLen);
                Assert.AreEqual(6, r.AfterPosition);
                Assert.AreEqual(2, r.AfterLen);
            }
            else if(space ==  "\t\t") 
            {
                Assert.AreEqual(2, r.BeforePosition);
                Assert.AreEqual(2, r.BeforeLen);
                Assert.AreEqual(4, r.OperatorPosition);
                Assert.AreEqual(1, r.OperatorLen);
                Assert.AreEqual(5, r.AfterPosition);
                Assert.AreEqual(2, r.AfterLen);
            }                       
            else if(space ==  "\t")
            {
                Assert.AreEqual(1, r.BeforePosition);
                Assert.AreEqual(2, r.BeforeLen);
                Assert.AreEqual(3, r.OperatorPosition);
                Assert.AreEqual(1, r.OperatorLen);
                Assert.AreEqual(4, r.AfterPosition);
                Assert.AreEqual(2, r.AfterLen);
            }
            else if(space ==  "            ") 
            {
                Assert.AreEqual(12, r.BeforePosition);
                Assert.AreEqual(2, r.BeforeLen);
                Assert.AreEqual(14, r.OperatorPosition);
                Assert.AreEqual(1, r.OperatorLen);
                Assert.AreEqual(15, r.AfterPosition);
                Assert.AreEqual(2, r.AfterLen);
            }
            else if(space ==  "        ") 
            {
                Assert.AreEqual(8, r.BeforePosition);
                Assert.AreEqual(2, r.BeforeLen);
                Assert.AreEqual(10, r.OperatorPosition);
                Assert.AreEqual(1, r.OperatorLen);
                Assert.AreEqual(11, r.AfterPosition);
                Assert.AreEqual(2, r.AfterLen);
            }
            else if(space ==  "    ") 
            {
                Assert.AreEqual(4, r.BeforePosition);
                Assert.AreEqual(2, r.BeforeLen);
                Assert.AreEqual(6, r.OperatorPosition);
                Assert.AreEqual(1, r.OperatorLen);
                Assert.AreEqual(7, r.AfterPosition);
                Assert.AreEqual(2, r.AfterLen);
            }
            else if(space ==  "") 
            {
                Assert.AreEqual(0, r.BeforePosition);
                Assert.AreEqual(2, r.BeforeLen);
                Assert.AreEqual(2, r.OperatorPosition);
                Assert.AreEqual(1, r.OperatorLen);
                Assert.AreEqual(3, r.AfterPosition);
                Assert.AreEqual(2, r.AfterLen);
            }
        }

        [TestMethod]
        public void EvalBasicStringIndentationWithSpaces()
        {
            var ctxtDef = LoadDefinition();  

            var r = ctxtDef.Eval("            aa");
            Valid_aa_String(r, "            ", 5);
            
            r = ctxtDef.Eval("        aa");
            Valid_aa_String(r, "        ", 6);

            r = ctxtDef.Eval("    aa");
            Valid_aa_String(r, "    ", 7);

            r = ctxtDef.Eval("aa");
            Valid_aa_String(r, "", 8);

        }

        private void Valid_aa_String(CTxtEntryEvalResult r, string space, int index)
        {
            Assert.AreEqual(CTxtEntryType.LINE, r.Entry.Type);
            Assert.AreEqual(null, r.OperatorText);
            Assert.AreEqual(null, r.BeforeText);
            Assert.AreEqual("aa", r.AfterText);
            Assert.AreEqual(space, r.SpaceText);
            Assert.AreEqual(index, r.Entry.Index);
            
            if(space ==  "            ") 
            {               
                Assert.AreEqual(12, r.AfterPosition);
                Assert.AreEqual(2, r.AfterLen);
            }
            else if(space ==  "        ") 
            {                
                Assert.AreEqual(8, r.AfterPosition);
                Assert.AreEqual(2, r.AfterLen);
            }
            else if(space ==  "    ") 
            {                
                Assert.AreEqual(4, r.AfterPosition);
                Assert.AreEqual(2, r.AfterLen);
            }
            else if(space ==  "") 
            {              
                Assert.AreEqual(0, r.AfterPosition);
                Assert.AreEqual(2, r.AfterLen);
            }
        }

        private CTxt.CTxtDefinition LoadDefinition()
        {
            var json        = DS.Resources.GetTextResource("Def01.json", Assembly.GetExecutingAssembly());
            var jsonConfig  = JObject.Parse(json);

            return new CTxt.CTxtDefinition(jsonConfig["CTXT"] as JObject);
        }
    }
}
