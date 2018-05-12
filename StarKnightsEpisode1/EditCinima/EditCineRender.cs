using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using StarEngine;
using StarEngine.App;
using StarEngine.Draw;
using StarEngine.FX;
using StarEngine.FXS;
using StarEngine.Input;
using StarEngine.Scene;
using StarEngine.Tex;
using StarEngine.Util;
using StarEngine.VFX;
using StarEngine.Script;
using StarEngine.Reflect;
using System.Reflection;
using StarEngine.Archive;
using StarKnightGameplay;
namespace EditCinima
{
    partial class EditCine
    {

        private void Visual_Paint_1(object sender, PaintEventArgs e)
        {
            //     Console.WriteLine("Drawn.");
            render = true;
            ResizeUI();
            Visual.Clear();

            /*
            Render.To2D();


            EditGraph.Draw();

            if (ShowIcons || IconsAlpha > 0.0f)
            {
                Render.Col = new OpenTK.Vector4(1, 1, 1, IconsAlpha);
                Render.SetBlend(BlendMode.Alpha);
                if (MoveOn)
                {
                    Render.Col = new OpenTK.Vector4(0.5f, 0.5f, 0.5f, 0.5f * IconsAlpha);
                    Render.Rect(20, 20, 32, 32);
                }
                Render.Col = new OpenTK.Vector4(1, 1, 1, IconsAlpha);
                Render.Image(20, 20, 32, 32, MoveIcon);
                if (RotateOn)
                {
                    Render.Col = new OpenTK.Vector4(0.5f, 0.5f, 0.5f, 0.5f * IconsAlpha);
                    Render.Rect(65, 20, 32, 32);
                }
                Render.Col = new OpenTK.Vector4(1, 1, 1, IconsAlpha);
                Render.Image(65, 20, 32, 32, RotateIcon);

                if (ScaleOn)
                {
                    Render.Col = new OpenTK.Vector4(0.5f, 0.5f, 0.5f, 0.5f * IconsAlpha);
                    Render.Rect(110, 20, 32, 32);
                }
                Render.Col = new OpenTK.Vector4(1, 1, 1, IconsAlpha);
                Render.Image(110, 20, 32, 32, ScaleIcon);

            }

            Render.Col = new OpenTK.Vector4(1, 1, 1, 1);

            switch (EditMode)
            {
                case 1:
                    Render.Image(20, Visual.Height - 40, 32, 32, MoveIcon);
                    break;
                case 2:
                    Render.Image(20, Visual.Height - 40, 32, 32, RotateIcon);
                    break;
                case 3:
                    Render.Image(20, Visual.Height - 40, 32, 32, ScaleIcon);
                    break;
            }
            */
           // ent1.Rot(new OpenTK.Vector3(0, r, 0), Space.Local);
            r = r + 1;

            light1.Diff = new OpenTK.Vector3(2,2,1);
            light1.Pos(new OpenTK.Vector3(StarEngine.Util.Maths.Cos(r)*50, 30,StarEngine.Util.Maths.Sin(r)*50), Space.Local);

     //       cam1.LocalPos = new OpenTK.Vector3(0, 0, 30);

            //light1.LocalPos = cam1.LocalPos;
            //light1.LocalTurn = cam1.LocalTurn;

            scene3d.Render();

            Visual.Swap();
            render = false;
        }
        private float r = 0;

    }
}
