using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DynamicSugar;
using TextHighlighterExtension2012;
using TextHighlighterColorDefinition;

namespace TextHighlighterColorDefinitionUnitTests
{
    /// <summary>
    /// Summary description for OrderedDictionaryUnitTest
    /// </summary>
    [TestClass]
    public class JsonPrettyprintUnitTest
    {
        public JsonPrettyprintUnitTest()
        {
        }

        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
}
            set{ testContextInstance = value; }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void Format_1()
        {
            var expected = @"{
  ""A"": 1
}";
            Assert.AreEqual(expected, JsonPrettyPrint.Format("{A:1}"));
        }
       


    }
}
