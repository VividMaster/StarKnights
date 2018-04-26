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

                    var ns = new GraphSprite(t1, 64, 64);
                    G1.Add(ns);
                    ns.X = -(64 * 16) + x * 64;
                    ns.Y = -(64 * 16) + y * 64;
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
                Range = 250,
                X = -200,
                Y = -200
            };
            l2 = new GraphLight()
            {
                Range = 100,
                X = 150,
                Y = 0,
                Diffuse = new Vector3(0.8f, 0.2f, 0.2f)
            };
            G1.X = 0;
            G1.Y = 0;
            G1.Add(l2);

         }
        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, W, H);
        }
        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);
        }
        protected override void OnMouseDown(MouseButtonEventArgs e)
        {
            G1.Z = 1.0f;
            ml = true;
        }
        protected override void OnMouseUp(MouseButtonEventArgs e)
        {
            ml = false;
        }
        bool ml = false;
        protected override void OnMouseMove(MouseMoveEventArgs e)
        {
            //  G1.Z = G1.Z + (e.XDelta * 0.05f);
            //if (G1.Z < 0.2f) G1.Z = 0.2f;
            if (ml)
            {
              //  G1.Rot = G1.Rot + 2.0f;
            }
            else
            {
               G1.X = G1.X + e.XDelta;
              G1.Y = G1.Y + e.YDelta;
               // G1.Z = G1.Z + (float)e.XDelta * 0.1f;
               // if (G1.Z < 0.1f) G1.Z = 0.1f;
                            }


            //G1.Z = 1.0f;
            //G1.X = G1.X + e.XDelta;
            //G1.Y = G1.Y + e.YDelta;

           // S1.X = 100;
        }
        float ang = 0;
        protected override void OnRenderFrame(FrameEventArgs e)
        {

            MakeCurrent();
            base.OnRenderFrame(e);
            ang = ang + 1.0f;
           // G1.X = G1.X + 1.0f;
            G1.Rot = ang;



           // G1.X = G1.X + 1;
            //ang = ang + 1.0f;

           // S1.X = -100;



            GL.ClearColor(0.2f, 0, 0, 0);

            GL.Clear(ClearBufferMask.ColorBufferBit);

            Render.To2D();

            G1.Draw();

            SwapBuffers();


        }

    }

}
