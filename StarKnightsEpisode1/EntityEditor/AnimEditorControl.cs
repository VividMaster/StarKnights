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
namespace EntityEditor
{
    public partial class AnimEditorControl : UserControl
    {
        public AnimEditorControl()
        {
            InitializeComponent();
            Main = this;
            NewAnim();
        }
        public Animation EditAnim = null;
        public AnimationSet EditSet = null;
        public static AnimEditorControl Main = null;
        public GetAnimName GetName = null;
        private void starButton4_ClickButton(object sender, EventArgs e)
        {
            GetName = new GetAnimName();
            GetName.Show();
        }
        public void AddAnim(string name)
        {
            EditAnim = new Animation();
            EditAnim.Name = name;
            EditSet.Anims.Add(EditAnim);
            AnimSelectBox.Items.Add(EditAnim);
            SelectAnim(0);
        }
        public void SelectAnim(int i)
        {
            AnimSelectBox.SelectedIndex = i;
            SyncFrames();
        }
        public void SyncFrames()
        {
            AnimFramesView.Clear();
            var images = new ImageList();
            images.ImageSize = new Size(32, 32);
            AnimFramesView.SmallImageList = images;
            AnimFramesView.View = View.SmallIcon;
            int i = 0;
            foreach (var f in EditAnim.Frames)
            {
                images.Images.Add(new Bitmap(f.RawFrame, new Size(32, 32)));
                AnimFramesView.Items.Add("F:" + i.ToString() + ":" + f.ToString(), i);
                i++;
            }
            AnimFramesView.Invalidate();
        }
        public void NewAnim()
        {
            EditSet = new AnimationSet();
            
        }
        private void starButton1_ClickButton(object sender, EventArgs e)
        {
            NewAnim();
        }

        private void AnimBox_TextChanged(object sender, EventArgs e)
        {
            EditSet.Name = AnimBox.Text;
        }

        private void starButton5_ClickButton(object sender, EventArgs e)
        {
            BrowseFile.ShowDialog();
            foreach(var f in BrowseFile.FileNames)
            {
                var af = new AnimFrame();
                af.RawFrame = new Bitmap(f);
                EditAnim.Frames.Add(af);
                
            }
            SyncFrames();

        }
    }
}
