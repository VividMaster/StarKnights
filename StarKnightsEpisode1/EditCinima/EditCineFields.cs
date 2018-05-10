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

        public VirtualFileSystem VFS;
        public static TabControl UIP;
        public static EditCine Main = null;
        public static string DefScript;
        public ScriptName ChooseScriptNAme = null;
        public List<CinePlugins.CinePlugin> Plugins = new List<CinePlugins.CinePlugin>();
        public Tex2D MoveIcon, RotateIcon, ScaleIcon, LightIcon;
        float mxi, myi, mzi, mdrag;
        public static SceneGraph EditGraph = null;
        public static GraphNode EditNode = null;
        public static Dictionary<TreeNode, GraphNode> NodeMap = new Dictionary<TreeNode, GraphNode>();
        public int EditMode = 0;
        private string oldNodeName = "";
        private TreeNode renameNode = null;
        bool render = false;
        string[] dragFiles = null;
        public int DefW = 128, DefH = 128;
        public static GraphNode NewScriptNode = null;
        public bool MoveOn = false, RotateOn = false, ScaleOn = false;
        public bool ShowIcons = false;
        public float IconsAlpha = 0.0f;
        bool MouseIn = false;
        float MXD, MYD;
        bool MapIn = false;
        public List<PluginForm> PlugForms = new List<PluginForm>();
        private int utc = 0;
        public int MX, MY;

    }
}
