using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarKnightGameplay
{
    public class AnimationSet
    {
        public List<Animation> Anims
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public AnimationSet()
        {
            Anims = new List<Animation>();
            Name = "";
        }

    }
}
