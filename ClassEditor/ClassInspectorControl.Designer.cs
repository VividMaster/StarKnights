namespace ClassEditor
{
    partial class ClassInspectorControl
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
            this.ClassView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.UpperClassBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CommDial = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.IQDial = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.TechDial = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.DefenseDial = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.AttackDial = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.ClassBox = new System.Windows.Forms.TextBox();
            this.CheckChanges = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.IconBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CommDial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IQDial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TechDial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DefenseDial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttackDial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ClassView
            // 
            this.ClassView.Location = new System.Drawing.Point(4, 4);
            this.ClassView.Name = "ClassView";
            this.ClassView.Size = new System.Drawing.Size(196, 347);
            this.ClassView.TabIndex = 0;
            this.ClassView.UseCompatibleStateImageBehavior = false;
            this.ClassView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ClassView_ItemSelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Classes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(218, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Upper Class";
            // 
            // UpperClassBox
            // 
            this.UpperClassBox.Location = new System.Drawing.Point(287, 28);
            this.UpperClassBox.Name = "UpperClassBox";
            this.UpperClassBox.ReadOnly = true;
            this.UpperClassBox.Size = new System.Drawing.Size(198, 20);
            this.UpperClassBox.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 28;
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
            this.CommDial.Location = new System.Drawing.Point(287, 196);
            this.CommDial.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CommDial.Name = "CommDial";
            this.CommDial.ReadOnly = true;
            this.CommDial.Size = new System.Drawing.Size(120, 20);
            this.CommDial.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 26;
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
            this.IQDial.Location = new System.Drawing.Point(287, 170);
            this.IQDial.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.IQDial.Name = "IQDial";
            this.IQDial.ReadOnly = true;
            this.IQDial.Size = new System.Drawing.Size(120, 20);
            this.IQDial.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 24;
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
            this.TechDial.Location = new System.Drawing.Point(287, 144);
            this.TechDial.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TechDial.Name = "TechDial";
            this.TechDial.ReadOnly = true;
            this.TechDial.Size = new System.Drawing.Size(120, 20);
            this.TechDial.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 22;
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
            this.DefenseDial.Location = new System.Drawing.Point(287, 118);
            this.DefenseDial.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DefenseDial.Name = "DefenseDial";
            this.DefenseDial.ReadOnly = true;
            this.DefenseDial.Size = new System.Drawing.Size(120, 20);
            this.DefenseDial.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Attack";
            // 
            // AttackDial
            // 
            this.AttackDial.DecimalPlaces = 2;
            this.AttackDial.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.AttackDial.Location = new System.Drawing.Point(287, 90);
            this.AttackDial.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AttackDial.Name = "AttackDial";
            this.AttackDial.ReadOnly = true;
            this.AttackDial.Size = new System.Drawing.Size(120, 20);
            this.AttackDial.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(218, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Class Name";
            // 
            // ClassBox
            // 
            this.ClassBox.Location = new System.Drawing.Point(287, 60);
            this.ClassBox.Name = "ClassBox";
            this.ClassBox.ReadOnly = true;
            this.ClassBox.Size = new System.Drawing.Size(198, 20);
            this.ClassBox.TabIndex = 17;
            // 
            // CheckChanges
            // 
            this.CheckChanges.Enabled = true;
            this.CheckChanges.Interval = 2000;
            this.CheckChanges.Tick += new System.EventHandler(this.CheckChanges_Tick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(419, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Icon";
            // 
            // IconBox
            // 
            this.IconBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.IconBox.Location = new System.Drawing.Point(453, 109);
            this.IconBox.Name = "IconBox";
            this.IconBox.Size = new System.Drawing.Size(113, 103);
            this.IconBox.TabIndex = 31;
            this.IconBox.TabStop = false;
            // 
            // ClassInspectorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label9);
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
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ClassBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClassView);
            this.Name = "ClassInspectorControl";
            this.Size = new System.Drawing.Size(579, 354);
            this.Load += new System.EventHandler(this.ClassInspectorControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CommDial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IQDial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TechDial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DefenseDial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttackDial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ClassView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox UpperClassBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown CommDial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown IQDial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown TechDial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown DefenseDial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown AttackDial;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ClassBox;
        private System.Windows.Forms.Timer CheckChanges;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox IconBox;
    }
}
