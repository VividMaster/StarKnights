using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinePlugins;
using System.Windows;
using System.Windows.Forms;
namespace EntityEditor
{
    public class EntityEditorPlugin : CinePlugin
    {

        public override Control GetUI()
        {
            return new EntityEditorControl();
        }

        public override string GetName()
        {
            return "EntityEditorPlugin";
        }

    }

    public static class PluginEntry
    {

        public static CinePlugin GetPlugin()
        {

            return new EntityEditorPlugin();

        }


    }

}
