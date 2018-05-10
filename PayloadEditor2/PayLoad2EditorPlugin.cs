using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinePlugins;
using System.Windows;
using System.Windows.Forms;

namespace PayLoad2Editor
{
    public class PayLoadEditorPlugin : CinePlugin
    {

        public override Control GetUI()
        {
            return new PayLoad2EditorControl();
        }

        public override string GetName()
        {
            return "PayLoadEditorPlugin";
        }

    }



    public static class PluginEntry
    {

        public static CinePlugin[] GetPlugin()
        {

            return PluginArray(new PayLoadEditorPlugin());

        }

        public static CinePlugin[] PluginArray(params CinePlugin[] plugs)
        {
            return plugs;
        }


    }
}
