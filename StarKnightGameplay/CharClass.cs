using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace StarKnightGameplay
{
    public class CharClass
    {

        public string Name
        {
            get;
            set;
        }

        public string UpperClass
        {
            get;
            set;
        }

        public float Attack
        {
            get;
            set;
        }

        public float Defense
        {
            get;
            set;
        }

        public float Tech
        {
            get;
            set;
        }

        public float IQ
        {
            get;
            set;
        }

        public float Comm
        {
            get;
            set;
        }

        public System.Drawing.Bitmap Icon
        {
            get;
            set;
        }

        public CharClass()
        {
            Name = "None";
            Attack = 0.3f;
            Defense = 0.3f;
            IQ = 0.3f;
            Comm = 0.3f;
            Tech = 0.3f;
        }

        public void Load(string file)
        {

            FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read);
            var r = new BinaryReader(fs);

            Name = r.ReadString();
            UpperClass = r.ReadString();
            Attack = r.ReadSingle();
            Defense = r.ReadSingle();
            Tech = r.ReadSingle();
            IQ = r.ReadSingle();
            Comm = r.ReadSingle();

            int w = r.ReadInt32();
            int h = r.ReadInt32();

            Icon = new System.Drawing.Bitmap(w, h);

            for(int y = 0; y < h; y++)
            {
                for(int x = 0; x < w; x++)
                {
                    var c = System.Drawing.Color.FromArgb(255, (int)r.ReadByte(), (int)r.ReadByte(), (int)r.ReadByte());
                    Icon.SetPixel(x, y, c);

                }
            }

            fs = null;

        }

        public void Save(string file)
        {

            if(Icon == null)
            {
                return;
            }

            FileStream fs = new FileStream(file, FileMode.Create, FileAccess.Write);
            var w = new BinaryWriter(fs);

            w.Write(Name);
            w.Write(UpperClass);
            w.Write(Attack);
            w.Write(Defense);
            w.Write(Tech);
            w.Write(IQ);
            w.Write(Comm);

            w.Write(Icon.Width);
            w.Write(Icon.Height);

            for(int y = 0; y < Icon.Height; y++)
            {
                for(int x = 0; x < Icon.Width; x++)
                {

                    var pix = Icon.GetPixel(x, y);
                    w.Write((byte)pix.R);
                    w.Write((byte)pix.G);
                    w.Write((byte)pix.B);


                }
                

            }

            fs.Flush();
            fs.Close();
            fs = null;

        }

        public override string ToString()
        {
            return UpperClass + ":" + Name;
        }

    }
}
