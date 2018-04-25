using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using System.Drawing;

namespace StarKnightsEpisode1.Tex
{
    public class Tex2D : TexBase
    {

        public static byte[] TmpStore = null;
        public Tex2D(string path,bool alpha=false)
        {

            if (TmpStore == null)
            {

                TmpStore = new byte[4096 * 4096 * 4];

            }
            
            GL.Enable(EnableCap.Texture2D);
            ID = GL.GenTexture();

            GL.BindTexture(TextureTarget.Texture2D, ID);

            Bitmap img = new Bitmap(path);
            //System.Drawing.Imaging.BitmapData dat = img.LockBits( new Rectangle(0, 0, img.Width, img.Height), System.Drawing.Imaging.ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.);

            Width = img.Width;
            Height = img.Height;
            Alpha = alpha;

            //GL.TexImage2D(TextureTarget.Texture2D,0,PixelInternalFormat.)



            int pi = 0;
            for(int y = 0; y < img.Height; y++)
            {
                for(int x = 0; x < img.Width; x++)
                {
                    var pix = img.GetPixel(x, y);
                    TmpStore[pi++] = pix.R;
                    TmpStore[pi++] = pix.G;
                    TmpStore[pi++] = pix.B;
                    if (alpha)
                    {
                        TmpStore[pi++] = pix.A;
                    }

                }
            }


            if (alpha)
            {
                GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba, Width, Height, 0, PixelFormat.Rgba, PixelType.UnsignedByte, TmpStore);
            }
            else
            {
                GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgb, Width, Height, 0, PixelFormat.Rgb, PixelType.UnsignedByte, TmpStore);
            }

            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapS,(int)TextureWrapMode.Clamp);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapT,(int)TextureWrapMode.Clamp);

            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Linear);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Linear);

            GL.BindTexture(TextureTarget.Texture2D, 0);

        }

        public override void Bind(int texunit)
        {
            GL.ActiveTexture(TextureUnit.Texture0 + texunit);
            GL.Enable(EnableCap.Texture2D);
            GL.BindTexture(TextureTarget.Texture2D, ID);
        }
        public override void Unbind(int texunit)
        {
            GL.ActiveTexture(TextureUnit.Texture0 + texunit);
            GL.BindTexture(TextureTarget.Texture2D, 0);
            GL.Disable(EnableCap.Texture2D);

        }
    }
}
