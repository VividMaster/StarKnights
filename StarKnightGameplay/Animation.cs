using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace StarKnightGameplay
{
    public class Animation
    {
        public bool Loaded = false;

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

        public void Read(BinaryReader r)
        {
            Name = r.ReadString();
            int fc = r.ReadInt32();
            for(int f = 0; f < fc; f++)
            {
                AnimFrame frame = new AnimFrame();
                frame.Read(r);
                Frames.Add(frame);
            }
        }
        public void Write(BinaryWriter w)
        {
            w.Write(Name);
            w.Write(Frames.Count);
            foreach(var frame in Frames)
            {
                frame.Write(w);
            }
        }

        public override string ToString()
        {
            return Name + " Frames:" + Frames.Count();
        }
    }
}