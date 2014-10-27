using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FredericTorres.TextHighlighterPackage.Configuration;

namespace TextHighlighterPackage
{
    public partial class JsonTabUserControl : UserControl
    {
        public JsonTabPageCustom OptionsPage { get; set; }

        public JsonTabUserControl() {
         
            this.InitializeComponent();
            this.lblRelaxModeExplaination.Text = @"- Double quote are not required to defined property
- Trailing comma are accepted
- // Comment are accepted";

            this.lblInsertClosingCharExplain.Text = @"If checked the following closing characters are automatically inserted when the corresponding opening character(s) is entered
    "", }, ], */            
";
        }

        public void Initialize() {

            this.chkJsonRelax.Checked          = TextHighlighterConfigApi.GetRelaxMode();
            this.chkInsertClosingChar.Checked  = TextHighlighterConfigApi.GetInsertClosingCharacter();
        }

        internal void Save()
        {
            TextHighlighterConfigApi.SetJsonRelaxModeAndClosingChar(this.chkJsonRelax.Checked, this.chkInsertClosingChar.Checked, null);
        }
    }
}
