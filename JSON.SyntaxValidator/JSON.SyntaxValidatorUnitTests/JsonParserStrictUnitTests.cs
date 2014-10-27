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
    public class JsonParserStrictUnitTests
    {
        const string ERR_MSG_001 = "Expected ParserException not caught";
        [TestMethod]
        public void IsJsonDate()
        {
            // UTC Date
            Assert.IsTrue(JSON.SyntaxValidator.Tokenizer.IsJsonDate("1964-12-11T00:00:00Z"));
            Assert.IsTrue(JSON.SyntaxValidator.Tokenizer.IsJsonDate("1964-12-11T00:00:00.1Z"));
            Assert.IsTrue(JSON.SyntaxValidator.Tokenizer.IsJsonDate("1964-12-11T00:00:00.12Z"));
            Assert.IsTrue(JSON.SyntaxValidator.Tokenizer.IsJsonDate("1964-12-11T00:00:00.123Z"));

            // Local Date
            Assert.IsTrue(JSON.SyntaxValidator.Tokenizer.IsJsonDate("1964-12-11T00:00:00"));
            Assert.IsTrue(JSON.SyntaxValidator.Tokenizer.IsJsonDate("1964-12-11T00:00:00.123"));
            Assert.IsTrue(JSON.SyntaxValidator.Tokenizer.IsJsonDate("1964-12-11T00:00:00.123-04:00"));
            
            Assert.IsFalse(JSON.SyntaxValidator.Tokenizer.IsJsonDate("1964-12-11 00:00:00.11Z"));
            Assert.IsFalse(JSON.SyntaxValidator.Tokenizer.IsJsonDate("964-12-11T00:00:00.11Z"));
            Assert.IsFalse(JSON.SyntaxValidator.Tokenizer.IsJsonDate("1964-12-11T00-00:00.123Z"));

            Assert.IsFalse(JSON.SyntaxValidator.Tokenizer.IsJsonDate("1964-12-11T00:00:00.123-04"));
            Assert.IsFalse(JSON.SyntaxValidator.Tokenizer.IsJsonDate("1964-12-11T00:00:00.123-04~00"));
        }                
        [TestMethod]
        public void ParseSimpleJsonFile()
        {
            var json = DS.Resources.GetTextResource("Me.json", Assembly.GetExecutingAssembly());
            var o    = (Hashtable) new JSON.SyntaxValidator.Compiler().Validate(json);

            Assert.AreEqual("Torres", o["LastName"]);
            Assert.AreEqual("Frederic", o["FirstName"]);
            Assert.AreEqual(new DateTime(1964,12,11), o["BirthDate"]);
            Assert.AreEqual(48.0, o["Age"]);
            Assert.AreEqual(true, o["Male"]);
            Assert.AreEqual(null, o["Other"]);
        }
        public static void HandleException(string json, string expectedErrorMessage, int expectedLine, int expectedColumn, bool supportStarComments = false, bool relaxMode = false)
        {
            var exceptionCaugth = false;
            try
            {
                var r = new JSON.SyntaxValidator.Compiler().Validate(json, relaxMode:relaxMode, supportStartComment: supportStarComments ) as Hashtable;
            }
            catch (ParserException ex)
            {
                Assert.IsTrue(ex.Message.StartsWith(expectedErrorMessage));
                Assert.AreEqual(expectedLine, ex.Line);
                Assert.AreEqual(expectedColumn, ex.Col);
                exceptionCaugth = true;
            }
            if (!exceptionCaugth) Assert.Fail(ERR_MSG_001);
        }
        [TestMethod]
        public void UnexpectedSecondObject()
        {
            string json = @"[1] [2]";
            HandleException(json, JSON.SyntaxValidator.Compiler.SYNTAX_ERROR_014.format("["), 1, 3);          
        }
        [TestMethod]
        public void ComaJustAfterComment()
        {
            string json = @"/* ok */, {}";
            HandleException(json, JSON.SyntaxValidator.Compiler.SYNTAX_ERROR_014.format(","), 1, 0, true);   
        }
        [TestMethod]
        public void ParseIdWithNoDoubleQuote()
        {
            string json = @"{   d:1 }";
            HandleException(json, JSON.SyntaxValidator.Compiler.SYNTAX_ERROR_007, 1, 4);  
        }
        [TestMethod]
        public void ParseObjectWithJustAStringInside()
        {
            string json = @"{ """" }";
            HandleException(json, JSON.SyntaxValidator.Compiler.SYNTAX_ERROR_004, 1, 6);  
        }
        [TestMethod]
        public void ParseObjectWithJustOneDoubleQuote()
        {
            string json = @"{ "" }"; // This should return an error
            HandleException(json, JSON.SyntaxValidator.Compiler.SYNTAX_ERROR_017, 1,1); 
        }
        [TestMethod]
        public void ParseComa()
        {
            string json = @",";
            HandleException(json, JSON.SyntaxValidator.Compiler.SYNTAX_ERROR_014.format(","), 1, 0); 
        }
        [TestMethod]
        public void ParseColon()
        {
            string json = @":";
            HandleException(json, JSON.SyntaxValidator.Compiler.SYNTAX_ERROR_014.format(":"), 1, 0); 
        }
        [TestMethod]
        public void ParseCloseCurlyBracket()
        {
            string json = @"}";
            HandleException(json, JSON.SyntaxValidator.Compiler.SYNTAX_ERROR_014.format("}"), 1, 0); 
        }
        [TestMethod]
        public void ParseAmpersamp()
        {
            string json = @"&";
            HandleException(json, JSON.SyntaxValidator.Compiler.SYNTAX_ERROR_014.format(""), 1, 0);         
        }
        [TestMethod]
        public void ParseOpenBracketOpenCurlyBracketCloseBracket()
        {
            string json = @" [{]";
            HandleException(json, JSON.SyntaxValidator.Compiler.SYNTAX_ERROR_014.format("]"), 1, 4);   
        }
        [TestMethod]
        public void ParseOpenBracketCloseCurlyBracket()
        {
            string json = @" { ""A"":[}";
            HandleException(json, JSON.SyntaxValidator.Compiler.SYNTAX_ERROR_014.format("}"), 1, 9);   
        }
        [TestMethod]
        public void ParseOpenCurlyBracketColon()
        {
            string json = @" { :";
            HandleException(json, JSON.SyntaxValidator.Compiler.SYNTAX_ERROR_014.format(":"), 1, 4);
        }
        [TestMethod]
        public void ParseTrailingComaInAnArrayOfObject()
        {
            string json = @"[ { ""d"":1 }, { ""d"":1 }, ]";
            HandleException(json, JSON.SyntaxValidator.Compiler.SYNTAX_ERROR_001, 1, 22);    
        }
        [TestMethod]
        public void Parse2ComaInARawInObjectQuote()
        {
            string json = @"{ ""d"":1, , ""c"":2 }";
            HandleException(json, JSON.SyntaxValidator.Compiler.SYNTAX_ERROR_012, 1, 7);    
        }
        [TestMethod]
        public void Parse2ComaInARawInArrayFirstElement()
        {
            string json = @"[,,]";
            HandleException(json, JSON.SyntaxValidator.Compiler.SYNTAX_ERROR_013, 1, 2);    
        }
        [TestMethod]
        public void Parse2ComaInARawInArrayQuote()
        {
            string json = @"[1, , 2]";
            HandleException(json, JSON.SyntaxValidator.Compiler.SYNTAX_ERROR_012, 1, 2);  
        }
        [TestMethod]
        public void ParseDate()
        {
            string json = @"{ ""d"":""1964-12-11T00:00:00Z""}";
            var r = new JSON.SyntaxValidator.Compiler().Validate(json);
        }
        [TestMethod]
        public void ParseBool()
        {
            string json = @"{ ""T"":true, ""F"":false }";
            var r = new JSON.SyntaxValidator.Compiler().Validate(json) as Hashtable;
            Assert.AreEqual(true, r["T"]);
            Assert.AreEqual(false, r["F"]);
        }
        [TestMethod]
        public void ParseNull()
        {
            string json = @"{ ""N"":null }";
            var r = new JSON.SyntaxValidator.Compiler().Validate(json) as Hashtable;
            Assert.AreEqual(null, r["N"]);
        }
        [TestMethod]
        public void ParseNumber()
        {
            string json = @"{ ""N"":123 }";
            var r = new JSON.SyntaxValidator.Compiler().Validate(json) as Hashtable;
            Assert.AreEqual(123.0, r["N"]);
        }        
        [TestMethod]
        public void EmptyObject()
        {
            string json = @"{}";            
            var r = new JSON.SyntaxValidator.Compiler().Validate(json) as Hashtable;
            Assert.AreEqual(0, r.Count);
        }
        [TestMethod]
        public void TrailingComaInObject_Case001()
        {
            string json = @"{ , }";
            HandleException(json, JSON.SyntaxValidator.Compiler.SYNTAX_ERROR_013, 1, 3);  
        }
        [TestMethod]
        public void TrailingComaInObject_Case002()
        {
            string json = @"{,}";
            HandleException(json, JSON.SyntaxValidator.Compiler.SYNTAX_ERROR_014.format(","), 1, 2);
        }
        [TestMethod]
        public void TrailingComaInObject_Case003()
        {
            string json = @"{
   ,
}";
            HandleException(json, JSON.SyntaxValidator.Compiler.SYNTAX_ERROR_014.format(","), 2, 4);
        }
        [TestMethod]
        public void TrailingComaInObject_Case004()
        {
            string json = @"{
   


    ,
}";
             var exceptionCaugth = false; 
            try
            {
                var r = new JSON.SyntaxValidator.Compiler().Validate(json) as Hashtable;
            }
            catch (ParserException ex)
            {
                Assert.AreEqual(5, ex.Line);
                Assert.AreEqual(5, ex.Col);
                exceptionCaugth = true;
            }
            if (!exceptionCaugth) Assert.Fail(ERR_MSG_001);
        }
        [TestMethod]
        public void EmptyArray()
        {
            string json = @"[]";
            var r = new JSON.SyntaxValidator.Compiler().Validate(json) as ArrayList;
            Assert.AreEqual(0, r.Count);
        }
        [TestMethod]
        public void ArrayWithValues()
        {
            string json = @"[1, 2.0, true, false, ""Hi"", ""1964-12-11T00:00:00Z"", null]";
            var r = new JSON.SyntaxValidator.Compiler().Validate(json) as ArrayList;
            Assert.AreEqual(7, r.Count);
            Assert.AreEqual(1.0, r[0]);
            Assert.AreEqual(2.0, r[1]);
            Assert.AreEqual(true, r[2]);
            Assert.AreEqual(false, r[3]);
            Assert.AreEqual("Hi", r[4]);
            Assert.AreEqual(new DateTime(1964, 12, 11), r[5]);
            Assert.AreEqual(null, r[6]);            
        }
        [TestMethod]
        public void TrailingComaInArray_Case001()
        {
            string json = @"[ , ]";
             var exceptionCaugth = false; 
            try
            {
                var r = new JSON.SyntaxValidator.Compiler().Validate(json) as Hashtable;
            }
            catch (ParserException ex)
            {
                Assert.AreEqual(1, ex.Line);
                Assert.AreEqual(3, ex.Col);
                exceptionCaugth = true;
            }
            if (!exceptionCaugth) Assert.Fail(ERR_MSG_001);
        }
        [TestMethod]
        public void TrailingComaInArray_Case002()
        {
            string json = @"[
   


    ,
]";
             var exceptionCaugth = false; 
            try
            {
                var r = new JSON.SyntaxValidator.Compiler().Validate(json) as Hashtable;
            }
            catch (ParserException ex)
            {
                Assert.AreEqual(5, ex.Line);
                Assert.AreEqual(5, ex.Col);
                exceptionCaugth = true;
            }
            if (!exceptionCaugth) Assert.Fail(ERR_MSG_001);
        }
        [TestMethod]
        public void SyntaxError_MissingArrayClosingBraket_Case001()
        {
            string json = @"[1";
             var exceptionCaugth = false; 
            try
            {
                var r = new JSON.SyntaxValidator.Compiler().Validate(json) as Hashtable;
            }
            catch (ParserException ex)
            {
                Assert.IsTrue(ex.Message.StartsWith(JSON.SyntaxValidator.Compiler.SYNTAX_ERROR_009));
                Assert.AreEqual(1, ex.Line);
                Assert.AreEqual(2, ex.Col);
                exceptionCaugth = true;
            }
            if (!exceptionCaugth) Assert.Fail(ERR_MSG_001);
        }
        [TestMethod]
        public void SyntaxError_MissingObjectClosingBraket_Case001()
        {
            string json = @"{ 
                ""a""
                    :
1 ";
            var exceptionCaugth = false; 
            try
            {
                var r = new JSON.SyntaxValidator.Compiler().Validate(json) as Hashtable;
            }
            catch (ParserException ex)
            {
                Assert.IsTrue(ex.Message.StartsWith(JSON.SyntaxValidator.Compiler.SYNTAX_ERROR_010));
                Assert.AreEqual(4, ex.Line);
                Assert.AreEqual(1, ex.Col);
                exceptionCaugth = true;
            }
            if (!exceptionCaugth) Assert.Fail(ERR_MSG_001);
        }
        [TestMethod]
        public void SyntaxError_SyntaxErrorMissingComaInArray_Case001()
        {
            string json = @"[1 2]";
            HandleException(json, JSON.SyntaxValidator.Compiler.SYNTAX_ERROR_009, 1, 2);  
        }
        [TestMethod]
        public void SyntaxError_SyntaxErrorMissingComaInObject_Case001()
        {
            string json = @"{ ""a"":1 ""b"":2 }";
            HandleException(json, JSON.SyntaxValidator.Compiler.SYNTAX_ERROR_010, 1, 7); 
        }
        [TestMethod]
        public void ParseSimpleJsonFileWithComments()
        {
            string json = DS.Resources.GetTextResource("MeWithComments.json", Assembly.GetExecutingAssembly());
            var o = (Hashtable)new JSON.SyntaxValidator.Compiler().Validate(json, supportStartComment:true);

            Assert.AreEqual("Torres", o["LastName"]);
            Assert.AreEqual("Frederic", o["FirstName"]);
            Assert.AreEqual(new DateTime(1964, 12, 11), o["BirthDate"]);
            Assert.AreEqual(48.0, o["Age"]);
            Assert.AreEqual(true, o["Male"]);
            Assert.AreEqual(null, o["Other"]);
        }
        [TestMethod]
        public void ParseSlashCommentAtTheEndOfFileInStrictMode()
        {
            string json = @"
{ ""LastName"" : ""Smith"" }
// this is a bad comment
";
            HandleException(json, JSON.SyntaxValidator.Compiler.SYNTAX_ERROR_018, 3, 0);  
        }
         [TestMethod]
        public void ParseUnexpectedTrueAtTheEndOfFileInStrictMode()
        {
            string json = @"
{ ""LastName"" : ""Smith"" }
true
";
  
            HandleException(json, JSON.SyntaxValidator.Compiler.SYNTAX_ERROR_014.format("true"), 2, 24);  
        }
    }
}
