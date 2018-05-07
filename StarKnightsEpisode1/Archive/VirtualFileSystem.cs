using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace StarEngine.Archive
{
    public class VirtualFileSystem
    {
        public string Name
        {
            get;
            set;
        }
        public string Path
        {
            get;
            set;
        }

        public List<VirtualEntry> Enteries = new List<VirtualEntry>();

        public long Size
        {
            get
            {
                long s = 0;
                foreach(var e in Enteries)
                {
                    s += e.Size;
                }
                return s;
            }

        }

        public VirtualEntry Find(string name,string path)
        {

            foreach(var entry in Enteries)
            {
                if(entry.Name == name && entry.Path == path)
                {
                    return entry;
                }
            }
            return null;
        }
        public void ReadToc(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryReader r = new BinaryReader(fs);

            int ec = r.ReadInt32();
            for(int i = 0; i < ec; i++)
            {
                var ne = new VirtualEntry();
                ne.Name = r.ReadString();
                ne.Path = r.ReadString();
          //      ne.ImgW = r.ReadInt32();
         //       ne.ImgH = r.ReadInt32();
                ne.Start = r.ReadInt64();
                ne.Size = r.ReadInt64();
                Enteries.Add(ne);
            }

        }
        public VirtualEntry Load(string name,string path)
        {
            name = name.ToLower();
            path = path.ToLower();
            int i = 0;
            VirtualEntry e = null;
            foreach(var entry in Enteries)
            {
                Console.WriteLine("Name:" + entry.Name);
            //    Console.WriteLine("Path:" + entry.Path);
                if(entry.Name.ToLower() == name)
                {
                //    if(entry.Path.ToLower().Contains(path))
                  //  {
                        Console.WriteLine("Found:" + name);
                        Console.WriteLine("Start:" + entry.Start);
                        Console.WriteLine("Size:" + entry.Size);
                        Console.WriteLine("Index:" + i);
                    if (entry.Loaded == false)
                    {
                        FileStream fs = new FileStream(arcpath, FileMode.Open, FileAccess.Read);
                        BinaryReader r = new BinaryReader(fs);
                        entry.RawData = new byte[(int)entry.Size];
                        fs.Seek(entry.Start, SeekOrigin.Begin);
                        r.Read(entry.RawData, 0, (int)entry.Size);
                        byte[] od;
                        ZLib.DecompressData(entry.RawData, out od);
                        entry.RawData = od;
                        fs.Close();

                        r = null;
                        fs = null;
                        entry.Loaded = true;
                    }
                        return entry;
                   // }
                }
                i++;
            }
            return e;
        }
        public void Update(string path)
        {
            arcpath = path + "arc.vfs";
            tocpath = path + "arc.toc";
            if (new FileInfo(path + "arc.toc").Exists)
            {
                ReadToc(path + "arc.toc");
             
            }
            else
            {
                ScanFolder(path);
                SaveTOC(path);
                SaveFS(path);
            }
        }
        string arcpath = "";
        string tocpath = "";
        public void SaveFS(string path)
        {

           
            FileStream fs = new FileStream(path + "arc.vfs", FileMode.Create, FileAccess.Write);
            BinaryWriter w = new BinaryWriter(fs);

            foreach(var e in Enteries)
            {

                w.Write(e.RawData);
                
            }

            fs.Flush();
            fs.Close();
            w = null;
            fs = null;



        }
        public void SaveTOC(string path)
        {

            FileStream fs = new FileStream(path+"arc.toc", FileMode.Create, FileAccess.Write);
            BinaryWriter w = new BinaryWriter(fs);


            long start = 0;
            w.Write(Enteries.Count);
            foreach(var e in Enteries)
            {
                w.Write(e.Name);
                w.Write(e.Path);
                
                w.Write(start);
                w.Write(e.Size);
                
                start += e.Size;
            }
            fs.Flush();
            fs.Close();
            fs = null;
            w = null;



        }
        public void ScanFolder(string path)
        {

            var fl = new DirectoryInfo(path).GetFiles();
            var dl = new DirectoryInfo(path).GetDirectories();
            foreach(var file in fl)
            {
                var fi = new FileInfo(file.FullName);
                var fe = Find(fi.Name, path);
                if (fe != null)
                {
                    if(fe.Size!=fi.Length)
                    {
                        
                    }
                }
                else
                {
                    var entry = new VirtualFile();
                    entry.Name = fi.Name;
                    entry.Path = path;
                    entry.Size = fi.Length;
                    entry.RawData = File.ReadAllBytes(fi.FullName);
                    byte[] od = null;
                    int os = entry.RawData.Length;
                    ZLib.CompressData(entry.RawData, out od);
                    entry.RawData = od;
                    
                    entry.Size = entry.RawData.Length;
                    Console.WriteLine("Original:" + os + " New:" + od.Length);
                    Enteries.Add(entry);
                }



            }
            foreach(var dir in dl)
            {
                ScanFolder(dir.FullName);
            }


        }

    }
    public class VirtualEntry
    {
        public string Name
        {
            get;
            set;
        }
     
        public string Path
        {
            get;
            set;
        }
        public byte[] RawData
        {
            get;
            set;
        }
        public long Start
        {
            get;
            set;
        }
        public long Size
        {
            get;
            set;
        }
        public bool Loaded
        {
            get;
            set;
        }
        public VirtualEntry()
        {
            Loaded = false;
            Start = Size = 0;
            Name = "";
            Path = "";
        }
        public byte[] ToBytes()
        {
            return RawData;
        }
    }
    public class VirtualFile : VirtualEntry
    {
        
    }
}
