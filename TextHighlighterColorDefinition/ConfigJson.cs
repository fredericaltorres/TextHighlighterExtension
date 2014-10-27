using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DynamicSugar;
using Newtonsoft.Json.Linq;

namespace TextHighlighterExtension2012
{
    public class ConfigJson
    {
        public const string BACKGROUND_COLOR_THEME_DARK     = "Dark";
        public const string BACKGROUND_COLOR_THEME_LIGHT    = "Light";

        public static string GetExtensionPath() {
        
            var p = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            return p;
        }

        public static string GetWriteableExtensionPath() {

            var p = System.IO.Path.Combine(Environment.GetEnvironmentVariable("LOCALAPPDATA"), "TextHighlighterExtension2013");
            if (!System.IO.Directory.Exists(p)) {
                try {
                    System.IO.Directory.CreateDirectory(p);
                }
                catch (System.Exception ex) {
                    Util.Utility.MsgBoxError("Cannot create folder '{0}'.\r\n{1}".format(p, ex.Message));
                    throw;
                }
            }
            return p;
        }

        public static string GetConfigFileName() {

            return @"{0}\Config.json".format(ConfigJson.GetWriteableExtensionPath());
        }

        public static string GetColorName(System.Windows.Media.Color color)
        {
            Type colors = typeof(System.Windows.Media.Colors);
            foreach(var prop in colors.GetProperties())
            {
                if(((System.Windows.Media.Color)prop.GetValue(null, null)) == color)
                    return prop.Name;
            }

            throw new Exception("The provided Color is not named.");
        }

        public static System.Drawing.Color ColorFromMediaColor(System.Windows.Media.Color clr)
        {
            return System.Drawing.Color.FromArgb(clr.A, clr.R, clr.G, clr.B);
        }

        public string BackGroundColorTheme;
        public bool JsonRelaxMode;
        public bool JsonInsertClosingChar;
        public string IniFileCommentChars = ";#/";

        public ConfigJson() {

            this.BackGroundColorTheme  = BACKGROUND_COLOR_THEME_DARK;
            this.JsonInsertClosingChar = true;
        }

        public string Serialize()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public void Save()
        {
            System.IO.File.WriteAllText(GetConfigFileName(), this.Serialize());
        }

        public static ConfigJson Load()
        {
            var fileName = GetConfigFileName();
            if(System.IO.File.Exists(fileName)) {
                var json  = System.IO.File.ReadAllText(fileName);
                return Deserialize(json);
            }
            else {
                return new ConfigJson();
            }
        }

        public static ConfigJson Deserialize(string json)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ConfigJson>(json);
        }

        public string GetColorDefinitionFileName() {

            return "COLORS_DEFINITION_{0}.json".format(this.BackGroundColorTheme.ToUpper());
        }

        public string GetIntellisenseDefinitionFileName() {

            return "Intellisense.json";
        }
    }
}
