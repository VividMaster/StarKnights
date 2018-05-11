﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarEngine.Effect
{
    public class EDepth3D : Effect3D
    {
        public EDepth3D() : base("","Data/Shader/vsDepth.txt","Data/Shader/fsDepth.txt")
        {

        }
        public override void SetPars()
        {
         
            //SetMat("MVP", Effect.FXG.Local * FXG.Proj);
            SetMat("model", Effect.FXG.Local);
            SetMat("cam", Effect.FXG.Cam.CamWorld * OpenTK.Matrix4.Invert(OpenTK.Matrix4.CreateTranslation(FXG.Cam.WorldPos)));
            SetMat("proj", FXG.Cam.ProjMat);
            SetVec3("camP", FXG.Cam.WorldPos);
            SetFloat("minZ", FXG.Cam.MinZ);
            SetFloat("maxZ", FXG.Cam.MaxZ);
            
     
        
    }
    }
}
