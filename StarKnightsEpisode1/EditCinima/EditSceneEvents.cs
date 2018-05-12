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
    partial class EditCine
    {

        private void starControl1_Load(object sender, EventArgs e)
        {
            Visual.MakeCurrent();
            Visual.InitGL();
            Visual.ResizeGL();
            SetAppInfo();
        }

        private void SetAppInfo()
        {
            AppInfo.W = Visual.Width;
            AppInfo.H = Visual.Height;
            AppInfo.RW = Visual.Width;
            AppInfo.RH = Visual.Height;
        }

        private void Visual_Resize_1(object sender, EventArgs e)
        {
            ResizeUI();
            SetAppInfo();
        }


        private void SceneTree_BeforeLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.Node == SceneTree.Nodes[0]) e.CancelEdit = true;

            renameNode = SceneTree.SelectedNode;
        }

        private void SceneTree_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.CancelEdit) return;
            renameNode.Text = e.Label;
        }

        private void SceneTree_Click(object sender, EventArgs e)
        {
            var me = (MouseEventArgs)e;
            if (me.Button == MouseButtons.Right)
            {

                //SceneTreeMenu.


            }
        }

        private void SceneTreeMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {


            var n = SceneTree.SelectedNode;

            if (n == SceneTree.Nodes[0]) return;

            if (n == null) return;

            var gn = NodeMap[n];

            switch (e.ClickedItem.Name)
            {
                case "SMRename":

                    n.BeginEdit();

                    break;
                case "SMDelete":

                    n.Parent.Nodes.Remove(n);

                    gn.Root.Nodes.Remove(gn);

                    SyncUI();


                    break;
            }
        }

        private void SceneTree_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
            var file = e.Data.GetData(DataFormats.FileDrop);

            dragFiles = (string[])e.Data.GetData(DataFormats.FileDrop);




            // Console.WriteLine(file.GetType().ToString());
            // Console.WriteLine(file.ToString());


        }


        private void SceneTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node == null) return;
            var an = NodeMap[e.Node];
            if (an != null)
            {
                PropGrid.SelectedObject = an;
            }
        }

        private void SMNewScript_Click(object sender, EventArgs e)
        {
            var sn = SceneTree.SelectedNode;
            if (sn == null) return;
            var gn = NodeMap[sn];
            if (gn == null) return;

            NewScriptNode = gn;

            ChooseScriptNAme = new ScriptName();
            ChooseScriptNAme.Show();




        }


        public static void CreateScript(string Name)
        {

            string scriptname = "scripts/" + Name + ".cs";

            File.WriteAllText(scriptname, GetDefScript(Name));


            var gs = new GraphScript();

            gs.ScriptFile = scriptname;
            //NewScriptNode.Nodes.Add(gs);
            var sb = gs.Script.Class as ScriptBase;
            NewScriptNode.Nodes.Add(sb);


            sb.Node = NewScriptNode;

            Main.SyncUI();
            var sc = (ScriptBase)gs.Script.Class;

            if (sc != null)
            {
                sc.Init();
            }


        }

        private void SMLoadScript_Click(object sender, EventArgs e)
        {
            BrowseFile.ShowDialog();

            var nf = new FileInfo(BrowseFile.FileName);

            if (nf.Extension == ".cs")
            {
                var gs = new GraphScript();
                gs.ScriptFile = BrowseFile.FileName;
                var sn = SceneTree.SelectedNode;
                if (sn == null) return;
                var gn = NodeMap[sn];
                if (gn == null) return;
                //gn.Nodes.Add(gs);

                var sb = gs.Script.Class as ScriptBase;
                sb.Name = nf.Name.Replace(nf.Extension, "");
                gn.Nodes.Add(sb);
                sb.Node = gn;
                Console.WriteLine(gn.Name);

                Main.SyncUI();

                NewScriptNode = gn;

            }
            else
            {
                MessageBox.Show("File must be a .cs file.");
                return;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditGraph.Copy();
            BRunGame.Enabled = false;
            BStopGame.Enabled = true;
            EditGraph.Running = true;
        }


        private void Visual_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MapIn = true;
            }
            if (e.Button == MouseButtons.Left)
            {
                MouseIn = true;
            }

            if (MoveOn)
            {
                EditMode = 1;
            }
            if (RotateOn)
            {
                EditMode = 2;
            }
            if (ScaleOn)
            {
                EditMode = 3;
            }

            var n = EditGraph.Pick(MX, MY);
            EditNode = n;
            PropGrid.SelectedObject = n;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            var lp = EditGraph.GetPoint(MX, MY);
            var nl = new GraphLight();
            nl.X = lp.X;
            nl.Y = lp.Y;
            nl.Z = 1.0f;
            if (LightIcon == null) Environment.Exit(1);
            nl.ImgFrame = LightIcon;
            nl.W = 32;
            nl.H = 32;
            EditGraph.Add(nl, true);
            SyncUI();
        }

        private void scaleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void UI2_DoubleClick(object sender, EventArgs e)
        {
            if (UI2.SelectedIndex == 0) return;
            int si = UI2.SelectedIndex;
            var pc = UI2.Controls[UI2.SelectedIndex].Controls[0];
            var ncl = new List<Control>();
            for (int i = 0; i < UI2.Controls.Count; i++)
            {
                if (i != si)
                {
                    ncl.Add(UI2.Controls[i]);
                }
            }
            UI2.Controls.Clear();
            foreach (var c in ncl)
            {
                UI2.Controls.Add(c);
            }

            var nf = new PluginForm();
            nf.Show();
            nf.Text = pc.Name;
            nf.PluginControl = pc;
            pc.Dock = DockStyle.Fill;
            nf.TopMost = true;
            nf.PlugPan.Controls.Add(pc);



        }

        private void UI2_DragOver(object sender, DragEventArgs e)
        {
            Console.WriteLine("Over!");
        }

        private void savePayLoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            utc = 0;
            Directory.CreateDirectory("TempPayload");
            List<Tex2D> UT = new List<Tex2D>();
            ScanScene(EditGraph, UT, EditGraph.Root);
            Console.WriteLine("Scanned scene. Unique images:" + utc);
            VirtualFileSystem VFS = new VirtualFileSystem();

        }

        public void ScanScene(SceneGraph s, List<Tex2D> UT, GraphNode node)
        {

            if (node.ImgFrame != null)
            {
                bool found = false;
                foreach (var t in UT)
                {
                    if (t.Path == node.ImgFrame.Path)
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    UT.Add(node.ImgFrame);
                    utc++;
                }
            }
            foreach (var n2 in node.Nodes)
            {
                ScanScene(s, UT, n2);
            }
        }

        private void loadPayloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateTick.Enabled = false;
            while (render)
            {

            }
            UpdateTick.Enabled = false;
            BrowseFile.DefaultExt = ".toc";
            BrowseFile.ShowDialog();
            VirtualFileSystem gfs = new VirtualFileSystem();
            gfs.ReadToc(BrowseFile.FileName);
            Console.WriteLine("Read Toc");
            EditGraph = gfs.GetGraph("Universe Root");

            //var ng = new SceneGraph();
            //ng.Load(BrowseFile.FileName);
            //EditGraph = ng;

            SyncUI();
            UpdateTick.Enabled = true;
        }

        private void UI2_DragEnter(object sender, DragEventArgs e)
        {
            Console.WriteLine("DRAG");
        }

        private void loadSceneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateTick.Enabled = false;
            while (render)
            {

            }
            UpdateTick.Enabled = false;
            BrowseFile.DefaultExt = ".graph";
            BrowseFile.ShowDialog();
            var ng = new SceneGraph();
            ng.Load(BrowseFile.FileName);
            EditGraph = ng;
            SyncUI();
            UpdateTick.Enabled = true;
        }

        private void Visual_Scroll(object sender, ScrollEventArgs e)
        {

        }



        private void Visual_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MapIn = false;
            }
            if (e.Button == MouseButtons.Left)
            {
                MouseIn = false;
            }
        }

        private void rotateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditMode = 2;
        }

        private void moveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditMode = 1;
        }

        private void Visual_MouseMove(object sender, MouseEventArgs e)
        {

            if (MapIn)
            {
                mxi = mxi + MXD;
                myi = myi + MYD;

            }

            MoveOn = false;
            RotateOn = false;
            if (e.Y < 100)
            {
                ShowIcons = true;
                if (e.X > 20 && e.X < 52)
                {
                    if (e.Y > 20 && e.Y < 52)
                    {
                        MoveOn = true;
                        RotateOn = false;
                        ScaleOn = false;
                    }
                }
                if (e.X > 65 && e.X < 97)
                {
                    if (e.Y > 20 && e.Y < 52)
                    {
                        MoveOn = false;
                        RotateOn = true;
                        ScaleOn = false;
                    }
                }
                if (e.X > 110 && e.X < 142)
                {
                    if (e.Y > 20 && e.Y < 52)
                    {
                        ScaleOn = true;
                        RotateOn = false;
                        MoveOn = false;

                    }
                }
            }
            else
            {
                ShowIcons = false;
            }
            MXD = e.X - MX;
            MYD = e.Y - MY;
            MX = e.X;
            MY = e.Y;

            if (MouseIn)
            {
                if (EditMode == 1)
                {
                    EditNode?.EditMove(MXD, MYD);
                }
                if (EditMode == 2)
                {
                    EditNode?.Rotate(MXD);
                }
                if (EditMode == 3)
                {
                    EditNode?.Scale(MYD * 0.02f);
                }
            }

        }

        private void BStopGame_Click(object sender, EventArgs e)
        {
            EditGraph.Restore();
            BRunGame.Enabled = true;
            BStopGame.Enabled = false;
            EditGraph.Running = false;
        }

        private void SceneTree_DragDrop(object sender, DragEventArgs e)
        {
            UpdateTick.Enabled = false;
            foreach (var f in dragFiles)
            {
                var sn = new GraphSprite(f);
                sn.W = DefW;
                sn.H = DefH;
                sn.Name = new System.IO.FileInfo(f).Name;
                if (SceneTree.SelectedNode != null)
                {
                    var gn = NodeMap[SceneTree.SelectedNode];
                    gn.Nodes.Add((GraphNode)sn);
                    sn.Root = gn;
                }
                else
                {
                    EditGraph.Add(sn);
                }
            }
            SyncUI();
            UpdateTick.Enabled = true;
        }

    }
}
