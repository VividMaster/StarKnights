using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarEngine.Tex;
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

        public override string ToString()
        {
            return "Dur:" + Duration;
        }

    }
}
