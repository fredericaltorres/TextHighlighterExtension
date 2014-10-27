namespace FredericTorres.TextHighlighterPackage.Options
{
    partial class UserControlOptionTab
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.butEditColorConfig = new System.Windows.Forms.Button();
            this.cboBackGroundColorTheme = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvColor = new System.Windows.Forms.ListView();
            this.cboFileExtension = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboColorList = new System.Windows.Forms.ComboBox();
            this.contextMenuForTXT = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtNewRule = new System.Windows.Forms.ToolStripMenuItem();
            this.txtDeleteRule = new System.Windows.Forms.ToolStripMenuItem();
            this.txtUpRule = new System.Windows.Forms.ToolStripMenuItem();
            this.txtDownRule = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.contextMenuForTXT.SuspendLayout();
            this.SuspendLayout();
            // 
            // butEditColorConfig
            // 
            this.butEditColorConfig.Location = new System.Drawing.Point(359, 288);
            this.butEditColorConfig.Name = "butEditColorConfig";
            this.butEditColorConfig.Size = new System.Drawing.Size(62, 23);
            this.butEditColorConfig.TabIndex = 2;
            this.butEditColorConfig.Text = "Edit File";
            this.butEditColorConfig.UseVisualStyleBackColor = true;
            this.butEditColorConfig.Click += new System.EventHandler(this.butEditColorConfig_Click);
            // 
            // cboBackGroundColorTheme
            // 
            this.cboBackGroundColorTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBackGroundColorTheme.FormattingEnabled = true;
            this.cboBackGroundColorTheme.Location = new System.Drawing.Point(140, 15);
            this.cboBackGroundColorTheme.Name = "cboBackGroundColorTheme";
            this.cboBackGroundColorTheme.Size = new System.Drawing.Size(245, 21);
            this.cboBackGroundColorTheme.TabIndex = 4;
            this.cboBackGroundColorTheme.SelectionChangeCommitted += new System.EventHandler(this.cboBackGroundColorTheme_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Background Color Theme:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvColor);
            this.groupBox1.Controls.Add(this.cboFileExtension);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboBackGroundColorTheme);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, -5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 285);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // lvColor
            // 
            this.lvColor.FullRowSelect = true;
            this.lvColor.GridLines = true;
            this.lvColor.Location = new System.Drawing.Point(95, 67);
            this.lvColor.MultiSelect = false;
            this.lvColor.Name = "lvColor";
            this.lvColor.Size = new System.Drawing.Size(290, 168);
            this.lvColor.TabIndex = 8;
            this.lvColor.UseCompatibleStateImageBehavior = false;
            this.lvColor.View = System.Windows.Forms.View.Details;
            this.lvColor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lvColor_MouseUp);
            // 
            // cboFileExtension
            // 
            this.cboFileExtension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFileExtension.FormattingEnabled = true;
            this.cboFileExtension.Location = new System.Drawing.Point(140, 40);
            this.cboFileExtension.Name = "cboFileExtension";
            this.cboFileExtension.Size = new System.Drawing.Size(245, 21);
            this.cboFileExtension.TabIndex = 6;
            this.cboFileExtension.SelectionChangeCommitted += new System.EventHandler(this.cboFileExtension_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "File Extension:";
            this.label2.DoubleClick += new System.EventHandler(this.label2_DoubleClick);
            // 
            // cboColorList
            // 
            this.cboColorList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboColorList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColorList.FormattingEnabled = true;
            this.cboColorList.Location = new System.Drawing.Point(279, 286);
            this.cboColorList.Name = "cboColorList";
            this.cboColorList.Size = new System.Drawing.Size(45, 21);
            this.cboColorList.TabIndex = 9;
            this.cboColorList.Visible = false;
            this.cboColorList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cboColorList_DrawItem);
            this.cboColorList.SelectionChangeCommitted += new System.EventHandler(this.cboColorList_SelectionChangeCommitted);
            this.cboColorList.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cboColorList_KeyUp);
            // 
            // contextMenuForTXT
            // 
            this.contextMenuForTXT.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtNewRule,
            this.txtDeleteRule,
            this.txtUpRule,
            this.txtDownRule});
            this.contextMenuForTXT.Name = "contextMenuStrip1";
            this.contextMenuForTXT.Size = new System.Drawing.Size(153, 146);
            // 
            // txtNewRule
            // 
            this.txtNewRule.Name = "txtNewRule";
            this.txtNewRule.Size = new System.Drawing.Size(152, 30);
            this.txtNewRule.Text = "New ";
            this.txtNewRule.Click += new System.EventHandler(this.txtNewRule_Click);
            // 
            // txtDeleteRule
            // 
            this.txtDeleteRule.Name = "txtDeleteRule";
            this.txtDeleteRule.Size = new System.Drawing.Size(152, 30);
            this.txtDeleteRule.Text = "Delete";
            this.txtDeleteRule.Click += new System.EventHandler(this.txtDeleteRule_Click);
            // 
            // txtUpRule
            // 
            this.txtUpRule.Name = "txtUpRule";
            this.txtUpRule.Size = new System.Drawing.Size(152, 30);
            this.txtUpRule.Text = "Up";
            this.txtUpRule.Click += new System.EventHandler(this.txtUpRule_Click);
            // 
            // txtDownRule
            // 
            this.txtDownRule.Name = "txtDownRule";
            this.txtDownRule.Size = new System.Drawing.Size(152, 30);
            this.txtDownRule.Text = "Down";
            this.txtDownRule.Click += new System.EventHandler(this.txtDownRule_Click);
            // 
            // UserControlOptionTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cboColorList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.butEditColorConfig);
            this.Name = "UserControlOptionTab";
            this.Size = new System.Drawing.Size(433, 314);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuForTXT.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butEditColorConfig;
        private System.Windows.Forms.ComboBox cboBackGroundColorTheme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboFileExtension;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvColor;
        private System.Windows.Forms.ComboBox cboColorList;
        private System.Windows.Forms.ContextMenuStrip contextMenuForTXT;
        private System.Windows.Forms.ToolStripMenuItem txtNewRule;
        private System.Windows.Forms.ToolStripMenuItem txtDeleteRule;
        private System.Windows.Forms.ToolStripMenuItem txtUpRule;
        private System.Windows.Forms.ToolStripMenuItem txtDownRule;
    }
}
