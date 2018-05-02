using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StarKnightGameplay;
using System.IO;
namespace ClassEditor
{
    public partial class ClassEditorControl : UserControl
    {
        public ClassEditorControl()
        {
            InitializeComponent();
            EditClass = new CharClass();
            FromClass();
            GameInfo.LoadClasses();
            Console.WriteLine("Classes:" + GameInfo.Classes.Count());
        }

        public Bitmap ClassIcon = null;

        public void FromClass()
        {
            AttackDial.Value = (decimal)EditClass.Attack;
            DefenseDial.Value = (decimal)EditClass.Defense;
            TechDial.Value = (decimal)EditClass.Tech;
            IQDial.Value = (decimal)EditClass.IQ;
            CommDial.Value = (decimal)EditClass.Comm;
            ClassBox.Text = EditClass.Name;
            UpperClassBox.Text = EditClass.UpperClass;
            IconBox.Image = EditClass.Icon;
        }

        public void ToClass()
        {

            EditClass.Attack = (float)AttackDial.Value;
            EditClass.Defense = (float)DefenseDial.Value;
            EditClass.Tech = (float)TechDial.Value;
            EditClass.IQ = (float)IQDial.Value;
            EditClass.Comm = (float)CommDial.Value;
            EditClass.Name = ClassBox.Text;
            EditClass.UpperClass = UpperClassBox.Text;
            EditClass.Icon = ClassIcon;
        }

        public static CharClass EditClass
        {
            get;
            set;
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ClassEditorControl_Load(object sender, EventArgs e)
        {

        }

        private void starButton1_Load(object sender, EventArgs e)
        {

        }

        private void starButton1_ClickButton(object sender, EventArgs e)
        {
            EditClass = new CharClass();
            FromClass();
        }

        private void starButton4_ClickButton(object sender, EventArgs e)
        {
            BrowseFile.ShowDialog();
            var f = BrowseFile.FileName;
            if (new System.IO.FileInfo(f).Exists == false) return;
            ClassIcon = new Bitmap(f);
            ClassIcon = new Bitmap(ClassIcon, new Size(IconBox.Width, IconBox.Height));
            IconBox.Image = ClassIcon;
            
            IconBox.Invalidate();
            Invalidate();

        }

        private void starButton3_ClickButton(object sender, EventArgs e)
        {
            ToClass();
            //Console.WriteLine("Writing Dir.");
            Directory.CreateDirectory("Data/Classes/" + EditClass.Name+"/");
            EditClass.Save("Data/Classes/" + EditClass.Name + "/"+EditClass.Name+".class");
            //Console.WriteLine("Wrote.");
        }
    }
}
