namespace UniverseGen
{
    partial class UniverseGenControl
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
            this.SeedBox = new System.Windows.Forms.TextBox();
            this.starButton1 = new StarControls.StarButton();
            this.starButton2 = new StarControls.StarButton();
            this.SuspendLayout();
            // 
            // SeedBox
            // 
            this.SeedBox.Location = new System.Drawing.Point(123, 28);
            this.SeedBox.Name = "SeedBox";
            this.SeedBox.Size = new System.Drawing.Size(292, 20);
            this.SeedBox.TabIndex = 0;
            this.SeedBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // starButton1
            // 
            this.starButton1.ButText = "Random Seed";
            this.starButton1.Location = new System.Drawing.Point(4, 25);
            this.starButton1.Name = "starButton1";
            this.starButton1.Size = new System.Drawing.Size(113, 23);
            this.starButton1.TabIndex = 1;
            this.starButton1.ClickButton += new System.EventHandler(this.starButton1_ClickButton);
            // 
            // starButton2
            // 
            this.starButton2.ButText = "Generate";
            this.starButton2.Location = new System.Drawing.Point(302, 54);
            this.starButton2.Name = "starButton2";
            this.starButton2.Size = new System.Drawing.Size(113, 23);
            this.starButton2.TabIndex = 2;
            this.starButton2.ClickButton += new System.EventHandler(this.starButton2_ClickButton);
            // 
            // UniverseGenControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.starButton2);
            this.Controls.Add(this.starButton1);
            this.Controls.Add(this.SeedBox);
            this.Name = "UniverseGenControl";
            this.Size = new System.Drawing.Size(781, 487);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SeedBox;
        private StarControls.StarButton starButton1;
        private StarControls.StarButton starButton2;
    }
}
