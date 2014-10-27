using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DynamicSugar;
using Newtonsoft.Json.Linq;
using TextHighlighterExtension2012;

namespace FredericTorres.TextHighlighterPackage.Configuration
{
    class TextHighlighterConfigApi
    {
        public static string GetBackGroundColorTheme() {

            var configJson = ConfigJson.Load();
            return configJson.BackGroundColorTheme;
        }

        public static bool GetRelaxMode() {

            var configJson = ConfigJson.Load();
            return configJson.JsonRelaxMode;
        }

        public static bool GetInsertClosingCharacter() {

            var configJson = ConfigJson.Load();
            return configJson.JsonInsertClosingChar;
        }

        public static string GetIniFileCommentChars() {

            var configJson = ConfigJson.Load();
            return configJson.IniFileCommentChars;
        }

        public static void SetJsonRelaxModeAndClosingChar(bool relaxMode, bool insertClosingChar, string iniFileCommentChars) {

            ConfigJson configJson            = ConfigJson.Load();
            configJson.JsonRelaxMode         = relaxMode;
            configJson.JsonInsertClosingChar = insertClosingChar;

            if(iniFileCommentChars!=null)
                configJson.IniFileCommentChars = iniFileCommentChars;

            configJson.Save();
        }

        public static void SetBackGroundColorDefinition(string theme) {

            ConfigJson configJson           = ConfigJson.Load();
            configJson.BackGroundColorTheme = theme;
            configJson.Save();
        }

        public static string GetColorDefinitionFileName() {

            var configJson = ConfigJson.Load();
            var file = Path.Combine(ConfigJson.GetExtensionPath(), configJson.GetColorDefinitionFileName());
            return file;
        }

        public static void OpenColorDefinitionFileInTextEditor() {
            
            TextHighlighterConfigApi.OpenFileInVS(GetColorDefinitionFileName());
        }

        public static void OpenIntellisenseDefinitionFileInTextEditor() {

            var configJson = ConfigJson.Load();
            var file       = Path.Combine(ConfigJson.GetExtensionPath(), configJson.GetIntellisenseDefinitionFileName());

            TextHighlighterConfigApi.OpenFileInVS(file);
        }

        public static void OpenFileInVS(string file) {
            
            TextHighlighterPackagePackage.dte2.ItemOperations.OpenFile(file); 
        }
             
        public static TextHighlighterColorDefinition.FileColorDefinitionSet GetFileColorDefinitionSet(string extension) {
                        
            return TextHighlighterConfigApi.GlobalColorDefinition.GetFileColorDefinitionSet(TextHighlighterColorDefinition.ColorDefinition.ToFileExtensionSupported(extension));
        }

        public static void SetFileColorDefinitionSet(string extension,  TextHighlighterColorDefinition.FileColorDefinitionSet fileColorDefinitionSet) {
            
            TextHighlighterConfigApi.GlobalColorDefinition.SetFileColorDefinitionSet(TextHighlighterColorDefinition.ColorDefinition.ToFileExtensionSupported(extension), fileColorDefinitionSet);
        }

        public static List<string> GetAvailableThemes() {

            return TextHighlighterColorDefinition.ColorDefinition.GetAvailableThemes(ConfigJson.GetExtensionPath());
        }
                
        public static TextHighlighterColorDefinition.ColorDefinition _globalColorDefinition = null;

        public static TextHighlighterColorDefinition.ColorDefinition GlobalColorDefinition {
            get {
                
                if(_globalColorDefinition == null)
                    _globalColorDefinition = new TextHighlighterColorDefinition.ColorDefinition(TextHighlighterConfigApi.GetColorDefinitionFileName());

                return _globalColorDefinition;
            }
        }
        
        public static void OpenExtensionFolder() {
            
            Executor.Executor.Execute("explorer.exe", @"""{0}""".format(ConfigJson.GetExtensionPath()));
        }

        public static void PurgeGlobalColorDefinition() {
            
            _globalColorDefinition = null;
        }
    }
}

