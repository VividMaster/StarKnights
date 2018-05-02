namespace EntityEditor
{
    partial class GetAnimName
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.AnimNameBox = new System.Windows.Forms.TextBox();
            this.starButton1 = new StarControls.StarButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anim Name";
            // 
            // AnimNameBox
            // 
            this.AnimNameBox.Location = new System.Drawing.Point(81, 6);
            this.AnimNameBox.Name = "AnimNameBox";
            this.AnimNameBox.Size = new System.Drawing.Size(293, 20);
            this.AnimNameBox.TabIndex = 1;
            // 
            // starButton1
            // 
            this.starButton1.ButText = "Create";
            this.starButton1.Location = new System.Drawing.Point(247, 32);
            this.starButton1.Name = "starButton1";
            this.starButton1.Size = new System.Drawing.Size(113, 23);
            this.starButton1.TabIndex = 2;
            this.starButton1.ClickButton += new System.EventHandler(this.starButton1_ClickButton);
            // 
            // GetAnimName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 59);
            this.Controls.Add(this.starButton1);
            this.Controls.Add(this.AnimNameBox);
            this.Controls.Add(this.label1);
            this.Name = "GetAnimName";
            this.Text = "Animation Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AnimNameBox;
        private StarControls.StarButton starButton1;
    }
}