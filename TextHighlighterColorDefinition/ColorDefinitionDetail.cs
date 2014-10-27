using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DynamicSugar;
using Newtonsoft.Json.Linq;

namespace TextHighlighterColorDefinition
{
    public class ColorDefinitionDetail {
         
        public bool Italic { get; set; }
        public bool Bold { get; set; }
        public System.Windows.Media.Color Color { get; set; }
        public string ColorName { get; set; }

        public ColorDefinitionDetail() {

            this.Color = System.Windows.Media.Colors.AliceBlue;
        }
        public string GetColorForJson() {

            var prefix = "";

            if(this.Bold && this.Italic)
                prefix = "bolditalic.";
            else if(this.Bold)
                prefix = "bold.";
            else if(this.Italic)
                prefix = "italic.";

            var s = "{0}{1}".format(prefix, this.ColorName);
            return s;
        }
        public void PopulateListView(string keyword, System.Windows.Forms.ListView lv) {

            var item = lv.Items.Add(keyword);
            item.SubItems.Add(this.ColorName);
            item.SubItems.Add(Util.Utility.Localize(this.Bold));
            item.SubItems.Add(Util.Utility.Localize(this.Italic));

            item.ForeColor = ColorDefinition.GetDrawingColor(this.Color);            
        }
        public void PopulateFromListViewItem(System.Windows.Forms.ListViewItem lvi) {

            this.ColorName = lvi.SubItems[1].Text;
            this.Bold      = lvi.SubItems[2].Text == "Yes";
            this.Italic    = lvi.SubItems[3].Text == "Yes";
        }
    }
}
