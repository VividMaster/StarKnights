using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarKnightsEpisode1.FX;
using StarKnightsEpisode1.Scene;

namespace StarKnightsEpisode1.FXS
{
    public class FXLitImage : VEffect
    {

        public GraphLight Light
        {
            get;
            set;
        }

        public SceneGraph Graph
        {
            get;
            set;
        }

        public FXLitImage() : base("","Data/Shader/LitImageVS.glsl","Data/Shader/LitImageFS.glsl")
        {

        }
        public override void SetPars()
        {
            float sw, sh;
            sw = StarKnightsEpisode1.App.StarKnightsAPP.W;
            sh = StarKnightsEpisode1.App.StarKnightsAPP.H;
            float px, py, pz;

            // px = Light.X + Graph.X;
            // py = Light.Y + Graph.Y;
            px = Light.X + Graph.X*2.0f;
            py = Light.Y + Graph.Y*2.0f;
            float nx, ny;

            //float rr = (180.0f-Graph.Rot) * (float)Util.PI / 180.0f;

            

            //px = px + (sw / 2);
            //py = py + (sh / 2);

         //   nx = (float)Util.Cos(rr) * (px*Graph.Z) - (float)Util.Sin(rr) * (py*Graph.Z);
          //  ny = (float)Util.Sin(rr) * (px*Graph.Z) + (float)Util.Cos(rr) * (py*Graph.Z);

           // nx = nx + (sw / 2);
           // ny = ny + (sh / 2);

                        //nx = nx - (sw / 2);
            //ny = ny - (sh / 2);





            SetTex("tDiffuse", 0);
            //SetVec3("lPos", new OpenTK.Vector3(nx,ny,0));
            SetVec3("lDif", Light.Diffuse);
            SetVec3("lSpec", Light.Specular);
            SetFloat("lShiny", Light.Shiny);
            SetFloat("lRange", Light.Range * Graph.Z);
            SetFloat("sWidth", StarKnightsEpisode1.App.StarKnightsAPP.W);
            SetFloat("sHeight", StarKnightsEpisode1.App.StarKnightsAPP.H);

        }
    }
}
