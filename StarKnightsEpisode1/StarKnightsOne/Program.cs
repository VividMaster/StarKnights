using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using StarEngine;
using StarEngine.App;
using StarEngine.Draw;
using StarEngine.FX;
using StarEngine.FXS;
using StarEngine.Scene;
using StarEngine.Tex;
using StarEngine.Util;
using StarEngine.VFX;

namespace StarKnightsOne
{
    class Program
    {
        public class StarKnightsOne : StarApp
         {
            public StarKnightsOne() : base(640, 480, "StarKnights", false)
            {

            }
            public override void InitApp() 
            {
               
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
                VisualFX.Init();
                PS1 = new VFXParticleSystem();
                VisualFX.Add(PS1);
                VisualFX.Graph = G1;

                Part1 = new Tex2D("Data/part1.png", true);

               // var b1 = new
                    
                
                var b1 = new SoftParticle(Part1);
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
            public override void UpdateApp()
            {

                VisualFX.Update();

               // if (spawn)
              //  {
                 //   PS1.Spawn(25, mx, my, 1.0f, 0, -5, 0);
               /// }
                //la = la + 2;

                //float ra = la * (float)Math.PI / 180.0f;

                //l1.X = (float)Math.Cos(ra) * 300;
                //l1.Y = (float)Math.Sin(ra) * 300;


              

                if (StarEngine.Input.AppInput.MouseButton[0])
                {

                    G1.Move(StarEngine.Input.AppInput.MouseMove.X / G1.Z, StarEngine.Input.AppInput.MouseMove.Y / G1.Z);

                }

                if (StarEngine.Input.AppInput.MouseButton[1])
                {

                    G1.Rot += StarEngine.Input.AppInput.MouseMove.X;

                }



                G1.Z += (StarEngine.Input.AppInput.MouseMove.Z * 0.05f) * G1.Z;
                if (G1.Z < 0.1f) G1.Z = 0.1f;
                if (G1.Z > 20) G1.Z = 20.0f;

            }
            public override void RenderApp()
            {

                Render.To2D();
                //           VFX.VisualFX.Render();

                G1.Draw();

                VisualFX.Render();

            }

            bool spawn = false;
            bool rotLock = false, posLock = false, scalLock = false;

        }

        static void Main(string[] args)
        {
            var one = new StarKnightsOne();
            one.Run();
        }
    }
}
