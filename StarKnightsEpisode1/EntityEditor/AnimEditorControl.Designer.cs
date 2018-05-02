namespace EntityEditor
{
    partial class AnimEditorControl
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
            this.AnimBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.starButton1 = new StarControls.StarButton();
            this.starButton2 = new StarControls.StarButton();
            this.starButton3 = new StarControls.StarButton();
            this.starButton4 = new StarControls.StarButton();
            this.AnimSelectBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AnimFramesView = new System.Windows.Forms.ListView();
            this.starButton5 = new StarControls.StarButton();
            this.BrowseFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // AnimBox
            // 
            this.AnimBox.Location = new System.Drawing.Point(67, 18);
            this.AnimBox.Name = "AnimBox";
            this.AnimBox.Size = new System.Drawing.Size(278, 20);
            this.AnimBox.TabIndex = 0;
            this.AnimBox.TextChanged += new System.EventHandler(this.AnimBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "AnimSet";
            // 
            // starButton1
            // 
            this.starButton1.ButText = "New";
            this.starButton1.Location = new System.Drawing.Point(474, 10);
            this.starButton1.Name = "starButton1";
            this.starButton1.Size = new System.Drawing.Size(113, 23);
            this.starButton1.TabIndex = 2;
            this.starButton1.ClickButton += new System.EventHandler(this.starButton1_ClickButton);
            // 
            // starButton2
            // 
            this.starButton2.ButText = "Save";
            this.starButton2.Location = new System.Drawing.Point(474, 40);
            this.starButton2.Name = "starButton2";
            this.starButton2.Size = new System.Drawing.Size(113, 23);
            this.starButton2.TabIndex = 3;
            // 
            // starButton3
            // 
            this.starButton3.ButText = "Load";
            this.starButton3.Location = new System.Drawing.Point(474, 70);
            this.starButton3.Name = "starButton3";
            this.starButton3.Size = new System.Drawing.Size(113, 23);
            this.starButton3.TabIndex = 4;
            // 
            // starButton4
            // 
            this.starButton4.ButText = "New Anim";
            this.starButton4.Location = new System.Drawing.Point(232, 44);
            this.starButton4.Name = "starButton4";
            this.starButton4.Size = new System.Drawing.Size(113, 23);
            this.starButton4.TabIndex = 5;
            this.starButton4.ClickButton += new System.EventHandler(this.starButton4_ClickButton);
            // 
            // AnimSelectBox
            // 
            this.AnimSelectBox.FormattingEnabled = true;
            this.AnimSelectBox.Location = new System.Drawing.Point(67, 45);
            this.AnimSelectBox.Name = "AnimSelectBox";
            this.AnimSelectBox.Size = new System.Drawing.Size(159, 21);
            this.AnimSelectBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Anim";
            // 
            // AnimFramesView
            // 
            this.AnimFramesView.Location = new System.Drawing.Point(67, 72);
            this.AnimFramesView.Name = "AnimFramesView";
            this.AnimFramesView.Size = new System.Drawing.Size(278, 232);
            this.AnimFramesView.TabIndex = 8;
            this.AnimFramesView.UseCompatibleStateImageBehavior = false;
            // 
            // starButton5
            // 
            this.starButton5.ButText = "Add Frame";
            this.starButton5.Location = new System.Drawing.Point(351, 281);
            this.starButton5.Name = "starButton5";
            this.starButton5.Size = new System.Drawing.Size(113, 23);
            this.starButton5.TabIndex = 9;
            this.starButton5.ClickButton += new System.EventHandler(this.starButton5_ClickButton);
            // 
            // BrowseFile
            // 
            this.BrowseFile.Multiselect = true;
            // 
            // AnimEditorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.starButton5);
            this.Controls.Add(this.AnimFramesView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AnimSelectBox);
            this.Controls.Add(this.starButton4);
            this.Controls.Add(this.starButton3);
            this.Controls.Add(this.starButton2);
            this.Controls.Add(this.starButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AnimBox);
            this.Name = "AnimEditorControl";
            this.Size = new System.Drawing.Size(631, 327);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AnimBox;
        private System.Windows.Forms.Label label1;
        private StarControls.StarButton starButton1;
        private StarControls.StarButton starButton2;
        private StarControls.StarButton starButton3;
        private StarControls.StarButton starButton4;
        private System.Windows.Forms.ComboBox AnimSelectBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView AnimFramesView;
        private StarControls.StarButton starButton5;
        private System.Windows.Forms.OpenFileDialog BrowseFile;
    }
}
