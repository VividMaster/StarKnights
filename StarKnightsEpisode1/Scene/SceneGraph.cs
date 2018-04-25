using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarKnightsEpisode1.Draw;
namespace StarKnightsEpisode1.Scene
{
    public class SceneGraph
    {
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

        public SceneGraph()
        {
            X = 0;
            Y = 0;
            Z = 1;
            Rot = 0;
            Nodes = new List<GraphNode>();
        }
        public void Add(GraphNode node)
        {
            node.Graph = this;
            Nodes.Add(node);
        }

        public void Draw()
        {

            foreach(var node in Nodes)
            {

                float[] xc;
                float[] yc;

                node.SyncCoords();

                xc = node.XC;
                yc = node.YC;

                Render.Image(xc, yc, node.ImgFrame);
        

            }

        }

    }
}
