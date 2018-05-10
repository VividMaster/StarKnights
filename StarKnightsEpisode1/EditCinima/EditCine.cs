using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using StarEngine;
using StarEngine.App;
using StarEngine.Draw;
using StarEngine.FX;
using StarEngine.FXS;
using StarEngine.Input;
using StarEngine.Scene;
using StarEngine.Tex;
using StarEngine.Util;
using StarEngine.VFX;
using StarEngine.Script;
using StarEngine.Reflect;
using System.Reflection;
using StarEngine.Archive;
using StarKnightGameplay;
namespace EditCinima
{
    public partial class EditCine : Form
    {
        public EditCine()
        {
            InitializeComponent();
            SceneTree.ContextMenuStrip = SceneTreeMenu;
            LoadDefaults();
            Main = this;
            UIP = UI2;
            DoubleBuffered = true;

            mxi = 0;
            myi = 0;
            mzi = 0;
            mdrag = 0.65f;
        }
      

        private void Visual_Resize(object sender, EventArgs e)
        {
         
        }

     

        private void Visual_Paint(object sender, PaintEventArgs e)
        {
        
        }

      

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       
     

     
     
     
    

    }
}
