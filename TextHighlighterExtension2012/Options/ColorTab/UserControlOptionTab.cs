using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextHighlighterPackage;
using System.IO;
using System.Reflection;
using DynamicSugar;
using System.Diagnostics;
using FredericTorres.TextHighlighterPackage.Configuration;
using TextHighlighterColorDefinition;
using Microsoft.VisualBasic;

namespace FredericTorres.TextHighlighterPackage.Options
{
    /// <summary>
    /// http://msdn.microsoft.com/en-us/library/vstudio/bb166195.aspx
    /// </summary>
    public partial class UserControlOptionTab : UserControl
    {
        public OptionPageCustom OptionsPage { get; set; }

        private bool                                        _loading = false;
        private Dictionary<string, System.Drawing.Color>    _drawingColorMap;

        public UserControlOptionTab()
        {
            InitializeComponent();
        }
        
        public void Save() {

            this.UpdateModel(this.cboFileExtension.Text);
            TextHighlighterConfigApi.GlobalColorDefinition.Save();
            TextHighlighterConfigApi.PurgeGlobalColorDefinition();
            TextHighlighterExtension.ConfigurationEngine.Refresh();
        }

        public void UpdateModel(string fileExtension) {

            if(fileExtension==null)
                fileExtension = this.cboFileExtension.Text;

            if(String.IsNullOrEmpty(fileExtension))
                return; // This should not happens, but I guess it does

            var fileColorDefinition  = TextHighlighterConfigApi.GlobalColorDefinition
                                                    .GetFileColorDefinitionSet(ColorDefinition.ToFileExtensionSupported(fileExtension))
                                                    .PopulateFromListView(this.lvColor);
            
            TextHighlighterConfigApi.GlobalColorDefinition
                                    .SetFileColorDefinitionSet(ColorDefinition.ToFileExtensionSupported(fileExtension), fileColorDefinition);
                                    
        }

        public void Initialize() {
            
            cboFileExtension_PreviousSelectedValue = null;

            this._drawingColorMap = TextHighlighterColorDefinition.ColorDefinition.GetDrawingColorMap();

            this.ReloadUI();
            // Populate the combo box with the list of  color
            this.cboColorList.Items.AddRange(TextHighlighterColorDefinition.ColorDefinition.GetMediaColorMap().Keys.ToArray());
        }

        private void ReloadUI()
        {
            this._loading = true;

            this.LoadThemeComboBox();
            this.LoadFileExtensionFromColorDefinitionFile();

            this._loading = false;
        }

        private void LoadFileExtensionFromColorDefinitionFile()
        {
            this.lvColor.Visible = false;
            this.cboColorList.Visible = false;
            this.cboFileExtension.Items.Clear();
            this.cboFileExtension.Items.AddRange(TextHighlighterConfigApi.GlobalColorDefinition.GetFileExtensions().ToArray());
        }

        private void LoadThemeComboBox()
        {            
            this.cboBackGroundColorTheme.Items.Clear();
            this.cboBackGroundColorTheme.Items.AddRange(TextHighlighterConfigApi.GetAvailableThemes().ToArray());

            var theme = TextHighlighterConfigApi.GetBackGroundColorTheme();

            for (var i = 0; i < this.cboBackGroundColorTheme.Items.Count; i++) {

                if (this.cboBackGroundColorTheme.Items[i].ToString() == theme) {

                    this.cboBackGroundColorTheme.SelectedIndex = i; 
                    break;
                }
            }
            this.lvColor.BackColor = (theme == "Dark") ? Color.Black : Color.White;
            this.cboColorList.BackColor = this.lvColor.BackColor;
        }

        private void butEditColorConfig_Click(object sender, EventArgs e)
        {
             TextHighlighterConfigApi.OpenColorDefinitionFileInTextEditor();
        }
        
        
        ListViewItem.ListViewSubItem selectedColorListViewItem;

        private void lvColor_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == System.Windows.Forms.MouseButtons.Left) {

                ListViewHitTestInfo i = this.lvColor.HitTest(e.X, e.Y);
                selectedColorListViewItem = i.SubItem;
                if (selectedColorListViewItem == null)
                    return;

                if (i.SubItem == i.Item.SubItems[2]) {
                    RevertFlagInListViewColor(2);
                    return;
                }
                else if (i.SubItem == i.Item.SubItems[3]) {
                    RevertFlagInListViewColor(3);
                    return;
                }
                                    
                // Support showing a color combobox on the second column only
                if (i.SubItem == i.Item.SubItems[1]) {

                    var colorName = i.SubItem.Text;

                    for(var ii = 0; ii < cboColorList.Items.Count; ii++)
                        if(cboColorList.Items[ii].ToString() == colorName)
                            cboColorList.SelectedIndex = ii;

                    int border = 0;
                    switch (lvColor.BorderStyle) {
                        case BorderStyle.FixedSingle: border = 1; break;
                        case BorderStyle.Fixed3D:     border = 2; break;
                    }

                    int CellWidth  = selectedColorListViewItem.Bounds.Width+1;
                    int CellHeight = selectedColorListViewItem.Bounds.Height-1;
                    int CellLeft   = border + lvColor.Left + i.SubItem.Bounds.Left;
                    int CellTop    = lvColor.Top + i.SubItem.Bounds.Top - 9;
                    // First Column
                    if (i.SubItem == i.Item.SubItems[1])
                        CellWidth = lvColor.Columns[0].Width+1;
            
                    this.cboColorList.Location = new Point(CellLeft, CellTop);
                    this.cboColorList.Size     = new Size(CellWidth, CellHeight);
                    this.cboColorList.Visible  = true;
                    this.cboColorList.BringToFront();
                }
                else {
                    this.cboColorList.Visible  = false;
                }
            }
        }

        private void RevertFlagInListViewColor(int colIndex) {

            if(this.lvColor.SelectedItems.Count > 0) {
                var i = this.lvColor.SelectedItems[0];
                var boldValue = i.SubItems[colIndex ].Text;
                i.SubItems[colIndex ].Text = Util.Utility.Localize( !(i.SubItems[colIndex ].Text == "Yes") );
            }
        }

        private void cboColorList_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape) {

                e.SuppressKeyPress = true;
            } 
        }

        private void cboColorList_DrawItem(object sender, DrawItemEventArgs e)
        {
            var text                         = "";
            text                             = e.Index == -1 ? "" : cboColorList.Items[e.Index].ToString();
            FontFamily family                = cboColorList.Font.FontFamily;
            System.Drawing.Font  myFont      = cboColorList.Font;
            System.Drawing.Color textColor   = System.Drawing.Color.Black;
                
            if(text.In(this._drawingColorMap))
                textColor = this._drawingColorMap[text];

            // Draw the background of the item.
            e.DrawBackground();

            // Create a square filled with the animals color. Vary the size
            // of the rectangle based on the length of the animals name.
            // Rectangle rectangle = new Rectangle(2, e.Bounds.Top+2, e.Bounds.Height, e.Bounds.Height-4);
            // e.Graphics.FillRectangle(new SolidBrush(textColor), rectangle);

            // Draw each string in the array, using a different size, color,
            // and font for each item.
            e.Graphics.DrawString(text, myFont, new SolidBrush(textColor), new RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));

            // Draw the focus rectangle if the mouse hovers over an item.
            e.DrawFocusRectangle();
        }

        private void label2_DoubleClick(object sender, EventArgs e)
        {
            TextHighlighterConfigApi.OpenExtensionFolder();
        }

        private TextHighlighterColorDefinition.FileColorDefinitionSet GetSelectedFileColorDefinitionSet() {

            if(cboFileExtension.SelectedIndex == -1)
                return null;

            return TextHighlighterConfigApi.GetFileColorDefinitionSet(cboFileExtension.Text);
        }

        string cboFileExtension_PreviousSelectedValue = null;

        private void cboFileExtension_SelectionChangeCommitted(object sender, EventArgs e)
        {
             if(cboFileExtension_PreviousSelectedValue != null) {
                this.UpdateModel(cboFileExtension_PreviousSelectedValue);
            }
            var b = this.GetSelectedFileColorDefinitionSet();
            b.PopulateListView(this.lvColor);

            cboFileExtension_PreviousSelectedValue = cboFileExtension.Items[cboFileExtension.SelectedIndex].ToString();

            if(cboFileExtension_PreviousSelectedValue.In("TXT", "LOG")) { 
                this.lvColor.ContextMenuStrip = this.contextMenuForTXT;
            }
            else {
                this.lvColor.ContextMenuStrip = null;
            }

        }

        private void cboBackGroundColorTheme_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.lvColor.Visible                   = false;
            this.cboColorList.Visible              = false;
            cboFileExtension_PreviousSelectedValue = null;
                
            // Force to reload the new Color Definition
            TextHighlighterConfigApi.PurgeGlobalColorDefinition();
            TextHighlighterConfigApi.SetBackGroundColorDefinition(cboBackGroundColorTheme.Text);            
            this.ReloadUI();
        }

        private void cboColorList_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cboColorList.Visible           = false;
            var color                      = cboColorList.Text;
            selectedColorListViewItem.Text = color;
                
            if(color.In(this._drawingColorMap)) {

                // selectedColorListViewItem.ForeColor = this._drawingColorMap[color];
                var lvItem = Util.Utility.ListView.GetListViewItem(color, this.lvColor, 1);
                if(lvItem != null)
                {
                    lvItem.ForeColor = this._drawingColorMap[color];
                    this.lvColor.Refresh();
                }
                else {
                    System.Diagnostics.Debugger.Break();
                }
            }
        }

        private void txtNewRule_Click(object sender, EventArgs e)
        {
            string exp = Microsoft.VisualBasic.Interaction.InputBox("", "New Regular Expression", "");

            if(!string.IsNullOrEmpty(exp)) {

                var b = this.GetSelectedFileColorDefinitionSet();
                b.AddColorDefinition(exp);
                b.PopulateListView(this.lvColor);
                TextHighlighterConfigApi.SetFileColorDefinitionSet(cboFileExtension.Text, b);
                 var ba = this.GetSelectedFileColorDefinitionSet();
            }
        }

        private void txtDeleteRule_Click(object sender, EventArgs e)
        {
            if(this.lvColor.SelectedItems.Count > 0) {

                var itm = this.lvColor.SelectedItems[0];
                var b   = this.GetSelectedFileColorDefinitionSet();
                b.RemoveColorDefinition(itm.Text);
                b.PopulateListView(this.lvColor);
                TextHighlighterConfigApi.SetFileColorDefinitionSet(cboFileExtension.Text, b);
            }
        }

        private void txtUpRule_Click(object sender, EventArgs e)
        {
            var itm = this.lvColor.SelectedItems[0];
            var b   = this.GetSelectedFileColorDefinitionSet();
            b.MoveUp(itm.Text);
            b.PopulateListView(this.lvColor);
            TextHighlighterConfigApi.SetFileColorDefinitionSet(cboFileExtension.Text, b);
        }

        private void txtDownRule_Click(object sender, EventArgs e)
        {
            var itm = this.lvColor.SelectedItems[0];
            var b   = this.GetSelectedFileColorDefinitionSet();
            b.MoveDown(itm.Text);
            b.PopulateListView(this.lvColor);
            TextHighlighterConfigApi.SetFileColorDefinitionSet(cboFileExtension.Text, b);
        }
    }
}
