using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityEditor
{
    public partial class GetAnimName : Form
    {
        public GetAnimName()
        {
            InitializeComponent();
        }

        private void starButton1_ClickButton(object sender, EventArgs e)
        {
            if (AnimNameBox.Text.Length < 1)
            {
                MessageBox.Show("Name not set.");
                return;
            }
            AnimEditorControl.Main.AddAnim(AnimNameBox.Text);
        }
    }
}
