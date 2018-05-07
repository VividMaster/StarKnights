using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StarEngine.Scene;
using StarEngine.Tex;
using System.IO;
namespace UniverseGen
{
    public partial class UniverseGenControl : UserControl
    {

        public Tex2D[] GalImg;
        public Tex2D[] BgStarImg;
        public Tex2D[] PlanImg;
        public Tex2D[] SunImg;
        public SceneGraph UniGraph = null;

        public UniverseGenControl()
        {
            InitializeComponent();
            SeedBox.Text = Environment.TickCount.ToString();
            GalImg = LoadImgs("Data/Maps/", "g1.png", "g2.png");
            BgStarImg = LoadImgs("Data/Maps/", "bgstar1.png");
            PlanImg = LoadImgs("Data/Maps/Galaxy/Planet/", "plan1.png");
            SunImg = LoadImgs("Data/Maps/Galaxy/Sun/", "sun1.png", "sun2.png");
            /*
            GalImg = LoadGroup("Data/Maps/","g");
            BgStarImg = LoadGroup("Data/Maps/", "bgstar");
            PlanImg = LoadGroup("Data/Maps/Galaxy/Planet/", "plan");
            SunImg = LoadGroup("Data/Maps/Galaxy/Sun/", "sun");
    */        
    Console.WriteLine("Imported assets. Gals:" + GalImg.Length + " Planets:" + PlanImg.Length + " BGstars:" + BgStarImg.Length + " Suns:" + SunImg.Length);
            
        }
        public Tex2D[] LoadImgs(string path,params string[] file)
        {
            int ic = 0;
            var ia = new Tex2D[file.Length];
            foreach (var f in file)
            {
                ia[ic] = new Tex2D(path+f, true);
            }
            return ia;
        }
        public Tex2D[] LoadGroup(string path,string name)
        {
            int ic = 0;
            var ds = new DirectoryInfo(path).GetFiles();
            foreach(var f in ds)
            {
                if (f.Name.Contains(name))
                {
                    ic++;
                }
            }
            ic = 0;

            var ra = new Tex2D[ic];
            foreach(var f in ds)
            {
                if (f.Name.Contains(name))
                {
                    ra[ic] = new Tex2D(f.FullName, true);
                }
                ic++;
            }
            return ra;

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void starButton1_ClickButton(object sender, EventArgs e)
        {
            SeedBox.Text = Environment.TickCount.ToString();
        }

        private void starButton2_ClickButton(object sender, EventArgs e)
        {
            Random r = new Random(int.Parse(SeedBox.Text));
            int uw = 2048;
            int uh = 2048;
            int pg = (uw + uh) / 120;
            int numgal = r.Next(pg / 2, pg);

            var uniscene = new SceneGraph();
            uniscene.Root.Name = "Universe Root";
            int bs = r.Next(100, 200);

            var ul = new GraphLight();
            ul.Name = "Universe Light 1";
            ul.Range = 3000;
            ul.Diffuse = new OpenTK.Vector3(3, 3, 3);
            uniscene.Add(ul);
            
            for(int i = 0; i < bs; i++)
            {
                int x = r.Next(-uw / 2, uw / 2);
                int y = r.Next(-uh / 2, uh / 2);
                var sn = new GraphNode();
                sn.X = x;
                sn.Y = y;
                sn.Rot = r.Next(0, 360);
                sn.Z = 0.1f + (float)r.NextDouble() * 1.2f;
                sn.Name = "BgStar" + i.ToString();
                sn.ImgFrame = BgStarImg[r.Next(0, BgStarImg.Length - 1)];
                uniscene.Root.Nodes.Add(sn);

            }
            if(new FileInfo("Data/Uni/UniGraph.graph").Exists)
            {
                File.Delete("Data/Uni/UniGraph.graph");
            }
            uniscene.Save("Data/Uni/UniGraph.graph");
            Console.WriteLine("Universed created and saved.");


        }
    }
}
