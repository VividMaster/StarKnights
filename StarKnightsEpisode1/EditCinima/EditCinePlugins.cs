using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using StarEngine;
using StarEngine.App;
using StarEngine.Draw;
using StarEngine.FX;
using StarEngine.FXS;
using StarEngine.Input;
using StarEngine.Scene;
using StarEngine.Tex;
using StarEngine.Util;
using StarEngine.VFX;
using StarEngine.Script;
using StarEngine.Reflect;
using System.Reflection;
using StarEngine.Archive;
using StarKnightGameplay;

namespace EditCinima
{
    partial class EditCine
    {

        public void InitPlugins()
        {

            foreach (var p in Plugins)
            {
                Console.WriteLine("Obtaining plugin UI:" + p.GetName());
                var pc = p.GetUI();
                var tb = new TabPage(p.GetName());
                pc.Dock = DockStyle.Fill;
                tb.Controls.Add(pc);
                UI2.TabPages.Add(tb);


            }

        }

        public void LoadPlugins()
        {
            Console.WriteLine("Scanning plugins.");
            foreach (var pf in new DirectoryInfo("Plugins").GetDirectories())
            {
                var full = "Plugins/" + pf.Name + "/" + pf.Name + ".dll";
                Console.WriteLine("Loading plugin:" + pf.Name + " FullPath:" + full);
                LoadPlugin(full, pf.Name.Replace(".dll", ""));
            }
            Console.WriteLine("Plugins loaded.");
        }
        public void LoadPlugin(string path, string name)
        {
            var asm = Assembly.LoadFrom(path);
            Console.WriteLine("Loaded Asm:" + asm.FullName);
            foreach (var tp in asm.GetTypes())
            {
                Console.WriteLine("Found Type:" + tp.Name);
            }
            Console.WriteLine("Obtaining Type:" + name + ".PluginEntry");

            var et = asm.GetType(name + ".PluginEntry");
            MethodInfo gp = et.GetMethod("GetPlugin");
            Console.WriteLine("Done:" + gp.Name);
            Console.WriteLine("Static:" + gp.IsStatic);

            var pi = gp.Invoke(null, null);
            Console.WriteLine("Got Plugin:" + pi.GetType().FullName);

            var pa = pi as CinePlugins.CinePlugin[];
            foreach (var pp in pa)
            {
                Plugins.Add(pp);
            }



            /*
            var et = asm.GetType(name + ".PluginEntry").GetConstructor(Type.EmptyTypes);
            var nt = et.Invoke(null);

            Console.WriteLine("Succesfull.");
            var em = nt.GetType().GetMethod("GetPlugin");

            Console.WriteLine("GetPluginName:" + em.FullName);
            
            Console.WriteLine("Getting entry method.");
            var plug = em.Invoke(em, null);
            Console.WriteLine("Done.");

            var pi = plug as CinePlugins.CinePlugin;

            Console.WriteLine("PluginReturnedName:" + pi.GetName());
            */




            Console.WriteLine("Plugin scanned.");


        }

    }
}
