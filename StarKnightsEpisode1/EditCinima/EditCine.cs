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
            //Visual.ResizeGL();
        }
        public static EditCine Main = null;
        public static string DefScript;
        public ScriptName ChooseScriptNAme = null;
        public List<CinePlugins.CinePlugin> Plugins = new List<CinePlugins.CinePlugin>();

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
            Visual.Invalidate();
            EditGraph.Update();
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
            Visual.MakeCurrent();
            Visual.InitGL();
            NewScene();
            SyncUI();
            ResizeUI();
            Console.WriteLine("Reflecting class.");
            Console.WriteLine(EditGraph == null ? "null" : "fine");


            var ci = new ClassIO(EditGraph);
            ci.Copy();
            Console.WriteLine("Done.");
            LoadPlugins();
            InitPlugins();

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

            Plugins.Add(pi as CinePlugins.CinePlugin);
           



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
         //   Console.WriteLine("VW:" + Visual.Width + " VH:" + Visual.Height);
       //     Visual.Size = new Size(Visual.Parent.Width, Visual.Parent.Height*2);
            StarApp.W = Visual.Width;
            StarApp.H = Visual.Height;
            StarApp.RW = StarApp.W;
            StarApp.RH = StarApp.H;
            StarControl.W = Visual.Width;
            StarControl.H = Visual.Height;
            Visual.ResizeGL();
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

        private void Visual_Paint_1(object sender, PaintEventArgs e)
        {
       //     Console.WriteLine("Drawn.");
            ResizeUI();
            Visual.Clear();

            Render.To2D();

            EditGraph.Draw();

            Visual.Swap();
        }

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

        private void BStopGame_Click(object sender, EventArgs e)
        {
            EditGraph.Restore();
            BRunGame.Enabled = true;
            BStopGame.Enabled = false;
            EditGraph.Running = false;
        }

        private void SceneTree_DragDrop(object sender, DragEventArgs e)
        {
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
            
        }
    }
}
