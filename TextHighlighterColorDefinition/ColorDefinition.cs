using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DynamicSugar;
using Newtonsoft.Json.Linq;

namespace TextHighlighterColorDefinition {

    public enum FileExtensionSupported {
        BAT,
        INI,
        JSON,
        TXT,
        CTXT, 
        LOG,
        PS1
    }
   
    /// <summary>
    /// Represent the file COLORS_DEFINITION_DARK.json or other
    /// </summary>
    public class ColorDefinition {

        public JObject JsonObject;
        public string FileName;
        private JSON.SyntaxValidator.MD5Hash _hash;

        public static void ExtractDefaultColorDefinitionJsonFile(string folder) {

            DS.Resources.SaveBinaryResourceAsFiles(Assembly.GetExecutingAssembly(), folder, "COLORS_DEFINITION_DARK.json", "COLORS_DEFINITION_LIGHT.json");
        }

        public static FileExtensionSupported ToFileExtensionSupported(string s) {

            var v = (FileExtensionSupported)Enum.Parse(typeof(FileExtensionSupported), s); 
            return v;
        }

        public static string GetVersion() {
            
            var ver = Assembly.GetExecutingAssembly().GetName().Version;
            return "{0}.{1}".format(ver.Major, ver.Minor);
        }

        /// <summary>
        /// http://msmvps.com/blogs/jon_skeet/archive/2009/09/10/generic-constraints-for-enums-and-delegates.aspx
        /// </summary>
        /// <typeparam name="MyEnum"></typeparam>
        /// <param name="s"></param>
        /// <returns></returns>
        /// 

        const string VersionJsonPropertyName = "$Version";

        public string Version {
            get {
                return this.JsonObject[VersionJsonPropertyName].ToString();
            }
            set {
                this.JsonObject[VersionJsonPropertyName] = value;
            }
        }

        const string ThemeJsonPropertyName = "$BackgroundTheme";

        public string Theme {
            get {
                return this.JsonObject[ThemeJsonPropertyName].ToString();
            }
            set {
                this.JsonObject[ThemeJsonPropertyName] = value;
            }
        }

        public ColorDefinition(string fileName) {

            var json        = System.IO.File.ReadAllText(fileName);
            this._hash      = JSON.SyntaxValidator.MD5Hash.Make(json);
            this.JsonObject = JObject.Parse(json);
            this.FileName   = fileName;
        }

        public string GetColor(FileExtensionSupported fileExtension, string keyword, string defaultValue = null) {

            return this.GetColor(fileExtension.ToString(), keyword, defaultValue);
        }

        public string GetColor(string fileExtension, string name, string defaultValue = null) {
            
            if (this.JsonObject[fileExtension] == null)
                return defaultValue;

            var sectionNode = this.JsonObject[fileExtension];

            if (sectionNode[name] == null)
                return defaultValue;

            var colorNode = sectionNode[name];

            return colorNode.ToString();            
        }

        public void Save(string fileName = null) {

            if(fileName == null)
                fileName = this.FileName;

            this.Version = ColorDefinition.GetVersion();

            var json = Newtonsoft.Json.JsonConvert.SerializeObject(this.JsonObject, Newtonsoft.Json.Formatting.Indented);

            if(File.Exists(fileName))
                File.Delete(fileName);

            System.IO.File.WriteAllText(fileName, json);
        }

        /// <summary>
        /// Get a color definition for one extension
        /// </summary>
        /// <param name="extension"></param>
        /// <returns></returns>
        public FileColorDefinitionSet GetFileColorDefinitionSet(FileExtensionSupported extension) {

            var map           = GetKeywordColorMap(extension);
            var b             = new FileColorDefinitionSet();            
            var mediaColorMap = GetMediaColorMap();
            b.Extension       = extension.ToString();

            foreach(var e in map) {

                var colorDetail = new ColorDefinitionDetail() {
                    Bold      = e.Value.Contains("bold.")   || e.Value.Contains("bolditalic."),
                    Italic    = e.Value.Contains("italic.") || e.Value.Contains("bolditalic."),
                    ColorName = e.Value.Replace("bolditalic.","").Replace("bold.","").Replace("italic.","")
                };

                if(colorDetail.ColorName.In(mediaColorMap))
                    colorDetail.Color = mediaColorMap[colorDetail.ColorName];
                
                b.Add(e.Key, colorDetail);
            }
            return b;
        }

        /// <summary>
        /// Set one extension color definition in the color definition
        /// </summary>
        /// <param name="extension"></param>
        /// <param name="fileColorDefinitionSet"></param>
        public ColorDefinition SetFileColorDefinitionSet(FileExtensionSupported extension, FileColorDefinitionSet fileColorDefinitionSet) {

            var json                              = fileColorDefinitionSet.ToJSON();
            this.JsonObject[extension.ToString()] = JObject.Parse(json);
            return this;
        }

        /// <summary>
        /// Return the list of extension defined in the color definition
        /// </summary>
        /// <returns></returns>
        public List<string> GetFileExtensions() {

            var l = new List<string>();

            foreach(var o in this.JsonObject)
                if(!o.Key.StartsWith("$") && o.Key != FileExtensionSupported.CTXT.ToString())
                    l.Add(o.Key);

            return l;
        }

        /// <summary>
        /// For one file extension return a dictionary, the key is the keyword type the value
        /// is the json string [bol, italic.]colorName
        ///  {
        ///     { "Variable" ,"bold.Peru"     },
        ///     { "Comment"  ,"SeaGreen"      },
        ///     { "Section"  ,"italic.Orange" },
        ///     { "Equal"    ,"Orange"        },
        ///     { "Value"    ,"LightCoral"    },
        ///     { "Default"  ,"White"         }
        ///  }
        /// </summary>
        /// <param name="fileExtension"></param>
        /// <returns></returns>
        public Dictionary<string, string> GetKeywordColorMap(FileExtensionSupported fileExtension) {

            var d = new Dictionary<string,string>();

            if(!fileExtension.ToString().In(GetFileExtensions()))
                throw new ArgumentException("File extension:{0} in file:{1}not found".format(fileExtension, this.FileName));

            var ext = this.JsonObject[fileExtension.ToString()] as JObject;

            foreach(var e in ext)
                d.Add(e.Key, e.Value.ToString());
            
            return d;
        }

        /// <summary>
        /// Return all the System.Windows.Media.Colors in a dictionary by name
        /// </summary>
        /// <returns></returns>
        public static Dictionary<string, System.Windows.Media.Color> GetMediaColorMap() {

            var d       = new Dictionary<string, System.Windows.Media.Color>();
            Type colors = typeof(System.Windows.Media.Colors);

            foreach(var prop in colors.GetProperties()) {

                System.Windows.Media.Color c = (System.Windows.Media.Color)prop.GetValue(null, null);
                d.Add(prop.Name, c);
            }
            return d;
        }

        /// <summary>
        /// Return all Drawing.Color in a dictionary by name
        /// </summary>
        /// <returns></returns>
        public static Dictionary<string, System.Drawing.Color> GetDrawingColorMap() {

            var d                       = new Dictionary<string, System.Drawing.Color>();
            Type colorType              = typeof(System.Drawing.Color);
            PropertyInfo[] propInfoList = colorType.GetProperties(BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public);

            foreach (System.Reflection.PropertyInfo c in propInfoList) {

                var color = (System.Drawing.Color)c.GetValue(null, null);
                d.Add(c.Name, color);
            }
            return d;
        }

        /// <summary>
        /// Return the Drawing.Color matching the Media.Color
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static System.Drawing.Color GetDrawingColor(System.Windows.Media.Color c) {

            var mediaMap   = GetMediaColorMap();
            var drawingMap = GetDrawingColorMap();

            foreach(var e in mediaMap) {
                if(e.Value == c) {
                    var colorName = e.Key;
                    if(e.Key.In(drawingMap))
                        return drawingMap[e.Key];
                }
            }
            return  System.Drawing.Color.AliceBlue;
        }

        public static List<string> GetAvailableThemes(string folder) {

            var l = new List<string>();

            var files = System.IO.Directory.GetFiles(folder, "COLORS_DEFINITION_*.json");
            foreach(var file in files) {
                var file2 = Path.GetFileNameWithoutExtension(file);
                l.Add(file2.Replace("COLORS_DEFINITION_","").Capitalize());
            }
            return l;
        }
    }
}
