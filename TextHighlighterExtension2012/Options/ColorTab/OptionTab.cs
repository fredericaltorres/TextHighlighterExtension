using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextHighlighterPackage
{
    /// <summary>
    /// http://msdn.microsoft.com/en-us/library/vstudio/bb166195.aspx
    /// </summary>
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [Guid("1D9ECCF3-5D2F-4112-9B25-264596873DC9")]
    public class OptionPageCustom : Microsoft.VisualStudio.Shell.DialogPage
    {
        private string optionValue = "alpha";
        private FredericTorres.TextHighlighterPackage.Options.UserControlOptionTab _userControl;

        public string OptionString
        {
            get { return optionValue;  }
            set { optionValue = value; }
        }

        public OptionPageCustom() : base() {

            TextHighlighterColorDefinition.ColorDefinition.ExtractDefaultColorDefinitionJsonFile(TextHighlighterExtension2012.ConfigJson.GetExtensionPath());
        }

        protected override void OnActivate(CancelEventArgs e)
        {
            base.OnActivate(e);        
            _userControl.Initialize();   
        }

        protected override void OnApply(PageApplyEventArgs e)
        {
            base.OnApply(e);
            this._userControl.Save();            
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            FredericTorres.TextHighlighterPackage.Configuration.TextHighlighterConfigApi.PurgeGlobalColorDefinition();
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(
        DesignerSerializationVisibility.Hidden)]
        protected override IWin32Window Window
        {
            get
            {
                _userControl             = new FredericTorres.TextHighlighterPackage.Options.UserControlOptionTab();
                _userControl.OptionsPage = this;
                _userControl.Initialize();
                return _userControl;
            }
        }
    }
}
