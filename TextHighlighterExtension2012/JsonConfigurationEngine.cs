
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;
using System.Windows;
using DynamicSugar;
using System.Text.RegularExpressions;
using System.IO;
using TextHighlighterExtension2012;
using System.Reflection;

namespace TextHighlighterExtension
{
    class ConfigurationEngine
    {
        /// <summary>
        /// Regular Expression cache to get compiled the reg ex for TXT and LOG file
        /// </summary>
        private static Dictionary<string, System.Text.RegularExpressions.Regex> _regexCache = new Dictionary<string, System.Text.RegularExpressions.Regex>();

        public static void Refresh() {
            
            _regexCache.Clear();
            _singleton = null;
        }

        private static ConfigurationEngine _singleton;

        /// <summary>
        /// 
        /// </summary>
        public static ConfigurationEngine Singleton { 
            get{
                if(_singleton==null)
                    _singleton = new ConfigurationEngine();
                return _singleton;
            }
        }

        public static void PurgeSingleton() {
            
            _singleton = null;
        }

        TextHighlighterColorDefinition.ColorDefinition                      _colorDefinition;
        public CTxt.CTxtDefinition                                          CTxtDefinition;
        public TextHighlighterExtension2012.Languages.IntellisenseManager   IntellisenseManager;

        /// <summary>
        /// Constructor Initializer
        /// </summary>
        public ConfigurationEngine() {
            
            Log("*** Initialize JsonConfigurationEngine ***");
            this.Load();
            this.IntellisenseManager = new TextHighlighterExtension2012.Languages.IntellisenseManager();

            //var powerShellTxtHelpTextFile = @"C:\Users\frederic.torres\Desktop\TextHighlighterExtensionV30\TextHighlighterExtension2012\LanguageServices\Languages\PS1\GenerateIntellisense\Txt";
            //DynamicSugar.Compression.GZip.GZipFolder(powerShellTxtHelpTextFile, "*.txt");
        }

        private string GetColorDefinitionFileName() {

            return GetConfigJson().GetColorDefinitionFileName();
        }

        private string GetCurrentTheme() {

            return GetConfigJson().BackGroundColorTheme;
        }

        public TextHighlighterExtension2012.ConfigJson GetConfigJson() {

            return TextHighlighterExtension2012.ConfigJson.Load();
        }

        private static string GetLogFileName() {

            return Path.Combine(ConfigJson.GetExtensionPath(), "log.log");
        }

        public static void Log(string m) {

            #if DEBUG
                File.AppendAllText(GetLogFileName(), "[{0}]{1}\r\n".format(DateTime.Now, m));
            #endif
        }

        /// <summary>
        /// Return a full path for any file in the extension
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        private string GetAbsoluteFile(string f) {
        
            return @"{0}\{1}".format(ConfigJson.GetExtensionPath(), f);
        }

        public Dictionary<string, string> GetPowerShellKeywords() {

            var json = this.LoadKeywordsJsonFile();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, string>>(json["PS1_KEYWORDS"].ToString());
        }

        public Dictionary<string, string> GetPowerShellCommands() {

            var json = this.LoadKeywordsJsonFile();
            var dic = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, string>>(json["PS1_COMMANDS"].ToString());

            HouseKeepingPowerShellIntellisense(dic);

            return dic;
        }

        private void HouseKeepingPowerShellIntellisense(Dictionary<string, string> dic) {
            /*
            var b = new StringBuilder(1000);
            foreach(var command in dic.Keys.ToList()) { 
                b.AppendFormat(@"get-help {0} -detailed >.\{0}.txt", command).AppendLine();
            }
            var s = b.ToString();
            */
            // var powerShellCommandDefs = DS.Resources.GetTextResource(new Regex("PS1.GenerateIntellisense.Txt..*txt$", RegexOptions.IgnoreCase), Assembly.GetExecutingAssembly());

        }

        public Dictionary<string, string> GetBatKeywordDescription() {

            var r    = new Dictionary<string, string>();
            var json = this.LoadKeywordsJsonFile();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, string>>(json["BAT"].ToString());
        }


        public Dictionary<string, string> GetBashKeywordDescription() {

            var r    = new Dictionary<string, string>();
            var json = this.LoadKeywordsJsonFile();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, string>>(json["BASH_RESERVED_KEYWORDS"].ToString());
        }

        public Dictionary<string, string> GetBashBuiltInDescription() {

            var r    = new Dictionary<string, string>();
            var json = this.LoadKeywordsJsonFile();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, string>>(json["BASH_BUILT_IN"].ToString());
        }

        private JObject LoadKeywordsJsonFile() {

            var fileName = this.GetAbsoluteFile("KEYWORDS.json");
            if(File.Exists(fileName)) {
                return JObject.Parse(System.IO.File.ReadAllText(fileName));
            }
            return null;
        }

        ///// <summary>
        ///// Return the path of the Config.json file
        ///// </summary>
        ///// <returns></returns>
        //private string GetConfigFileName() {
        
        //    +++
        //    return @"{0}\Config.json".format(ConfigJson.GetExtensionPath());
        //}

        private bool IsFirstExecution() {

            return !System.IO.File.Exists(ConfigJson.GetConfigFileName());
        }

        private void LoadColorDefinitions() {

            var fullColorDefinitionFileName = Path.Combine(ConfigJson.GetExtensionPath(), this.GetColorDefinitionFileName());
            Log("Loading color definition {0}".format(fullColorDefinitionFileName));
            this._colorDefinition = new TextHighlighterColorDefinition.ColorDefinition(fullColorDefinitionFileName);
        }
        /// <summary>
        /// Load the color definition and take care of the first execution
        /// </summary>
        public void Load() {
            
            TextHighlighterColorDefinition.ColorDefinition.ExtractDefaultColorDefinitionJsonFile(ConfigJson.GetExtensionPath());

            if(this.IsFirstExecution()) {
                
                Log("First execution");
                // Create the Config.json file
                var configJson = new TextHighlighterExtension2012.ConfigJson();
                configJson.Save();
            }
            this.LoadColorDefinitions();
            
            #if VS2012
                this.CTxtDefinition = new CTxt.CTxtDefinition(_colorDefinition.JsonObject["CTXT"] as JObject);
            #endif
        }

        public List<string> GetKeys(JObject o)
        {     
            var l = new List<string>();
            foreach (var e in o)
            {
                l.Add(e.Key);
            }
            return l;
        }
        /// <summary>
        /// Return the color to use for a TXT or LOG file based on the line
        /// Use an internal cache of compiled regex
        /// </summary>
        /// <param name="line"></param>
        /// <param name="extension"></param>
        /// <returns></returns>
        public string GetColorForTextFile(string line, string extension)
        {
            extension = extension.ToUpper();

            if (_colorDefinition.JsonObject[extension] == null)
                return "white";

            var ext  = _colorDefinition.JsonObject[extension] as JObject;
            var keys = this.GetKeys(ext);

            foreach (var k in keys)
            {
                if (k == "") 
                    continue;

                var regExKey = extension + "|" + k;
                if (!_regexCache.ContainsKey(regExKey)) // Add to cache
                {
                    _regexCache.Add(regExKey, new Regex(k, RegexOptions.Compiled | RegexOptions.IgnoreCase));
                }

                var rx = _regexCache[regExKey];
                if (rx.IsMatch(line))
                {
                    return ext[k].ToString();
                }
            }
            if (ext[""] != null)
                return ext[""].ToString();

            return "white";
        }

        public string GetJsonColor(string name) {
        
            return GetColor("JSON", name);
        }

        public string GetBatColor(string name) {
        
            return GetColor("BAT", name);
        }

        public string GetPowerShellColor(string name) {
        
            return GetColor("PS1", name);
        }

        public string GetCTxtColor(string name) {
        
            return GetColor("CTXT", name);
        }

        public string GetIniColor(string name) {

            return GetColor("INI", name);
        }

        public string GetColor(string fileExtension, string name, string defaultValue = null) {

            return this._colorDefinition.GetColor(fileExtension, name, defaultValue);
        }
    }
}

