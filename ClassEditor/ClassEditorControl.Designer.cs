namespace ClassEditor
{
    partial class ClassEditorControl
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
            this.ClassBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AttackDial = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DefenseDial = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.TechDial = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.IQDial = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.CommDial = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.UpperClassBox = new System.Windows.Forms.TextBox();
            this.starButton3 = new StarControls.StarButton();
            this.starButton2 = new StarControls.StarButton();
            this.starButton1 = new StarControls.StarButton();
            this.IconBox = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.starButton4 = new StarControls.StarButton();
            this.BrowseFile = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.AttackDial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DefenseDial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TechDial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IQDial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommDial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ClassBox
            // 
            this.ClassBox.Location = new System.Drawing.Point(85, 48);
            this.ClassBox.Name = "ClassBox";
            this.ClassBox.Size = new System.Drawing.Size(198, 20);
            this.ClassBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Class Name";
            // 
            // AttackDial
            // 
            this.AttackDial.DecimalPlaces = 2;
            this.AttackDial.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.AttackDial.Location = new System.Drawing.Point(85, 78);
            this.AttackDial.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AttackDial.Name = "AttackDial";
            this.AttackDial.Size = new System.Drawing.Size(120, 20);
            this.AttackDial.TabIndex = 5;
            this.AttackDial.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Attack";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Defense";
            // 
            // DefenseDial
            // 
            this.DefenseDial.DecimalPlaces = 2;
            this.DefenseDial.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.DefenseDial.Location = new System.Drawing.Point(85, 106);
            this.DefenseDial.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DefenseDial.Name = "DefenseDial";
            this.DefenseDial.Size = new System.Drawing.Size(120, 20);
            this.DefenseDial.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tech";
            // 
            // TechDial
            // 
            this.TechDial.DecimalPlaces = 2;
            this.TechDial.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.TechDial.Location = new System.Drawing.Point(85, 132);
            this.TechDial.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TechDial.Name = "TechDial";
            this.TechDial.Size = new System.Drawing.Size(120, 20);
            this.TechDial.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "IQ";
            // 
            // IQDial
            // 
            this.IQDial.DecimalPlaces = 2;
            this.IQDial.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.IQDial.Location = new System.Drawing.Point(85, 158);
            this.IQDial.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.IQDial.Name = "IQDial";
            this.IQDial.Size = new System.Drawing.Size(120, 20);
            this.IQDial.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Comm";
            // 
            // CommDial
            // 
            this.CommDial.DecimalPlaces = 2;
            this.CommDial.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.CommDial.Location = new System.Drawing.Point(85, 184);
            this.CommDial.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CommDial.Name = "CommDial";
            this.CommDial.Size = new System.Drawing.Size(120, 20);
            this.CommDial.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Upper Class";
            // 
            // UpperClassBox
            // 
            this.UpperClassBox.Location = new System.Drawing.Point(85, 16);
            this.UpperClassBox.Name = "UpperClassBox";
            this.UpperClassBox.Size = new System.Drawing.Size(198, 20);
            this.UpperClassBox.TabIndex = 15;
            // 
            // starButton3
            // 
            this.starButton3.ButText = "Save";
            this.starButton3.Location = new System.Drawing.Point(379, 74);
            this.starButton3.Name = "starButton3";
            this.starButton3.Size = new System.Drawing.Size(113, 23);
            this.starButton3.TabIndex = 4;
            this.starButton3.ClickButton += new System.EventHandler(this.starButton3_ClickButton);
            // 
            // starButton2
            // 
            this.starButton2.ButText = "Load";
            this.starButton2.Location = new System.Drawing.Point(379, 45);
            this.starButton2.Name = "starButton2";
            this.starButton2.Size = new System.Drawing.Size(113, 23);
            this.starButton2.TabIndex = 3;
            // 
            // starButton1
            // 
            this.starButton1.ButText = "New";
            this.starButton1.Location = new System.Drawing.Point(379, 16);
            this.starButton1.Name = "starButton1";
            this.starButton1.Size = new System.Drawing.Size(113, 23);
            this.starButton1.TabIndex = 2;
            this.starButton1.ClickButton += new System.EventHandler(this.starButton1_ClickButton);
            this.starButton1.Load += new System.EventHandler(this.starButton1_Load);
            // 
            // IconBox
            // 
            this.IconBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.IconBox.Location = new System.Drawing.Point(379, 106);
            this.IconBox.Name = "IconBox";
            this.IconBox.Size = new System.Drawing.Size(113, 103);
            this.IconBox.TabIndex = 17;
            this.IconBox.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(345, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Icon";
            // 
            // starButton4
            // 
            this.starButton4.ButText = "Select Image";
            this.starButton4.Location = new System.Drawing.Point(379, 216);
            this.starButton4.Name = "starButton4";
            this.starButton4.Size = new System.Drawing.Size(113, 23);
            this.starButton4.TabIndex = 19;
            this.starButton4.ClickButton += new System.EventHandler(this.starButton4_ClickButton);
            // 
            // BrowseFile
            // 
            this.BrowseFile.DefaultExt = "png";
            // 
            // ClassEditorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.starButton4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.IconBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.UpperClassBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CommDial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IQDial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TechDial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DefenseDial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AttackDial);
            this.Controls.Add(this.starButton3);
            this.Controls.Add(this.starButton2);
            this.Controls.Add(this.starButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClassBox);
            this.Name = "ClassEditorControl";
            this.Size = new System.Drawing.Size(508, 375);
            this.Load += new System.EventHandler(this.ClassEditorControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AttackDial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DefenseDial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TechDial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IQDial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommDial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ClassBox;
        private System.Windows.Forms.Label label1;
        private StarControls.StarButton starButton1;
        private StarControls.StarButton starButton2;
        private StarControls.StarButton starButton3;
        private System.Windows.Forms.NumericUpDown AttackDial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown DefenseDial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown TechDial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown IQDial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown CommDial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox UpperClassBox;
        private System.Windows.Forms.PictureBox IconBox;
        private System.Windows.Forms.Label label8;
        private StarControls.StarButton starButton4;
        private System.Windows.Forms.OpenFileDialog BrowseFile;
    }
}
