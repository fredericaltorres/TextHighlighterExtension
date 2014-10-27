using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DynamicSugar;
using Newtonsoft.Json.Linq;

namespace TextHighlighterColorDefinition {
 
    public class FileColorDefinitionSet : TextHighlighterExtension2012.OrderedDictionary <string, ColorDefinitionDetail> {

        public string Extension;

        public FileColorDefinitionSet() {

        }

        public void AddColorDefinition(string exp) {

            this.Add(exp, new ColorDefinitionDetail() { Color = System.Windows.Media.Colors.Wheat, ColorName = "Wheat" });
        }

        public void RemoveColorDefinition(string exp) {

            if(this.ContainsKey(exp)) {
                this.Remove(exp);
            }
        }

        public string ToJSON() {

            var b = new StringBuilder(1000);
            b.Append("{ ").AppendLine();
            foreach(var e in this) {

                // Serialize the key with json.net so it takes care of the weird slash cases
                var key = Newtonsoft.Json.JsonConvert.SerializeObject(e.Key);
                b.AppendFormat(@"  {0} : ""{1}"",", key, this[e.Key].GetColorForJson()).AppendLine();
            }
            b.Append(" }").AppendLine();
            return b.ToString();
        }

        public FileColorDefinitionSet PopulateListView(System.Windows.Forms.ListView lv) {

            lv.Items.Clear();
            lv.Columns.Clear();
            lv.Columns.Add(Extension.In("TXT", "LOG") ? "RegExp" : "Keyword", 200);
            lv.Columns.Add("Name",   200);
            lv.Columns.Add("Bold",    80);
            lv.Columns.Add("Italic",  80);

            foreach(var e in this)
                e.Value.PopulateListView(e.Key, lv);

            lv.Visible = true;
            return this;
        }

        public FileColorDefinitionSet PopulateFromListView(System.Windows.Forms.ListView lv) {

            foreach(System.Windows.Forms.ListViewItem liv in lv.Items) {

                var keyword     = liv.SubItems[0].Text;
                var colorDetail = this[keyword];
                colorDetail.PopulateFromListViewItem(liv);
            }
            return this;
        }
    }
}