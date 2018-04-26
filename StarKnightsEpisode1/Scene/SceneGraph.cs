using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarKnightsEpisode1.Draw;
using StarKnightsEpisode1.FXS;
namespace StarKnightsEpisode1.Scene
{
    public class SceneGraph
    {

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

        public List<GraphNode> Nodes
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
            X = 0;
            Y = 0;
            Z = 1;
            Rot = 0;
            Nodes = new List<GraphNode>();
            Lights = new List<GraphLight>();
            LitImage = new FXLitImage();

        }

        public void Add(GraphNode node)
        {
            node.Graph = this;
            Nodes.Add(node);
        }

        public void Add(params GraphNode[] nodes)
        {

            foreach(var node in nodes)
            {

                node.Graph = this;
                Nodes.Add(node);

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

        public void Draw()
        {
            foreach (var light in Lights)
            {
                LitImage.Graph = this;
                LitImage.Light = light;
                LitImage.Bind();

                foreach (var node in Nodes)
                {

                    float[] xc;
                    float[] yc;

                    node.SyncCoords();

                    xc = node.XC;
                    yc = node.YC;

                    Render.Image(xc, yc, node.ImgFrame);


                }

                LitImage.Release();

            }
        }

    }
}
