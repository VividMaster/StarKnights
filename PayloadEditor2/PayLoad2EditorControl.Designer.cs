namespace PayLoad2Editor

{
    partial class PayLoad2EditorControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.PrevBox = new System.Windows.Forms.PictureBox();
            this.CompressCheck = new System.Windows.Forms.CheckBox();
            this.starButton5 = new StarControls.StarButton();
            this.starButton4 = new StarControls.StarButton();
            this.starButton3 = new StarControls.StarButton();
            this.starButton2 = new StarControls.StarButton();
            this.starButton1 = new StarControls.StarButton();
            this.FileBox = new System.Windows.Forms.ListBox();
            this.BrowseFile = new System.Windows.Forms.OpenFileDialog();
            this.BrowseFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.BrowseSave = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PrevBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(462, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Image Preview";
            // 
            // PrevBox
            // 
            this.PrevBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrevBox.Location = new System.Drawing.Point(285, 115);
            this.PrevBox.Name = "PrevBox";
            this.PrevBox.Size = new System.Drawing.Size(170, 149);
            this.PrevBox.TabIndex = 16;
            this.PrevBox.TabStop = false;
            // 
            // CompressCheck
            // 
            this.CompressCheck.AutoSize = true;
            this.CompressCheck.Location = new System.Drawing.Point(484, 311);
            this.CompressCheck.Name = "CompressCheck";
            this.CompressCheck.Size = new System.Drawing.Size(90, 17);
            this.CompressCheck.TabIndex = 15;
            this.CompressCheck.Text = "Compressed?";
            this.CompressCheck.UseVisualStyleBackColor = true;
            // 
            // starButton5
            // 
            this.starButton5.ButText = "Load PayLoad";
            this.starButton5.Location = new System.Drawing.Point(286, 334);
            this.starButton5.Name = "starButton5";
            this.starButton5.Size = new System.Drawing.Size(113, 23);
            this.starButton5.TabIndex = 14;
            // 
            // starButton4
            // 
            this.starButton4.ButText = "Generate PayLoad";
            this.starButton4.Location = new System.Drawing.Point(484, 334);
            this.starButton4.Name = "starButton4";
            this.starButton4.Size = new System.Drawing.Size(148, 23);
            this.starButton4.TabIndex = 13;
            // 
            // starButton3
            // 
            this.starButton3.ButText = "Clear Files";
            this.starButton3.Location = new System.Drawing.Point(286, 86);
            this.starButton3.Name = "starButton3";
            this.starButton3.Size = new System.Drawing.Size(113, 23);
            this.starButton3.TabIndex = 12;
            // 
            // starButton2
            // 
            this.starButton2.ButText = "Add Folder";
            this.starButton2.Location = new System.Drawing.Point(285, 56);
            this.starButton2.Name = "starButton2";
            this.starButton2.Size = new System.Drawing.Size(113, 23);
            this.starButton2.TabIndex = 11;
            // 
            // starButton1
            // 
            this.starButton1.ButText = "Add File";
            this.starButton1.Location = new System.Drawing.Point(285, 26);
            this.starButton1.Name = "starButton1";
            this.starButton1.Size = new System.Drawing.Size(113, 23);
            this.starButton1.TabIndex = 10;
            // 
            // FileBox
            // 
            this.FileBox.FormattingEnabled = true;
            this.FileBox.Location = new System.Drawing.Point(14, 14);
            this.FileBox.Name = "FileBox";
            this.FileBox.Size = new System.Drawing.Size(265, 394);
            this.FileBox.TabIndex = 9;
            // 
            // BrowseFile
            // 
            this.BrowseFile.FileName = "openFileDialog1";
            // 
            // PayLoad2EditorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrevBox);
            this.Controls.Add(this.CompressCheck);
            this.Controls.Add(this.starButton5);
            this.Controls.Add(this.starButton4);
            this.Controls.Add(this.starButton3);
            this.Controls.Add(this.starButton2);
            this.Controls.Add(this.starButton1);
            this.Controls.Add(this.FileBox);
            this.Name = "PayLoad2EditorControl";
            this.Size = new System.Drawing.Size(857, 540);
            ((System.ComponentModel.ISupportInitialize)(this.PrevBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PrevBox;
        private System.Windows.Forms.CheckBox CompressCheck;
        private StarControls.StarButton starButton5;
        private StarControls.StarButton starButton4;
        private StarControls.StarButton starButton3;
        private StarControls.StarButton starButton2;
        private StarControls.StarButton starButton1;
        private System.Windows.Forms.ListBox FileBox;
        private System.Windows.Forms.OpenFileDialog BrowseFile;
        private System.Windows.Forms.FolderBrowserDialog BrowseFolder;
        private System.Windows.Forms.SaveFileDialog BrowseSave;
    }
}
