using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinePlugins;
using System.Windows;
using System.Windows.Forms;

namespace ClassEditor
{
    public class ClassEditorPlugin : CinePlugin
    {

        public override Control GetUI()
        {
            return new ClassEditorControl();
        }

        public override string GetName()
        {
            return "ClassEditorPlugin";
        }

    }

    public class ClassInspectorPlugin : CinePlugin
    {

        public override Control GetUI()
        {

            return new ClassInspectorControl();
           
        }

        public override string GetName()
        {
            return "ClassInspectorPlugin";
        }

    }

    public static class PluginEntry
    {

        public static CinePlugin[] GetPlugin()
        {

            return PluginArray(new ClassEditorPlugin(), new ClassInspectorPlugin());

        }

        public static CinePlugin[] PluginArray(params CinePlugin[] plugs)
        {
            return plugs;
        }


    }
}
