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
    public class PoswerShellCommentParserUnitTests
    {         
        const string COMMENT_START = "<#";
        const string COMMENT_END = "#>";
        [TestMethod]
        public void PoswerShellParseOneComment()
        {   
            //                0123456789
            string source = @" <# ok #> ";
            var comments = new CommentParser().Parse(source, COMMENT_START, COMMENT_END);
            Assert.AreEqual(1, comments.Count);
            Assert.AreEqual(1, comments[0].Start);
            Assert.AreEqual(8, comments[0].End);
            Assert.AreEqual(4, comments[0].Length);
            Assert.AreEqual(" ok ", comments[0].Text);
        }
        [TestMethod]
        public void PoswerShellParseThreeComment()
        {
            //                01234567890123456789
            string source = @" <#1#> <#2#> <#3#>";
            var comments = new CommentParser().Parse(source, COMMENT_START, COMMENT_END);
            Assert.AreEqual(3, comments.Count);

            Assert.AreEqual(1, comments[0].Start);
            Assert.AreEqual(5, comments[0].End);
            Assert.AreEqual(1, comments[0].Length);
            Assert.AreEqual("1", comments[0].Text);

            Assert.AreEqual(7, comments[1].Start);
            Assert.AreEqual(11, comments[1].End);
            Assert.AreEqual(1, comments[1].Length);
            Assert.AreEqual("2", comments[1].Text);

            Assert.AreEqual(13, comments[2].Start);
            Assert.AreEqual(17, comments[2].End);
            Assert.AreEqual(1, comments[2].Length);
            Assert.AreEqual("3", comments[2].Text);
        }
       
        [TestMethod]
        public void PoswerShellParseJsonWithALotOfComments()
        {
            string json = DS.Resources.GetTextResource("PowerShellWithALotOfComments.ps1", Assembly.GetExecutingAssembly());
          
            var comments = new CommentParser().Parse(json, COMMENT_START, COMMENT_END);
            Assert.AreEqual(20, comments.Count);
            Assert.AreEqual(" Template defining the caption of the object ", comments[0].Text);
            Assert.AreEqual(" The property to use as the identifier       ", comments[1].Text);
            Assert.AreEqual(" The sections and the properties order. The character @ define section, the character # define an action to use as a button ", comments[2].Text);
          
            Assert.AreEqual(" The property to use to sort the objects                            ", comments[3].Text);
            Assert.AreEqual(" The property to use to group the object into sections               ", comments[4].Text);
            Assert.AreEqual(" Properties to add the first time or each time the object is opened ", comments[5].Text);
            Assert.AreEqual(" Re initialize the value each time the dialog is opened ", comments[6].Text);

            Assert.AreEqual(" Message to display after the action failed                   ", comments[18].Text);
            Assert.AreEqual(" More info about the properties of the object ", comments[19].Text);   
        }
        
    }
}
