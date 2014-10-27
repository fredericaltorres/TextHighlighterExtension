using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DynamicSugar;
using Microsoft.VisualStudio.Language.Intellisense;
using Newtonsoft.Json.Linq;
using TextHighlighterExtension;

namespace TextHighlighterExtension2012.Languages {

    public class IntellisenseDefinitionItem {      
  
        public string DisplayText;
        public string InsertionText;
        public string Description;        
        public string IconAutomationText;   

        public IntellisenseDefinitionItem(string displayText, string insertionText, string description = null, string iconAutomationText = "IconAutomationText") {
            
            this.DisplayText        = displayText;
            this.InsertionText      = insertionText;
            this.Description        = description;
            this.IconAutomationText = iconAutomationText;

            if(this.InsertionText == null)
                this.InsertionText = this.DisplayText;
        }
             
        public System.Windows.Media.Imaging.BitmapImage IconSource(bool powerShell) { 
            return powerShell ?
                TextHighlighterExtension.BatColorEngine.PowerShellIcon:
                TextHighlighterExtension.BatColorEngine.BatchIconBlack;
        }

        public Completion GetCompletion(bool powerShell = false) {

             return new Completion() { 
                    DisplayText        = this.DisplayText,
                    InsertionText      = this.InsertionText,
                    Description        = this.Description,
                    IconSource         = this.IconSource(powerShell),
                    IconAutomationText = this.IconAutomationText
                };
        }
    }

    public class IntellisenseDefinitionItems : List<IntellisenseDefinitionItem> { 

    }

    public class IntellisenseDefinition : Dictionary<string, IntellisenseDefinitionItems> {

        public bool IsRelevantToTriggerIntellisense(string keyword) {
            if(keyword == null)
                return false;
            return this.ContainsKey(keyword.ToLower());
        }
    }

    public class IntellisenseManager
    {
        const string POWERSHELL_HELP_END_OF_PARAMETER_SECTION             = "--------------------------";
        const string POWERSHELL_HELP_DETECT_NEW_DASH_PARAMETER_DEFINITION = "    -";

        public IntellisenseDefinition BatDefinitions                      = new IntellisenseDefinition();
        public IntellisenseDefinition PowerShellDefinitions               = new IntellisenseDefinition();

        public IntellisenseManager() {

            if(!LoadPowerShellIntellisense()) 
                Util.Utility.MsgBoxError("Cannot load PowerShell Intellisense");

            if(!LoadJsonIntellisense()) 
                Util.Utility.MsgBoxError("Cannot load JSON Intellisense");
        }

        private string ExtractDashParameterHelp(string dashParameter, List<string> helps, int startIndex) {

            var helpText                              = new StringBuilder(1000);
            var i                                     = startIndex;
            var markerCommonParameters                = "<CommonParameters>";
            var makerTemplate                         = "    -{0}";
            var markerToDetectTheHelpForDashParameter = makerTemplate.format(dashParameter);
            var markerToDetectAnyHelpForDashParameter = makerTemplate.format("");
                
            while(true) {
                var line = helps[i];
                if(line.Contains(POWERSHELL_HELP_END_OF_PARAMETER_SECTION))
                    break; // Make sure we can exit
                
                if(line.StartsWith(markerToDetectTheHelpForDashParameter)) { // Look for the start of the help definition of the -parameter
                    helpText.Append(line).AppendLine();                    
                    while(true) { // Read the definition until we find the end def marker
                        line = helps[++i];
                        if(line.StartsWith(markerToDetectAnyHelpForDashParameter) || line.Contains(POWERSHELL_HELP_END_OF_PARAMETER_SECTION) || line.Contains(markerCommonParameters))
                            break;       
                        if(line.Trim().Length > 0)
                            helpText.Append(line).AppendLine();
                    }
                    return helpText.ToString();
                }
                else i++;
            }
            return null;
        }

        private bool LoadPowerShellIntellisense() {
            try {

                var powerShellCommandDefs = DS.Resources.GetTextResource(new System.Text.RegularExpressions.Regex("PS1.GenerateIntellisense.Txt..*gzip$", RegexOptions.IgnoreCase), Assembly.GetExecutingAssembly(), true, DS.TextResourceEncoding.Unicode);

                foreach(var e in powerShellCommandDefs) {

                    var parts       = e.Key.Split('.');
                    var commandName = parts[parts.Length-3].ToLower();
                    var helpLines   = powerShellCommandDefs[e.Key].Split( DS.Array(Environment.NewLine), StringSplitOptions.None).ToList();
               
                    for(var i=0; i<helpLines.Count; i++) {

                        var line = helpLines[i];
                        if(line == "PARAMETERS") {
                       
                            i++;
                            var parametersDefIndex = i;
                            PowerShellDefinitions.Add(commandName, new IntellisenseDefinitionItems());
                        
                            while(i<helpLines.Count) {

                                var line2 = helpLines[i];
                                if(line2.Contains(POWERSHELL_HELP_END_OF_PARAMETER_SECTION)) {
                                    break;
                                }
                                else if(line2.StartsWith(POWERSHELL_HELP_DETECT_NEW_DASH_PARAMETER_DEFINITION)) {

                                    var intellisenseKeyWord = line2.Trim().Split(' ')[0];
                                    if(intellisenseKeyWord.StartsWith("-"))
                                        intellisenseKeyWord = intellisenseKeyWord.Substring(1);

                                    var helpDescription = this.ExtractDashParameterHelp(intellisenseKeyWord, helpLines, parametersDefIndex);
                                    PowerShellDefinitions[commandName].Add(new IntellisenseDefinitionItem(intellisenseKeyWord.ToLower(), intellisenseKeyWord, helpDescription));
                                }
                                i++;
                            }
                            break;
                        }
                    }
                }
                return true;
            }
            catch(System.Exception ex) {
                #if DEBUG
                    System.Diagnostics.Debugger.Break();
                #endif
                return false;
            }
        }
        public bool LoadJsonIntellisense() {
            try {
                var json    = System.IO.File.ReadAllText(this.IntellisenseJsonFile);
                var jsonDef = JObject.Parse(json);
                var jsonBat = jsonDef["BAT"] as JObject;

                // Always there, as the intellissense for goto is computed
                BatDefinitions.Add("goto", new IntellisenseDefinitionItems());

                foreach (var batProperty in jsonBat) {

                    var intellisenseKey = batProperty.Key;
                    var intellisenseDataArray = batProperty.Value as JArray;

                    if(!BatDefinitions.ContainsKey(intellisenseKey))
                    {
                        BatDefinitions.Add(intellisenseKey, new IntellisenseDefinitionItems());
                    }

                    foreach(var definition in intellisenseDataArray) {
                        var d = new IntellisenseDefinitionItem(
                            definition["DisplayText"].ToString(),
                            definition["InsertionText"] == null ? null : definition["InsertionText"].ToString(),
                            definition["Description"] == null ? null : definition["Description"].ToString());
                        
                        BatDefinitions[intellisenseKey].Add(d);
                    }
                }
                return true;
            }
            catch(System.Exception ex) {
                Util.Utility.MsgBoxError(ex.ToString());
            }
            return false;
        }

        private string IntellisenseJsonFile {
            get {
                return Path.Combine(ConfigJson.GetExtensionPath(), "Intellisense.json");
            }
        }
    }
}
