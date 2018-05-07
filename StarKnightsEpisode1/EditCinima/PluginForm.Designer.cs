namespace EditCinima
{
    partial class PluginForm
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
            this.PlugPanel = new System.Windows.Forms.Panel();
            this.starButton1 = new StarControls.StarButton();
            this.SuspendLayout();
            // 
            // PlugPanel
            // 
            this.PlugPanel.Location = new System.Drawing.Point(13, 30);
            this.PlugPanel.Name = "PlugPanel";
            this.PlugPanel.Size = new System.Drawing.Size(775, 408);
            this.PlugPanel.TabIndex = 0;
            // 
            // starButton1
            // 
            this.starButton1.ButText = "Return To UI";
            this.starButton1.Location = new System.Drawing.Point(13, 1);
            this.starButton1.Name = "starButton1";
            this.starButton1.Size = new System.Drawing.Size(113, 23);
            this.starButton1.TabIndex = 1;
            this.starButton1.ClickButton += new System.EventHandler(this.starButton1_ClickButton);
            // 
            // PluginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.starButton1);
            this.Controls.Add(this.PlugPanel);
            this.Name = "PluginForm";
            this.Text = "PluginForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PluginForm_FormClosing);
            this.Load += new System.EventHandler(this.PluginForm_Load);
            this.SizeChanged += new System.EventHandler(this.PluginForm_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PlugPanel;
        private StarControls.StarButton starButton1;
    }
}