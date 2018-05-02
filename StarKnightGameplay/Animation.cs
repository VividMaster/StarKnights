using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarKnightGameplay
{
    public class Animation
    {
        public List<AnimFrame> Frames
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public Animation()
        {
            Frames = new List<AnimFrame>();
        }

        public override string ToString()
        {
            return Name + " Frames:" + Frames.Count();
        }
    }
}