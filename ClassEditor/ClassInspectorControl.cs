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
namespace ClassEditor
{
    public partial class ClassInspectorControl : UserControl
    {
        public ClassInspectorControl()
        {
            InitializeComponent();
        }

        private void ClassInspectorControl_Load(object sender, EventArgs e)
        {
            LoadClasses();

        }

        private void LoadClasses()
        {
            ClassView.Clear();
            GameInfo.LoadClasses();
            int ii = 0;
            var il = new ImageList();
            il.ColorDepth = ColorDepth.Depth32Bit;
            il.ImageSize = new Size(32, 32);
            ClassView.View = View.SmallIcon;
            foreach (var cls in GameInfo.Classes)
            {
                il.Images.Add(cls.Icon);
                var ni = new ListViewItem(cls.UpperClass + ":" + cls.Name, ii);
                ClassView.Items.Add(ni);
                ii++;
            }
            ClassView.SmallImageList = il;
            Invalidate();
            ClassView.Invalidate();
            Inspect(0);
        }

        public void Inspect(int index)
        {
            ClassView.Items[index].Focused = true;
            ClassView.Items[index].Selected = true;

            ClassBox.Text = GameInfo.Classes[index].Name;
            UpperClassBox.Text = GameInfo.Classes[index].UpperClass;
            AttackDial.Value = (decimal)GameInfo.Classes[index].Attack;
            DefenseDial.Value = (decimal)GameInfo.Classes[index].Defense;
            TechDial.Value = (decimal)GameInfo.Classes[index].Tech;
            IQDial.Value = (decimal)GameInfo.Classes[index].IQ;
            CommDial.Value = (decimal)GameInfo.Classes[index].Comm;
            IconBox.Image = new Bitmap(GameInfo.Classes[index].Icon, new Size(IconBox.Width, IconBox.Height));



        }

        private void ClassView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            Inspect(ClassView.SelectedIndices[0]);
        }

        private void CheckChanges_Tick(object sender, EventArgs e)
        {
            var fc = new System.IO.DirectoryInfo("Data/Classes/").GetDirectories();
            if(fc.Length != GameInfo.Classes.Count())
            {
                LoadClasses();
            }
        }
    }
}
