using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Platform.Windows;
namespace StarEngine.App
{
    public class StarControl : GLControl
    {
        public static int W, H;
        public StarControl() : base(OpenTK.Graphics.GraphicsMode.Default,4,5,OpenTK.Graphics.GraphicsContextFlags.ForwardCompatible)
        {

        }

        public void InitGL()
        {


            //GL.Enable(EnableCap.alp);
            GL.Disable(EnableCap.CullFace);
            //GL.AlphaFunc(AlphaFunction.Greater, 0.01f);
            //   GL.Disable(EnableCap.Blend);
            GL.Viewport(0, 0, Width,Height);
            //  GL.Disable(EnableCap.Lighting);
            //   GL.Disable(EnableCap.ColorMaterial);
            GL.Disable(EnableCap.ScissorTest);
            GL.Scissor(0, 0, Width, Height);
            W = Width;
            H = Height;
            StarApp.W = W;
            StarApp.H = H;
            StarApp.RW = W;
            StarApp.RH = H;
            GL.Enable(EnableCap.DepthTest);
            GL.DepthFunc(DepthFunction.Lequal);
            GL.DepthRange(0.0f, 1.0f);
            GL.ClearDepth(1.0f);
        }
        
        public void ResizeGL()
        {

            GL.Scissor(0, 0, Width, Height);
            GL.Viewport(0, 0, Width, Height);
            W = Width;
            H = Height;
            StarApp.W = W;
            StarApp.H = H;
            StarApp.RW = W;
            StarApp.RH = H;
        }

        public void Clear()
        {
            MakeCurrent();
            GL.ClearColor(0, 0, 0, 1);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            
        }

        public void Swap()
        {

            SwapBuffers();

        }

    }
}
