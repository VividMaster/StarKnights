using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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



            float[] ox = new float[4];
            float[] oy = new float[4];

            ox[0] = (-W / 2) * Graph.Z * Z;
            ox[1] = (W / 2) * Graph.Z * Z;
            ox[2] = (W / 2) * Graph.Z* Z ;
            ox[3] = (-W / 2) *Graph.Z*Z;

            oy[0] = (-H / 2) * Graph.Z*Z;
            oy[1] = (-H / 2) *Graph.Z*Z;
            oy[2] = (H / 2) * Graph.Z * Z;
            oy[3] = (H / 2) * Graph.Z * Z;

            float rr = Rot * (float)Math.PI / 180.0f;

            for (int i = 0; i < 4; i++)
            {

                float xo = StarKnightsEpisode1.App.StarKnightsAPP.W / 2 - Graph.X;
                float yo = StarKnightsEpisode1.App.StarKnightsAPP.H / 2 - Graph.Y;

                XC[i] = xo + ((X*Graph.Z*Z) + ((float)Math.Cos(rr) * ox[i] - (float)Math.Sin(rr) * oy[i]));
                YC[i] = yo + ((Y*Graph.Z*Z) + ((float)Math.Sin(rr) * ox[i] + (float)Math.Cos(rr) * oy[i]));


            }

            rr = (180.0f-Graph.Rot) * (float)Math.PI / 180.0f;

            
            for(int i = 0; i < 4; i++)
            {

                float xc, yc;

                xc = (Graph.X + App.StarKnightsAPP.W / 2) - XC[i];
                yc = (Graph.Y + App.StarKnightsAPP.H / 2) - YC[i];

                

                float nx = (float)Math.Cos(rr) * xc - (float)Math.Sin(rr) * yc;
                float ny = (float)Math.Sin(rr) * xc + (float)Math.Cos(rr) * yc;

                nx = nx + (App.StarKnightsAPP.W / 2);
                ny = ny + (App.StarKnightsAPP.H / 2);

                XC[i] = nx;
                YC[i] = ny;

            }






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
