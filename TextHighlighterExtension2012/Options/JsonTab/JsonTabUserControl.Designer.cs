namespace TextHighlighterPackage
{
    partial class JsonTabUserControl
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
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRelaxModeExplaination = new System.Windows.Forms.Label();
            this.chkJsonRelax = new System.Windows.Forms.CheckBox();
            this.lblInsertClosingCharExplain = new System.Windows.Forms.Label();
            this.chkInsertClosingChar = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblInsertClosingCharExplain);
            this.groupBox1.Controls.Add(this.chkInsertClosingChar);
            this.groupBox1.Controls.Add(this.lblRelaxModeExplaination);
            this.groupBox1.Controls.Add(this.chkJsonRelax);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 285);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "JSON";
            // 
            // lblRelaxModeExplaination
            // 
            this.lblRelaxModeExplaination.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelaxModeExplaination.Location = new System.Drawing.Point(34, 39);
            this.lblRelaxModeExplaination.Name = "lblRelaxModeExplaination";
            this.lblRelaxModeExplaination.Size = new System.Drawing.Size(343, 74);
            this.lblRelaxModeExplaination.TabIndex = 3;
            this.lblRelaxModeExplaination.Text = "In relax mode property do not required";
            // 
            // chkJsonRelax
            // 
            this.chkJsonRelax.AutoSize = true;
            this.chkJsonRelax.Location = new System.Drawing.Point(17, 19);
            this.chkJsonRelax.Name = "chkJsonRelax";
            this.chkJsonRelax.Size = new System.Drawing.Size(83, 17);
            this.chkJsonRelax.TabIndex = 2;
            this.chkJsonRelax.Text = "Relax Mode";
            this.chkJsonRelax.UseVisualStyleBackColor = true;
            // 
            // lblInsertClosingCharExplain
            // 
            this.lblInsertClosingCharExplain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsertClosingCharExplain.Location = new System.Drawing.Point(34, 115);
            this.lblInsertClosingCharExplain.Name = "lblInsertClosingCharExplain";
            this.lblInsertClosingCharExplain.Size = new System.Drawing.Size(343, 74);
            this.lblInsertClosingCharExplain.TabIndex = 5;
            this.lblInsertClosingCharExplain.Text = "In relax mode property do not required";
            // 
            // chkInsertClosingChar
            // 
            this.chkInsertClosingChar.AutoSize = true;
            this.chkInsertClosingChar.Location = new System.Drawing.Point(17, 95);
            this.chkInsertClosingChar.Name = "chkInsertClosingChar";
            this.chkInsertClosingChar.Size = new System.Drawing.Size(114, 17);
            this.chkInsertClosingChar.TabIndex = 4;
            this.chkInsertClosingChar.Text = "Insert Closing Char";
            this.chkInsertClosingChar.UseVisualStyleBackColor = true;
            // 
            // JsonTabUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "JsonTabUserControl";
            this.Size = new System.Drawing.Size(420, 316);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRelaxModeExplaination;
        private System.Windows.Forms.CheckBox chkJsonRelax;
        private System.Windows.Forms.Label lblInsertClosingCharExplain;
        private System.Windows.Forms.CheckBox chkInsertClosingChar;

    }
}
