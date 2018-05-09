using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StarEngine.Archive;
namespace PayLoadEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public VirtualFileSystem VFS = null;
        public List<VFile> Files = new List<VFile>();
        private void starButton1_ClickButton(object sender, EventArgs e)
        {
            BrowseFile.ShowDialog();
            foreach(var f in BrowseFile.FileNames)
            {
                var nf = new VFile();
                nf.FullPath = f;
                Files.Add(nf);
            }
            SyncUI();
        }
        public void SyncUI()
        {
            FileBox.Items.Clear();
            foreach(var f in Files)
            {
                FileBox.Items.Add(new System.IO.FileInfo(f.FullPath).Name + ":" + new System.IO.FileInfo(f.FullPath).Extension);
            }
        }

        private void starButton2_ClickButton(object sender, EventArgs e)
        {
            BrowseFolder.ShowDialog();
            foreach (var f in new System.IO.DirectoryInfo(BrowseFolder.SelectedPath).GetFiles()) 
            {
                var nf = new VFile();
                nf.FullPath = f.FullName;
                Files.Add(nf);
            }
            SyncUI();
        }

        private void starButton3_ClickButton(object sender, EventArgs e)
        {
            FileBox.Items.Clear();
            Files.Clear();
            SyncUI();
        }

        private void starButton4_ClickButton(object sender, EventArgs e)
        {
            var res =BrowseSave.ShowDialog();
            if (res != DialogResult.OK) return;
            VirtualFileSystem nfs = new VirtualFileSystem();
            foreach(var f in Files)
            {
                nfs.Add(f.FullPath);

            }
            var com = CompressCheck.CheckState == CheckState.Checked ? true : false;

            nfs.Save(BrowseSave.FileName, com);
        }

        private void starButton5_ClickButton(object sender, EventArgs e)
        {
            BrowseFile.ShowDialog();

            var path = BrowseFile.FileName;

            path = path.ToLower();
            path = path.Replace(".vfs", "");
            path = path.Replace(".toc", "");

            VirtualFileSystem ofs = new VirtualFileSystem();
            ofs.ReadToc(path+".toc");
            Files.Clear();
            foreach (var entry in ofs.Enteries)
            {
                var nf = new VFile();
                nf.FullPath = entry.Path;
                Files.Add(nf);
            }
            SyncUI();


        }

        private void FileBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int vi = FileBox.SelectedIndex;
            int i = 0;
            foreach (var fe in Files)
            {
                if (i == vi)
                {
                    var ext = new System.IO.FileInfo(fe.FullPath).Extension;
                    switch (ext)
                    {
                        case ".jpg":
                        case ".bmp":
                        case ".png":
                            var bit = new Bitmap(new Bitmap(fe.FullPath), new Size(PrevBox.Width, PrevBox.Height));
                            PrevBox.Image = bit;
                            PrevBox.Invalidate();
                            Invalidate();
                            break;
                    }
                    break;
                }
                PrevBox.Invalidate();
                Invalidate();
                i++;
            }
        }
    }
    public class VFile
    {
        public string FullPath = "";
    }
}
