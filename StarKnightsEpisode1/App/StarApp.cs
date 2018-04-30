using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using StarEngine.Draw;
using StarEngine.Tex;
using StarEngine.FXS;
using StarEngine.Scene;
using OpenTK.Input;

namespace StarEngine.App
{
    public class StarApp : GameWindow
    {
        public Tex2D Img1;
        public FXLitImage fx;
        public static int W, H, RW, RH;
        public SceneGraph G1;
        public GraphSprite S1;
        public GraphLight l1, l2;
        public Tex2D Part1;
        public VFX.VFXParticleSystem PS1;

        public StarApp(int w, int h, string title, bool full) : base(w, h, OpenTK.Graphics.GraphicsMode.Default, title, full ? GameWindowFlags.Fullscreen : GameWindowFlags.Default)
        {
            AppLog.Log("StarKnights Booting.");
            W = w;
            H = h;
            RW = w;
            RH = h;

        }
        protected override void OnLoad(EventArgs e)
        {
            this.CursorVisible = false;
            // GL.Disable(EnableCap.DepthTest);
            GL.Enable(EnableCap.AlphaTest);
            GL.Disable(EnableCap.CullFace);
            GL.AlphaFunc(AlphaFunction.Greater, 0.01f);
            //   GL.Disable(EnableCap.Blend);
            GL.Viewport(0, 0, W, H);
            //  GL.Disable(EnableCap.Lighting);
            //   GL.Disable(EnableCap.ColorMaterial);
            GL.Disable(EnableCap.ScissorTest);
            GL.Scissor(0, 0, W, H);
            InitApp();
           

         }

        public virtual void InitApp()
        {

        }
        public virtual void UpdateApp()
        {

        }

        public virtual void RenderApp()
        {

        }

        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, W, H);
        }
        float la = 0;
        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);
            cms = OpenTK.Input.Mouse.GetState();
            if (cms != pms)
            {

                Input.AppInput.MouseMove = new Vector3(cms.X - pms.X, cms.Y - pms.Y, cms.WheelPrecise - pms.WheelPrecise);

            }
            else
            {
                Input.AppInput.MouseMove = new Vector3(0, 0, 0);
            }
            pms = cms;

            UpdateApp();

        }
        //V//ector3 MouseMove;
        MouseState cms, pms;
       
        protected override void OnMouseDown(MouseButtonEventArgs e)
        {

            switch (e.Button)
            {
                case MouseButton.Left:
                    //        posLock = true;
                    Input.AppInput.MouseButton[0] = true;
                    break;
                case MouseButton.Right:
                    Input.AppInput.MouseButton[1] = true;
                    break;
                case MouseButton.Button1:
                    Input.AppInput.MouseButton[2] = true;
                    break;

            }

            //spawn = true;

            //G1.Z = 1.0f;
            //ml = true;

            //G1.X = 0;
            //G1.Y = 0;
            //G1.Rot = G1.Rot + 5.0f;

            //if (e.Button == MouseButton.Right) G1.X = G1.X + 100;
        }
        protected override void OnMouseUp(MouseButtonEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButton.Left:
                    Input.AppInput.MouseButton[0] = false;
                    break;
                case MouseButton.Right:
                    Input.AppInput.MouseButton[1] = false;
                    break;
                case MouseButton.Button1:
                    Input.AppInput.MouseButton[2] = false;
                    break;

            }


            //spawn = false;
            //ml = false;
        }
        int mx, my;
        bool ml = false;
       
        protected override void OnRenderFrame(FrameEventArgs e)
        {

            MakeCurrent();

            GL.ClearColor(0.2f, 0, 0, 0);

            GL.Clear(ClearBufferMask.ColorBufferBit);

            RenderApp();
            
      

            

           

            SwapBuffers();


        }

    }

}
