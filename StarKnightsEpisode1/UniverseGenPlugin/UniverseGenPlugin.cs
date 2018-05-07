using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinePlugins;
using System.Windows;
using System.Windows.Forms;

namespace UniverseGen
{
    public class UniverseGenPlugin : CinePlugin
    {

        public override Control GetUI()
        {
            return new UniverseGenControl();
        }

        public override string GetName()
        {
            return "UniverseGenPlugin";
        }

    }

   

    public static class PluginEntry
    {

        public static CinePlugin[] GetPlugin()
        {

            return PluginArray(new UniverseGenPlugin());

        }

        public static CinePlugin[] PluginArray(params CinePlugin[] plugs)
        {
            return plugs;
        }


    }
}
