using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarEngine.Draw;
using StarEngine.FXS;
using StarEngine.Reflect;
namespace StarEngine.Scene
{
    public class SceneGraph
    {

        public ClassIO ClassCopy
        {
            get;
            set;
        }

        public bool Running
        {
            get;
            set;
        }

        public FXLitImage LitImage
        {
            get;
            set;
        }

        public float X
        {
            get;
            set;
        }
        public float Y
        {
            get;
            set;
        }
        public float Z
        {
            get;
            set;
        }
        public float Rot
        {
            get;
            set;
        }

        public GraphNode Root
        {
            get;
            set;
        }

        public List<GraphLight> Lights
        {
            get;
            set;
        }

        public SceneGraph()
        {
            Running = false;
            X = 0;
            Y = 0;
            Z = 1;
            Rot = 0;
            Root = new GraphNode();
            Lights = new List<GraphLight>();
            LitImage = new FXLitImage();

        }

        public void Copy()
        {

            ClassCopy = new Reflect.ClassIO(this);
            ClassCopy.Copy();
            CopyNode(Root);
        }

        public void CopyNode(GraphNode node)
        {

            node.CopyProps();
            foreach(var nn in node.Nodes)
            {
                CopyNode(nn);
            }

        }

        public void Restore()
        {
            ClassCopy.Reset();
            RestoreNode(Root);
        }

        public void RestoreNode(GraphNode node)
        {
            node.RestoreProps();
            foreach(var nn in node.Nodes)
            {
                RestoreNode(nn);
            }
        }

        public void Add(GraphNode node)
        {
            node.Graph = this;
            Root.Nodes.Add(node);
            node.Root = Root;
        }

        public void Add(params GraphNode[] nodes)
        {

            foreach(var node in nodes)
            {

                node.Graph = this;
                Root.Nodes.Add(node);
                node.Root = Root;

            }

        }


        public void Add(GraphLight node)
        {
            node.Graph = this;
            Lights.Add(node);
        }

        public void Add(params GraphLight[] lights)
        {
            foreach(var light in lights)
            {
                light.Graph = this;
                Lights.Add(light);
            }
        }

        public void Translate(float x,float y)
        {

            X = X + x;
            Y = Y + y;

        }

        public void Move(float x,float y)
        {

            var r = Util.Maths.Rotate(-x, -y, (180.0f-Rot), 1.0f);

            X = X + r.X;
            Y = Y + r.Y;


        }

        public void Update()
        {

            if (Running)
            {
                UpdateNode(Root);
            }
            else
            {

            }

        }

        public void UpdateNode(GraphNode node)
        {

            node.Update();

            foreach(var sub in node.Nodes)
            {
                UpdateNode(sub);
            }

        }
        
        public void DrawNode(GraphNode node)
        {
            if (node.ImgFrame != null)
            {
       
            }

                bool first = true;

            foreach (var light in Lights)
            {
                if (node.ImgFrame == null) continue;
                LitImage.Graph = this;
                LitImage.Light = light;

                if (first)
                {
                    Render.SetBlend(BlendMode.None);
                    first = false;
                }
                else
                {
                    Render.SetBlend(BlendMode.Add);
                }

                LitImage.Bind();


                float[] xc;
                float[] yc;

                node.SyncCoords();

                xc = node.XC;
                yc = node.YC;

                Render.Image(node.DrawP, node.ImgFrame);
                

                
                //Render.Image(xc, yc, node.ImgFrame);



                LitImage.Release();

            }
            foreach(var snode in node.Nodes)
            {
                DrawNode(snode);
            }
        }
        public void Draw()
        {
            DrawNode(Root);
        }

    }
}
