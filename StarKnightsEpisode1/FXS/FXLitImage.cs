using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarKnightsEpisode1.FX;

namespace StarKnightsEpisode1.FXS
{
    public class FXLitImage : VEffect
    {
        public FXLitImage() : base("","Data/Shader/LitImageVS.glsl","Data/Shader/LitImageFS.glsl")
        {

        }
        public override void SetPars()
        {
            SetTex("tDiffuse", 0);
        }
    }
}
