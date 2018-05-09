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
            //Visual.ResizeGL();
           // VFS = new VirtualFileSystem();
           // GameInfo.VFS = VFS;
           // VFS.Update("Data/");
         //   SceneInfo.VFS = VFS;
            //Console.WriteLine("VFS Enteries:" + VFS.Enteries.Count);
            //Console.WriteLine("VFS Size:" + VFS.Size);
           // VFS.Load("ship1.png", "Data/");
            mxi = 0;
            myi = 0;
            mzi = 0;
            mdrag = 0.65f;
        }
        protected override void OnMouseWheel(MouseEventArgs e)
        {

            mzi = mzi + (float)(e.Delta) * 0.00015f;
            
        }
        public VirtualFileSystem VFS;
        public static TabControl UIP;
        public static EditCine Main = null;
        public static string DefScript;
        public ScriptName ChooseScriptNAme = null;
        public List<CinePlugins.CinePlugin> Plugins = new List<CinePlugins.CinePlugin>();
        public Tex2D MoveIcon, RotateIcon, ScaleIcon, LightIcon;
        float mxi, myi, mzi, mdrag;
        public void LoadDefaults()
        {
            DefScript = System.IO.File.ReadAllText("res/defaultScript.cs");
            

        }
        public static string GetDefScript(string name)
        {
            return DefScript.Replace("#Name", name);
        }


        public static SceneGraph EditGraph = null;
        public static GraphNode EditNode = null;
        public static Dictionary<TreeNode, GraphNode> NodeMap = new Dictionary<TreeNode, GraphNode>();
        private void Visual_Load(object sender, EventArgs e)
        {
       
        }

        private void Visual_Resize(object sender, EventArgs e)
        {
         
        }

        private void UpdateTick_Tick(object sender, EventArgs e)
        {

            EditGraph.X = EditGraph.X + mxi / EditGraph.Z;
            EditGraph.Y = EditGraph.Y + myi / EditGraph.Z;
            EditGraph.Z = EditGraph.Z + (mzi*0.3f) / EditGraph.Z;

            mxi = mxi * mdrag;
            myi = myi * mdrag;
            mzi = mzi * mdrag;
            if (render) return;

            Visual.Invalidate();
            EditGraph.Update();
            if (ShowIcons)
            {
                if (IconsAlpha < 1.0f)
                {
                    IconsAlpha = IconsAlpha + 0.04f;
                }
                else
                {
                    IconsAlpha = 1.0f;
                }

            }
            else
            {
                if (IconsAlpha > 0.0f)
                {
                    IconsAlpha = IconsAlpha - 0.08f;
                }
                else
                {
                    IconsAlpha = 0.0f;
                }
            }
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

        // NEW NODE
        private void CineGraphNewNode(object sender, EventArgs e)
        {
            EditNode = new GraphNode();
            TreeNode nt = new TreeNode();
            
            nt.Text = "New Node";
            GraphNode nn = EditNode;
            nn.Name = "New Node";
            NodeMap.Add(nt, nn);
            //SceneTree.Nodes[0].Nodes.Add(nt);
            EditGraph.Add(nn);
            SyncUI();



            PropGrid.SelectedObject = nn;
        }



        //New Scene
        private void newSceneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewScene();
            SyncUI();
        }

        public void SyncUI()
        {
            NodeMap.Clear();
            SceneTree.Nodes[0].Nodes.Clear();

            NodeMap.Add(SceneTree.Nodes[0], EditGraph.Root);
            SyncNode(SceneTree.Nodes[0],EditGraph.Root);

            Invalidate();

        }

        private void SyncNode(TreeNode node,GraphNode gnode)
        {
            node.Name = gnode.Name;
            

            foreach (var gn in gnode.Nodes)
            {
                TreeNode nn = new TreeNode(gn.Name);
                node.Nodes.Add(nn);
                NodeMap.Add(nn, gn);
                SyncNode(nn, gn);
            }
        }

        public void NewScene()
        {
            EditGraph = new SceneGraph();
            var l = new GraphLight();
            l.Diffuse = new OpenTK.Vector3(1, 1, 1);
            l.Range = 600;
            EditGraph.Add(l);
        }

        private void CineGraphNewSprite(object sender, EventArgs e)
        {
            EditNode = new GraphNode();
            TreeNode nt = new TreeNode();
            nt.Text = "New Sprite";
            GraphNode nn = new GraphNode();
            nn.Name = "New Sprite";
            NodeMap.Add(nt, nn);
            SceneTree.Nodes[0].Nodes.Add(nt);
            EditGraph.Add(nn);

            PropGrid.SelectedObject = nn;
        }

        private void EditCine_Load(object sender, EventArgs e)
        {
            int sms = Environment.TickCount;
            UpdateTick.Enabled = false;
            Visual.MakeCurrent();
            Visual.InitGL();
            NewScene();
            SyncUI();
            ResizeUI();
            Console.WriteLine("Reflecting class.");
            Console.WriteLine(EditGraph == null ? "null" : "fine");
          //  Visual.ContextMenuStrip = EditMenu;

            var ci = new ClassIO(EditGraph);
            ci.Copy();
            Console.WriteLine("Done.");
            LoadPlugins();
            InitPlugins();
            var iconfs = new VirtualFileSystem();
            iconfs.ReadToc("Data/Icons/icons");

            MoveIcon = iconfs.GetTex("MoveIcon");
            RotateIcon = iconfs.GetTex("RotateIcon");
            ScaleIcon = iconfs.GetTex("ScaleIcon");
            LightIcon = iconfs.GetTex("LightIcon");
            //MoveIcon = new Tex2D("Data/Icons/MoveIcon.png",true);

//            MoveIcon = new Tex2D("Data/Icons/MoveIcon.png", true);
           // RotateIcon = new Tex2D("Data/Icons/RotateIcon.png",true);
            //ScaleIcon = new Tex2D("Data/Icons/ScaleIcon.png",true);
            //LightIcon = new Tex2D("Data/Icons/LightIcon.png", true);
            UpdateTick.Enabled = true;
            int ems = Environment.TickCount;
            Console.WriteLine("StartUp Time:" + (float)(ems - sms) / 1000.0f);
        }

        public void InitPlugins()
        {

            foreach(var p in Plugins)
            {
                Console.WriteLine("Obtaining plugin UI:" + p.GetName());
                var pc = p.GetUI();
                var tb = new TabPage(p.GetName());
                pc.Dock = DockStyle.Fill;
                tb.Controls.Add(pc);
                UI2.TabPages.Add(tb);


            }

        }

        public void LoadPlugins()
        {
            Console.WriteLine("Scanning plugins.");
            foreach(var pf in new DirectoryInfo("Plugins").GetDirectories())
            {
                var full = "Plugins/" + pf.Name + "/" + pf.Name + ".dll";
                Console.WriteLine("Loading plugin:" + pf.Name + " FullPath:" + full);
                LoadPlugin(full,pf.Name.Replace(".dll",""));
            }
            Console.WriteLine("Plugins loaded.");
        }
        public void LoadPlugin(string path,string name)
        {
            var asm = Assembly.LoadFrom(path);
            Console.WriteLine("Loaded Asm:" + asm.FullName);
            foreach(var tp in asm.GetTypes())
            {
                Console.WriteLine("Found Type:" + tp.Name);
            }
            Console.WriteLine("Obtaining Type:" + name + ".PluginEntry");

            var et = asm.GetType(name + ".PluginEntry");
            MethodInfo gp = et.GetMethod("GetPlugin");
            Console.WriteLine("Done:" + gp.Name);
            Console.WriteLine("Static:" + gp.IsStatic);

            var pi = gp.Invoke(null, null);
            Console.WriteLine("Got Plugin:" + pi.GetType().FullName);

            var pa = pi as CinePlugins.CinePlugin[];
            foreach (var pp in pa)
            {
                Plugins.Add(pp);
            }



            /*
            var et = asm.GetType(name + ".PluginEntry").GetConstructor(Type.EmptyTypes);
            var nt = et.Invoke(null);

            Console.WriteLine("Succesfull.");
            var em = nt.GetType().GetMethod("GetPlugin");

            Console.WriteLine("GetPluginName:" + em.FullName);
            
            Console.WriteLine("Getting entry method.");
            var plug = em.Invoke(em, null);
            Console.WriteLine("Done.");

            var pi = plug as CinePlugins.CinePlugin;

            Console.WriteLine("PluginReturnedName:" + pi.GetName());
            */




            Console.WriteLine("Plugin scanned.");


        }
        private void EditCine_Resize(object sender, EventArgs e)
        {
            ResizeUI();
        }

        private void ResizeUI()
        {
            UpdateTick.Enabled = false;
         //   Console.WriteLine("VW:" + Visual.Width + " VH:" + Visual.Height);
       //     Visual.Size = new Size(Visual.Parent.Width, Visual.Parent.Height*2);
            StarApp.W = Visual.Width;
            StarApp.H = Visual.Height;
            StarApp.RW = StarApp.W;
            StarApp.RH = StarApp.H;
            StarControl.W = Visual.Width;
            StarControl.H = Visual.Height;
            Visual.ResizeGL();
            UpdateTick.Enabled = true;
        }

        private void starControl1_Load(object sender, EventArgs e)
        {
            Visual.MakeCurrent();
            Visual.InitGL();
            Visual.ResizeGL();
        }

        private void Visual_Resize_1(object sender, EventArgs e)
        {
            ResizeUI();
        }
        bool render = false;
        private void Visual_Paint_1(object sender, PaintEventArgs e)
        {
            //     Console.WriteLine("Drawn.");
            render = true;
            ResizeUI();
            Visual.Clear();

            Render.To2D();

            
            EditGraph.Draw();

            if (ShowIcons || IconsAlpha > 0.0f) 
            {
                Render.Col = new OpenTK.Vector4(1, 1, 1, IconsAlpha);
                Render.SetBlend(BlendMode.Alpha);
                if (MoveOn)
                {
                    Render.Col = new OpenTK.Vector4(0.5f, 0.5f, 0.5f, 0.5f*IconsAlpha);
                    Render.Rect(20, 20, 32, 32);
                }
                Render.Col = new OpenTK.Vector4(1, 1, 1, IconsAlpha);
                    Render.Image(20, 20, 32, 32, MoveIcon);
                if (RotateOn)
                {
                    Render.Col = new OpenTK.Vector4(0.5f, 0.5f, 0.5f, 0.5f*IconsAlpha);
                    Render.Rect(65, 20, 32, 32);
                }
                Render.Col = new OpenTK.Vector4(1, 1, 1, IconsAlpha);
                    Render.Image(65, 20, 32, 32, RotateIcon);

                if (ScaleOn)
                {
                    Render.Col = new OpenTK.Vector4(0.5f, 0.5f, 0.5f, 0.5f * IconsAlpha);
                    Render.Rect(110, 20, 32, 32);
                }
                Render.Col = new OpenTK.Vector4(1, 1, 1, IconsAlpha);
                Render.Image(110, 20, 32, 32, ScaleIcon);

            }

            Render.Col = new OpenTK.Vector4(1, 1, 1, 1);

            switch (EditMode)
            {
                case 1:
                    Render.Image(20, Visual.Height - 40, 32, 32, MoveIcon);
                    break;
                case 2:
                    Render.Image(20, Visual.Height - 40, 32, 32, RotateIcon);
                    break;
                case 3:
                    Render.Image(20, Visual.Height - 40, 32, 32, ScaleIcon);
                    break;
            }
            

            Visual.Swap();
            render = false;
        }
        public int EditMode = 0;
        private string oldNodeName = "";
        private TreeNode renameNode = null;
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
            if(me.Button == MouseButtons.Right)
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
        string[] dragFiles = null;
        private void SceneTree_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
            var file = e.Data.GetData(DataFormats.FileDrop);

            dragFiles = (string[])e.Data.GetData(DataFormats.FileDrop);

        


           // Console.WriteLine(file.GetType().ToString());
           // Console.WriteLine(file.ToString());


        }
        public int DefW = 128, DefH = 128;

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
        public static GraphNode NewScriptNode = null;
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
            var sc = (ScriptBase) gs.Script.Class;

            if (sc != null)
            {
                sc.Init();
            }


        }

        private void SMLoadScript_Click(object sender, EventArgs e)
        {
            BrowseFile.ShowDialog();

            var nf = new FileInfo(BrowseFile.FileName);

            if(nf.Extension == ".cs")
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

        public bool MoveOn = false, RotateOn = false, ScaleOn = false;
        public bool ShowIcons = false;
        public float IconsAlpha = 0.0f;
        bool MouseIn = false;
        float MXD, MYD;
        bool MapIn = false;
        private void Visual_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
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
            nl.X =lp.X;
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
        public List<PluginForm> PlugForms = new List<PluginForm>();
        private void UI2_DoubleClick(object sender, EventArgs e)
        {
            if (UI2.SelectedIndex == 0) return;
            int si = UI2.SelectedIndex;
            var pc = UI2.Controls[UI2.SelectedIndex].Controls[0];
            var ncl = new List<Control>();
            for(int i = 0; i < UI2.Controls.Count;i++)
            {
                if (i != si)
                {
                    ncl.Add(UI2.Controls[i]);
                }
            }
            UI2.Controls.Clear();
            foreach(var c in ncl)
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
        private int utc = 0;
        public void ScanScene(SceneGraph s,List<Tex2D> UT,GraphNode node)
        {
            
            if(node.ImgFrame!=null)
            {
                bool found = false;
                foreach(var t in UT)
                {
                    if(t.Path == node.ImgFrame.Path)
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
            foreach(var n2 in node.Nodes)
            {
                ScanScene(s, UT, n2);
            }
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

        public int MX, MY;

        private void Visual_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
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
            if(e.Y<100)
            {
                ShowIcons = true;
                if(e.X>20 && e.X < 52)
                {
                    if(e.Y>20 && e.Y < 52)
                    {
                        MoveOn = true;
                        RotateOn = false;
                        ScaleOn = false;
                    }
                }
                if(e.X>65 && e.X < 97)
                {
                    if(e.Y>20 && e.Y < 52)
                    {
                        MoveOn = false;
                        RotateOn = true;
                        ScaleOn = false;
                    }
                }
                if(e.X>110 && e.X < 142)
                {
                    if(e.Y>20 && e.Y < 52)
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
                if(EditMode == 3)
                {
                    EditNode?.Scale(MYD*0.02f);
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
