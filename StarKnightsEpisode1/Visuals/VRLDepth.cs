﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarEngine.Effect;
using StarEngine.Data;
using OpenTK;
using OpenTK.Graphics.OpenGL4;
namespace StarEngine.Visuals
{
    public class VRLDepth : VRenderLayer
    {
        public EDepth3D fx = null;
        public override void Init()
        {
            fx = new EDepth3D();
        }
        public override void Render(VMesh m, VVisualizer v)
        {
            
           // m.Mat.Bind();
            fx.Bind();
            v.SetMesh(m);
            v.Bind();
            v.Visualize();
            v.Release();
            fx.Release();
            //m.Mat.Release();
        }
    }
}
