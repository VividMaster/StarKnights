﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace StarKnightGameplay
{
    public class GameInfo
    {

        public static List<CharClass> Classes = new List<CharClass>();
        public static List<Entity> Entities = new List<Entity>();

        public static void LoadClasses()
        {

            Classes.Clear();
            var cs = new DirectoryInfo("Data/Classes/").GetDirectories();
            foreach(var d in cs)
            {

                var cc = new CharClass();
                cc.Load("Data/Classes/" + d.Name + "/" + d.Name + ".class");
                Classes.Add(cc);

            }

        }

    }
}
