using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarEngine.Tex;
using System.IO;
namespace StarKnightGameplay
{
    public class AnimFrame
    {

        public Tex2D Frame
        {
            get;
            set;
        }

        public System.Drawing.Bitmap RawFrame
        {
            get;
            set;
        }

        public int Duration
        {
            get;
            set;
        }

        private int FrameStart, FrameEnd, FramePan;

        public AnimFrame()
        {
            FrameStart = FrameEnd = FramePan = 0;
            Duration = 0;
            Frame = null;
            RawFrame = null;
        }
        public void Read(BinaryReader r)
        {
            int w, h;
            w = r.ReadInt32();
            h = r.ReadInt32();
            var bit = new System.Drawing.Bitmap(w, h);
            for(int y = 0; y < h; y++)
            {
                for(int x = 0; x < w; x++)
                {
                    int rc = r.ReadByte();
                    int gc = r.ReadByte();
                    int bc = r.ReadByte();
                    int ac = r.ReadByte();
                    var pix = System.Drawing.Color.FromArgb(ac, rc, gc, bc);
                    bit.SetPixel(x, y, pix);

                }
            }
            RawFrame = bit;
            Duration = r.ReadInt32();
        }
        public void Write(BinaryWriter w)
        {
            w.Write(RawFrame.Width);
            w.Write(RawFrame.Height);
            for(int y = 0; y < RawFrame.Height; y++)
            {
                for(int x = 0; x < RawFrame.Width; x++)
                {
                    var pix = RawFrame.GetPixel(x, y);
                    w.Write(pix.R);
                    w.Write(pix.G);
                    w.Write(pix.B);
                    w.Write(pix.A);
                }
            }
            w.Write(Duration);
        }

        public override string ToString()
        {
            return "Dur:" + Duration;
        }

    }
}
