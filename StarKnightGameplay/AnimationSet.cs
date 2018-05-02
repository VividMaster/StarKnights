using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
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
        public bool Loaded = false;
        public void Load()
        {
            if (Loaded) return;
            Loaded = true;
            var fs = new FileStream("Data/AnimationSets/" + Name + "/" + Name + ".anims", FileMode.Open, FileAccess.Read);
            BinaryReader r = new BinaryReader(fs);
            Name = r.ReadString();
            int ac = r.ReadInt32();
            for(int i = 0; i < ac; i++)
            {
                var na = new Animation();
                na.Read(r);
                Anims.Add(na);
            }

            fs.Close();
        }
        public void Save()
        {
            Directory.CreateDirectory("Data/AnimationSets/" + Name + "/");
            var fs = new FileStream("Data/AnimationSets/" + Name + "/" + Name + ".anims", FileMode.Create, FileAccess.Write);
            BinaryWriter w = new BinaryWriter(fs);
            w.Write(Name);
            w.Write(Anims.Count);
            foreach(var anim in Anims)
            {
                anim.Write(w);
            }

            fs.Flush();
            fs.Close();
            fs = null;
            w = null;

        }

        public override string ToString()
        {
            return Name;
        }

    }
}
