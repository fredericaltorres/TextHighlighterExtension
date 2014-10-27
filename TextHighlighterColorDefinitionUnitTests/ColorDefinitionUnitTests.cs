using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DynamicSugar;
using System.IO;
using System.Linq;
using System.Reflection;
using TextHighlighterColorDefinition;

namespace TextHighlighterColorDefinitionUnitTests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class ColorDefinitionUnitTests
    {
        public ColorDefinitionUnitTests()
        {
        }
                
        private TestContext testContextInstance;
        public TestContext TestContext { get { return testContextInstance; } set { testContextInstance = value; } }


        private static string TestFolder;
        private static string COLORS_DEFINITION_DARK_TEST_FILE;
        private static string COLORS_DEFINITION_LIGHT_TEST_FILE;

        private static string ExportFile(string fileName, string folder) {

            var fullFileName = Path.Combine(folder, fileName);
            if(File.Exists(fullFileName))
                File.Delete(fullFileName);
            File.WriteAllText(fullFileName, DS.Resources.GetTextResource(fileName, Assembly.GetExecutingAssembly()));
            return fullFileName;
        }

        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext) {

            TestFolder = Path.Combine(Environment.GetEnvironmentVariable("TEMP"), "TextHighlighterColorDefinitionUnitTests");

            if(!System.IO.Directory.Exists(TestFolder))
                System.IO.Directory.CreateDirectory(TestFolder);

            COLORS_DEFINITION_DARK_TEST_FILE  = ExportFile("COLORS_DEFINITION_DARK.json",  TestFolder);
            COLORS_DEFINITION_LIGHT_TEST_FILE = ExportFile("COLORS_DEFINITION_LIGHT.json", TestFolder);
        }

        [ClassCleanup()]
        public static void MyClassCleanup() { }
        
        [TestInitialize()]
        public void MyTestInitialize() { }
        
        [TestCleanup()]
        public void MyTestCleanup() { }


        [TestMethod]
        public void LoadColorDefinition()
        {
            var cd = new ColorDefinition(COLORS_DEFINITION_DARK_TEST_FILE);
            Assert.AreEqual("Dark", cd.Theme);

            var fileExtensions = cd.GetFileExtensions();
            Assert.AreEqual(5, fileExtensions.Count);

            Assert.IsTrue(fileExtensions.Include(DS.List("JSON", "INI", "BAT", "LOG", "TXT")));
            
        }

        [TestMethod]
        public void GetColor()
        {
            var cd = new ColorDefinition(COLORS_DEFINITION_DARK_TEST_FILE);
            Assert.AreEqual("italic.MediumSpringGreen", cd.GetColor( FileExtensionSupported.BAT,"Comment"));
            Assert.AreEqual("bold.LightBlue", cd.GetColor( FileExtensionSupported.BAT,"Keyword"));
            Assert.AreEqual("NavajoWhite", cd.GetColor( FileExtensionSupported.BAT,"Default"));
        }

        [TestMethod]
        public void LoadColorDefinitionVerifyBatchColorDefinition()
        {
            var cd = new ColorDefinition(COLORS_DEFINITION_DARK_TEST_FILE);            

            var batchColorDefinition = cd.GetFileColorDefinitionSet(FileExtensionSupported.BAT);
            Assert.AreEqual(10, batchColorDefinition.Count);
            Assert.IsTrue(batchColorDefinition.Keys.ToList().Include(DS.List("Keyword", "Comment", "Flag", "Label", "EnvVar", "Redirection", "Punctuation","Parameter", "String", "Default")));
           
            DS.Assert.ValueTypeProperties(batchColorDefinition["Keyword"],     new { ColorName = "LightBlue",         Bold = true,  Italic = false });
            DS.Assert.ValueTypeProperties(batchColorDefinition["Comment"],     new { ColorName = "MediumSpringGreen", Bold = false, Italic = true  });
            DS.Assert.ValueTypeProperties(batchColorDefinition["Flag"],        new { ColorName = "Turquoise",         Bold = false, Italic = false });
            DS.Assert.ValueTypeProperties(batchColorDefinition["Label"],       new { ColorName = "DarkOrange",        Bold = false, Italic = false });
            DS.Assert.ValueTypeProperties(batchColorDefinition["EnvVar"],      new { ColorName = "DarkSalmon",        Bold = true,  Italic = true  });
            DS.Assert.ValueTypeProperties(batchColorDefinition["Redirection"], new { ColorName = "Red",               Bold = false, Italic = false });
            DS.Assert.ValueTypeProperties(batchColorDefinition["Punctuation"], new { ColorName = "Red",               Bold = false, Italic = false });
            DS.Assert.ValueTypeProperties(batchColorDefinition["Parameter"],   new { ColorName = "DarkKhaki",         Bold = false, Italic = false });
            DS.Assert.ValueTypeProperties(batchColorDefinition["String"],      new { ColorName = "LightSkyBlue",      Bold = false, Italic = false });
            DS.Assert.ValueTypeProperties(batchColorDefinition["Default"],     new { ColorName = "NavajoWhite",       Bold = false, Italic = false });
        }

        [TestMethod]
        public void UpdateBatchColorDefinition()
        {
            var cd                   = new ColorDefinition(COLORS_DEFINITION_DARK_TEST_FILE);
            var batchColorDefinition = cd.GetFileColorDefinitionSet(FileExtensionSupported.BAT);

            foreach(var b in batchColorDefinition) {

                b.Value.Italic    = true;
                b.Value.Bold      = true;
                b.Value.ColorName = "NavajoWhite";
            }
            cd.SetFileColorDefinitionSet(FileExtensionSupported.BAT, batchColorDefinition);

            var newFileName = cd.FileName + ".json";
            cd.Save(newFileName); 
            
            var cd2              = new ColorDefinition(newFileName);
            batchColorDefinition = cd2.GetFileColorDefinitionSet(FileExtensionSupported.BAT);

            foreach(var b in batchColorDefinition) {

                DS.Assert.ValueTypeProperties(b.Value, new { ColorName = "NavajoWhite", Bold = true, Italic = true });
            }
            File.Delete(newFileName);
        }

        [TestMethod]
        public void GetAvailableThemes()
        {
            var themes = ColorDefinition.GetAvailableThemes(TestFolder);
            Assert.AreEqual(2, themes.Count);
            Assert.IsTrue(themes.Include(DS.List("Dark", "Light")));
        }

        [TestMethod]
        public void GetDrawingColorMap()
        {
            var map = ColorDefinition.GetDrawingColorMap();
            Assert.AreEqual(141, map.Count);   
            Assert.AreEqual(System.Drawing.Color.AliceBlue, map["AliceBlue"]);
        }

        [TestMethod]
        public void GetMediaColorMap()
        {
            var map = ColorDefinition.GetMediaColorMap();
            Assert.AreEqual(141, map.Count);   
                        
            Assert.AreEqual(System.Windows.Media.Colors.AliceBlue, map["AliceBlue"]); 
        }

        [TestMethod]
        public void GetDrawingColor()
        {            
            Assert.AreEqual(System.Drawing.Color.AliceBlue, ColorDefinition.GetDrawingColor(System.Windows.Media.Colors.AliceBlue)); 
        }
    }
}
