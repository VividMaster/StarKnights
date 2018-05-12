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
using StarEngine.PostProcess;
using StarEngine.Import;
using StarEngine.Material;
namespace EditCinima
{
    partial class EditCine
    {

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

            Setup3D();

        }

        private void Setup3D()
        {
            Console.WriteLine("Setting up 3D test.");
            Import.RegDefaults();
            Console.WriteLine("Setting up post-processing.");
            ppRen = new StarEngine.PostProcess.PostProcessRender(512, 512);
            Console.WriteLine("Creating 3D Scene graph.");
            scene3d = new SceneGraph3D();

            ppRen.Scene = scene3d;

            Console.WriteLine("Importing mesh.");
            ent1 = Import.ImportNode("Data\\3D\\testshadow1.3ds");
            Console.WriteLine("Set up.");
            var mat1 = new Material3D();
            Console.WriteLine("Loading texture.");
            mat1.TCol = new Tex2D("Data\\3D\\brick_2.png");
            mat1.TNorm = new Tex2D("Data\\3D\\brick_2_NRM.png");
            Console.WriteLine("Loaded.");
            var ge = ent1 as GraphEntity3D;

            ge.SetMat(mat1);
            cam1 = new GraphCam3D();
            cam1.LocalPos = new OpenTK.Vector3(0, 25, 120);


            //cam1.LookAt(ent1);



            light1 = new StarEngine.Lighting.GraphLight3D();



            light1.LocalPos = new OpenTK.Vector3(0, 10, 60);

            ent1.Rot(new OpenTK.Vector3(0, 45, 0), Space.Local);


            scene3d.Add(ent1);
            scene3d.Add(light1);
            scene3d.Add(cam1);

            light1.Diff = new OpenTK.Vector3(1, 1, 1);


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



        protected override void OnMouseWheel(MouseEventArgs e)
        {

            mzi = mzi + (float)(e.Delta) * 0.00015f;

        }

        public void LoadDefaults()
        {
            DefScript = System.IO.File.ReadAllText("res/defaultScript.cs");


        }
        public static string GetDefScript(string name)
        {
            return DefScript.Replace("#Name", name);
        }



        private void Visual_Load(object sender, EventArgs e)
        {

        }

        private void UpdateTick_Tick(object sender, EventArgs e)
        {

            EditGraph.X = EditGraph.X + mxi / EditGraph.Z;
            EditGraph.Y = EditGraph.Y + myi / EditGraph.Z;
            EditGraph.Z = EditGraph.Z + (mzi * 0.3f) / EditGraph.Z;
            if (EditGraph.Z < 0.1f) EditGraph.Z = 0.1f;
            if (EditGraph.Z > 5.0f) EditGraph.Z = 5.0f;

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
            SyncNode(SceneTree.Nodes[0], EditGraph.Root);

            Invalidate();

        }

        private void SyncNode(TreeNode node, GraphNode gnode)
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


    }
}
