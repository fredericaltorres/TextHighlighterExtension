using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JSON.SyntaxValidator;
using System.Collections;
using DynamicSugar;
using System.Reflection;

namespace JsonParserUnitTests
{
    [TestClass]
    public class JsonParserRelaxModeUnitTests
    {        
        [TestMethod]
        public void SlashBackSlash()
        {
            string json = @"{ ""slash1"":""/"",  ""slash2"":""\/"", ""backslash"":""\\""}";
            var r = new JSON.SyntaxValidator.Compiler().Validate(json) as Hashtable;
            Assert.AreEqual("/", r["slash1"]);
            Assert.AreEqual("/", r["slash2"]);
            Assert.AreEqual("\\", r["backslash"]);
        }
        [TestMethod]
        public void StringWithUniCode()
        {
            string json = @"{ ""v1"":""\u0041"", ""v2"":""\\\u0041""}";
            var r = new JSON.SyntaxValidator.Compiler().Validate(json) as Hashtable;
            Assert.AreEqual("A", r["v1"]);
            Assert.AreEqual("\\A", r["v2"]);
        }
        [TestMethod]
        public void ParseJsonWithStarComment()
        {
            string json = @"/* A Coment */{ /* A Coment */""T""/* A Coment */:/* A Coment */true/* A Coment */, ""F"":false }";
            var r = new JSON.SyntaxValidator.Compiler().Validate(json, supportStartComment:true, relaxMode:true) as Hashtable;
            Assert.AreEqual(true, r["T"]);
            Assert.AreEqual(false, r["F"]);
        }
        [TestMethod]
        public void ParseJsonWithSlashSlahComment()
        {
            string json = @"
// A Coment
{ // A Coment 
""T"" // A Coment
: // A Coment 
true // A Coment 
, ""F"":false }";

            var r = new JSON.SyntaxValidator.Compiler().Validate(json, supportStartComment:true, relaxMode:true) as Hashtable;
            Assert.AreEqual(true, r["T"]);
            Assert.AreEqual(false, r["F"]);
        }
        [TestMethod]
        public void ParseJsonWithSlashSlahComment_InvalidComment()
        {
            string json = @"
{
// A Coment ""T"" 
: true , ""F"":false }";
            
            JsonParserStrictUnitTests.HandleException(json, JSON.SyntaxValidator.Compiler.SYNTAX_ERROR_014.format(":"), 4, 1, true, true);   
        }

        [TestMethod]
        public void ParseJsonWithNoQuoteForId()
        {
            string json = @"/* ""use relax"" */{ T:true, ""F"":false }";
            var r = new JSON.SyntaxValidator.Compiler().Validate(json, supportStartComment:true) as Hashtable;
            Assert.AreEqual(true, r["T"]);
            Assert.AreEqual(false, r["F"]);
        }
        [TestMethod]
        public void ParseSimpleJsonFile()
        {
            string json = DS.Resources.GetTextResource("MeNoQuote.json", Assembly.GetExecutingAssembly());

            var o = (Hashtable)new JSON.SyntaxValidator.Compiler().Validate(json, supportStartComment:true);

            Assert.AreEqual("Torres", o["LastName"]);
            Assert.AreEqual("Frederic", o["FirstName"]);
            Assert.AreEqual(new DateTime(1964, 12, 11), o["BirthDate"]);
            Assert.AreEqual(48.0, o["Age"]);
            Assert.AreEqual(true, o["Male"]);
            Assert.AreEqual(null, o["Other"]);
            Assert.AreEqual("Torres", o["$_LastName"]);
            Assert.AreEqual("Frederic", o["$_FirstName"]);
            Assert.AreEqual(new DateTime(1964, 12, 11), o["$_BirthDate"]);
            Assert.AreEqual(48.0, o["$_Age"]);
            Assert.AreEqual(true, o["$_Male"]);
            Assert.AreEqual(null, o["$_Other"]);
        }         
    }
}
