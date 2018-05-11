using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarEngine.Effect
{
    public class EMultiPass3D : Effect3D
    {
        public EMultiPass3D() : base("", "Data/Shader/vsMP1.txt", "Data/Shader/fsMP1.txt")
        {

        }
        public override void SetPars()
        {
            if (Material.Material3D.Active.TCol != null)
            {
                SetBool("eC", true);
            }
            else
            {
                SetBool("eC", false);
            }
            if(Material.Material3D.Active.TNorm != null)
            {
                SetBool("eN", true);
            }
            else
            {
                SetBool("eN", false);
            }
            if (Material.Material3D.Active.TEnv != null)
            {
                SetBool("eE", true);
            }
            else
            {
                SetBool("eE", false);
               // Environment.Exit(0);
            }
            //SetMat("MVP", Effect.FXG.Local * FXG.Proj);
            SetMat("model", Effect.FXG.Local);
            SetMat("cam",OpenTK.Matrix4.Invert(OpenTK.Matrix4.CreateTranslation(FXG.Cam.WorldPos)) * FXG.Cam.CamWorld );
            SetMat("proj", FXG.Cam.ProjMat);
            SetVec3("camP", FXG.Cam.WorldPos);
            SetVec3("lP", Lighting.GraphLight3D.Active.WorldPos);
            SetVec3("lC", Lighting.GraphLight3D.Active.Diff);
            SetFloat("atten", Lighting.GraphLight3D.Active.Atten);
            SetFloat("ambCE", Lighting.GraphLight3D.Active.AmbCE);
            SetFloat("matS", Material.Material3D.Active.Shine);
            SetVec3("matSpec", Material.Material3D.Active.Spec);
            SetFloat("envS", Material.Material3D.Active.envS);
            SetTex("tC", 0);
            SetTex("tN", 1);
            SetTex("tE", 2);
        }
    }
}
