using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarKnightsEpisode1.Util;
using OpenTK;
namespace StarKnightsEpisode1.Scene
{

    public class GraphNode
    {

        public Tex.Tex2D ImgFrame
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
        public float W
        {
            get;
            set;
        }
        public float H
        {
            get;
            set;
        }
        
      


        public float[] XC = new float[4];
        public float[] YC = new float[4];

        public void SyncCoords()
        {

            int sw = StarKnightsEpisode1.App.StarKnightsAPP.W;
            int sh = StarKnightsEpisode1.App.StarKnightsAPP.H;

            float[] ox = new float[4];
            float[] oy = new float[4];

            ox[0] = (-W / 2);// * Graph.Z * Z;
            ox[1] = (W / 2);// * Graph.Z * Z;
            ox[2] = (W / 2);// * Graph.Z* Z ;
            ox[3] = (-W / 2);// *Graph.Z*Z;

            oy[0] = (-H / 2);// * Graph.Z*Z;
            oy[1] = (-H / 2);// *Graph.Z*Z;
            oy[2] = (H / 2);// * Graph.Z * Z;
            oy[3] = (H / 2);// * Graph.Z * Z;


            Vector2[] p = Maths.RotateOC(ox, oy, Rot,Z,0,0);

            float mx, my;

            p = Maths.Push(p, X-Graph.X, Y-Graph.Y);
         
            p = Maths.RotateOC(p, Graph.Rot, Graph.Z, 0,0);

            p = Maths.Push(p, sw / 2, sh / 2);

            //p = Maths.Push(p, X, Y);

            //p = Maths.Push(p,sw / 2, sh / 2);

            //p = Maths.Push(p, X+sw/2, Y+sh/2, Graph.Z);



            Draw.Render.Image(p, ImgFrame);




        }

        public SceneGraph Graph
        {
            get;
            set;
        }

        public GraphNode()
        {
            X = 0;
            Y = 0;
            Z = 1.0f;
            W = 0;
            H = 0;
            Rot = 0;
            ImgFrame = null;
        }
        

    }
}
