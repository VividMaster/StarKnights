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
        private void InitializeComponent()
        {
            this.BrowseFile = new System.Windows.Forms.OpenFileDialog();
            this.BrowseFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.BrowseSave = new System.Windows.Forms.SaveFileDialog();
            this.FileBox = new System.Windows.Forms.ListBox();
            this.starButton1 = new StarControls.StarButton();
            this.starButton2 = new StarControls.StarButton();
            this.starButton3 = new StarControls.StarButton();
            this.starButton4 = new StarControls.StarButton();
            this.starButton5 = new StarControls.StarButton();
            this.CompressCheck = new System.Windows.Forms.CheckBox();
            this.PrevBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PrevBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BrowseFile
            // 
            this.BrowseFile.FileName = "openFileDialog1";
            // 
            // FileBox
            // 
            this.FileBox.FormattingEnabled = true;
            this.FileBox.Location = new System.Drawing.Point(2, 0);
            this.FileBox.Name = "FileBox";
            this.FileBox.Size = new System.Drawing.Size(265, 446);
            this.FileBox.TabIndex = 0;
            this.FileBox.SelectedIndexChanged += new System.EventHandler(this.FileBox_SelectedIndexChanged);
            // 
            // starButton1
            // 
            this.starButton1.ButText = "Add File";
            this.starButton1.Location = new System.Drawing.Point(273, 12);
            this.starButton1.Name = "starButton1";
            this.starButton1.Size = new System.Drawing.Size(113, 23);
            this.starButton1.TabIndex = 1;
            this.starButton1.ClickButton += new System.EventHandler(this.starButton1_ClickButton);
            // 
            // starButton2
            // 
            this.starButton2.ButText = "Add Folder";
            this.starButton2.Location = new System.Drawing.Point(273, 42);
            this.starButton2.Name = "starButton2";
            this.starButton2.Size = new System.Drawing.Size(113, 23);
            this.starButton2.TabIndex = 2;
            this.starButton2.ClickButton += new System.EventHandler(this.starButton2_ClickButton);
            // 
            // starButton3
            // 
            this.starButton3.ButText = "Clear Files";
            this.starButton3.Location = new System.Drawing.Point(274, 72);
            this.starButton3.Name = "starButton3";
            this.starButton3.Size = new System.Drawing.Size(113, 23);
            this.starButton3.TabIndex = 3;
            this.starButton3.ClickButton += new System.EventHandler(this.starButton3_ClickButton);
            // 
            // starButton4
            // 
            this.starButton4.ButText = "Generate PayLoad";
            this.starButton4.Location = new System.Drawing.Point(479, 286);
            this.starButton4.Name = "starButton4";
            this.starButton4.Size = new System.Drawing.Size(148, 23);
            this.starButton4.TabIndex = 4;
            this.starButton4.ClickButton += new System.EventHandler(this.starButton4_ClickButton);
            // 
            // starButton5
            // 
            this.starButton5.ButText = "Load PayLoad";
            this.starButton5.Location = new System.Drawing.Point(281, 286);
            this.starButton5.Name = "starButton5";
            this.starButton5.Size = new System.Drawing.Size(113, 23);
            this.starButton5.TabIndex = 5;
            this.starButton5.ClickButton += new System.EventHandler(this.starButton5_ClickButton);
            // 
            // CompressCheck
            // 
            this.CompressCheck.AutoSize = true;
            this.CompressCheck.Location = new System.Drawing.Point(479, 263);
            this.CompressCheck.Name = "CompressCheck";
            this.CompressCheck.Size = new System.Drawing.Size(90, 17);
            this.CompressCheck.TabIndex = 6;
            this.CompressCheck.Text = "Compressed?";
            this.CompressCheck.UseVisualStyleBackColor = true;
            // 
            // PrevBox
            // 
            this.PrevBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrevBox.Location = new System.Drawing.Point(273, 101);
            this.PrevBox.Name = "PrevBox";
            this.PrevBox.Size = new System.Drawing.Size(170, 149);
            this.PrevBox.TabIndex = 7;
            this.PrevBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(450, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Image Preview";
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
            this.Size = new System.Drawing.Size(800, 450);
            ((System.ComponentModel.ISupportInitialize)(this.PrevBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
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
