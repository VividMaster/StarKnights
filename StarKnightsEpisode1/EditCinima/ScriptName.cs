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
    public partial class ScriptName : Form
    {
        public ScriptName()
        {
            InitializeComponent();
        }
        public bool Done = false;
        public string Name = "";
        private void button1_Click(object sender, EventArgs e)
        {
            Name = textBox1.Text;
            Done = true;
            EditCine.CreateScript(Name);
            this.Close();
        }
    }
}
