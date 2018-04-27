using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using StarKnightsEpisode1.Draw;
using StarKnightsEpisode1.Tex;
using StarKnightsEpisode1.FXS;
using StarKnightsEpisode1.Scene;
using OpenTK.Input;

namespace StarKnightsEpisode1.App
{
    public class StarKnightsAPP : GameWindow
    {
        public Tex2D Img1;
        public FXLitImage fx;
        public static int W, H, RW, RH;
        public SceneGraph G1;
        public GraphSprite S1;
        public GraphLight l1, l2;
        public Tex2D Part1;
        public VFX.VFXParticleSystem PS1;

        public StarKnightsAPP(int w, int h, string title, bool full) : base(w, h, OpenTK.Graphics.GraphicsMode.Default, title, full ? GameWindowFlags.Fullscreen : GameWindowFlags.Default)
        {
            AppLog.Log("StarKnights Booting.");
            W = w;
            H = h;
            RW = w;
            RH = h;

        }
        protected override void OnLoad(EventArgs e)
        {

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
            Img1 = new Tex2D("Data/ship1.png", true);
            fx = new FXLitImage();
            G1 = new SceneGraph();
            S1 = new GraphSprite("Data/ship1.png", 128, 128);
            var t1 = new Tex2D("Data/tile1.jpg");

            for (int y = 0; y < 32; y++)
            {
                for (int x = 0; x < 32; x++)
                {

                    var ns = new GraphSprite(t1, 128, 128);
                    G1.Add(ns);
                    ns.X = -(128 * 16) + x * 128;
                    ns.Y = -(128 * 16) + y * 128;
                    ns.Z = 1.0f;
                }
            }
            G1.Add(S1);
            S1.X = 0;
            S1.Y = 0;

            // G1.X = -16 * 32;
            //  G1.Y = 16 * 32;
            S1.X = 0;
            S1.Y = 0;
            S1.Z = 1.3f;
            // G1.Add(S1);

            var rnd = new Random();
            for (int i = 0; i < 25; i++)
            {

                var ns = new GraphSprite(S1.ImgFrame, 128, 128);
                ns.X = rnd.Next(-500, 500);
                ns.Y = rnd.Next(-500, 500);
                ns.Z = 0.1f + (float)rnd.NextDouble() * 3;
            //    G1.Add(ns);

            }

            l1 = new GraphLight()
            {
                Range = 650,
                X = -100,
                Y = -100,
                Diffuse = new Vector3(0.4f, 1, 0.5f)
            };
            l2 = new GraphLight()
            {
                Range = 640,
                X = 0,
                Y = 0,
                Diffuse = new Vector3(1.8f, 1.2f, 1.2f)
            };
            G1.X = 0;
            G1.Y = 0;
            G1.Add(l1);
            l2.X = 300;
            VFX.VisualFX.Init();
            PS1 = new VFX.VFXParticleSystem();
            VFX.VisualFX.Add(PS1);
            VFX.VisualFX.Graph = G1;

            Part1 = new Tex2D("Data/part1.png", true);

            var b1 = new VFX.FXParticleSystem.SoftParticle(Part1);
            b1.XDrag = 0.95f;
            b1.YDrag = 0.95f;
            b1.ZDrag = 0.95f;
            b1.RDrag = 0.95f;
            PS1.XIJit = 5;
            PS1.YIJit = 2;

            PS1.PowerSmall = 1;
            PS1.PowerBig = 5;

            PS1.AddBase(b1);



         }
        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, W, H);
        }
        float la = 0;
        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);
            VFX.VisualFX.Update();
            if (spawn)
            {
                PS1.Spawn(25,mx,my, 1.0f, 0, -5, 0);
            }
            la = la + 2;

            float ra = la * (float)Math.PI / 180.0f;

            l1.X = (float)Math.Cos(ra) * 300;
            l1.Y = (float)Math.Sin(ra) * 300;

        }
        bool spawn = false;
        protected override void OnMouseDown(MouseButtonEventArgs e)
        {
            spawn = true;
    

            //G1.Z = 1.0f;
            ml = true;
            //G1.X = 0;
            //G1.Y = 0;
            //G1.Rot = G1.Rot + 5.0f;

            //if (e.Button == MouseButton.Right) G1.X = G1.X + 100;
        }
        protected override void OnMouseUp(MouseButtonEventArgs e)
        {
            spawn = false;
            ml = false;
        }
        int mx, my;
        bool ml = false;
        protected override void OnMouseMove(MouseMoveEventArgs e)
        {
            mx = e.X;
            my = e.Y;
            //  G1.Z = G1.Z + (e.XDelta * 0.05f);
            //if (G1.Z < 0.2f) G1.Z = 0.2f;
            if (ml)
            {
              //  G1.Rot = G1.Rot + 2.0f;
            }
            else
            {
           //    G1.X = G1.X + e.XDelta;
         //     G1.Y = G1.Y + e.YDelta;
              // G1.Z = G1.Z + (float)e.XDelta * 0.1f;
            //    if (G1.Z < 1.0f) G1.Z =1.0f;
                            }




            //G1.Z = 1.0f;
            //G1.X = G1.X + e.XDelta;
            //G1.Y = G1.Y + e.YDelta;

            // S1.X = 100;
            //G1.X = G1.X + e.XDelta * 5;
            //G1.Y = G1.Y + e.YDelta * 5;

       //     VFX.VisualFX.Update();
        }
        float ang = 0;
        protected override void OnRenderFrame(FrameEventArgs e)
        {

            //
            G1.Z = 5.0f;
            G1.Z = 0.7f;
            MakeCurrent();
            base.OnRenderFrame(e);
            ang = ang + 1.0f;
           // G1.X = G1.X + 1.0f;
        //   G1.Rot = ang;



           // G1.X = G1.X + 1;
            //ang = ang + 1.0f;

           // S1.X = -100;



            GL.ClearColor(0.2f, 0, 0, 0);

            GL.Clear(ClearBufferMask.ColorBufferBit);

            Render.To2D();
 //           VFX.VisualFX.Render();
            
            G1.Draw();

            VFX.VisualFX.Render();

            SwapBuffers();


        }

    }

}
