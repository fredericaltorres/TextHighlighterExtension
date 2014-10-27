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
    [Guid("1D9ECCF3-5D2F-4112-9B25-264596873DC8")]
    public class JsonTabPageCustom : Microsoft.VisualStudio.Shell.DialogPage
    {
        private TextHighlighterPackage.JsonTabUserControl _userControl;

        public JsonTabPageCustom() : base() {

        }

        protected override void OnActivate(CancelEventArgs e)
        {
            base.OnActivate(e);        
            _userControl.Initialize();   
        }

        protected override void OnApply(PageApplyEventArgs e)
        {
            base.OnApply(e);
            _userControl.Save();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        protected override IWin32Window Window
        {
            get
            {
                _userControl = new TextHighlighterPackage.JsonTabUserControl();
                // _userControl.OptionsPage = this;
                _userControl.Initialize();
                return _userControl;
            }
        }
    }
}
