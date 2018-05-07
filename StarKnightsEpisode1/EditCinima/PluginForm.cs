using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditCinima
{
    public partial class PluginForm : Form
    {
        public Control PluginControl = null;
        public Panel PlugPan;
        public PluginForm()
        {
            InitializeComponent();
            PlugPan = PlugPanel;
        }

        private void PluginForm_Load(object sender, EventArgs e)
        {

        }

        private void PluginForm_SizeChanged(object sender, EventArgs e)
        {
            PlugPanel.Width = Width - 10;
            PlugPanel.Height = Height - 10;
        }

        private void starButton1_ClickButton(object sender, EventArgs e)
        {
            TabPage np = new TabPage(Text);
            np.Controls.Add(PluginControl);
            EditCine.UIP.Controls.Add(np);
            backed = true;
            this.Close();
            
        }
        public bool backed = false;
        private void PluginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (backed) return;
            TabPage np = new TabPage(Text);
            np.Controls.Add(PluginControl);
            EditCine.UIP.Controls.Add(np);
            //this.Close();
           // e
        }
    }
}
