using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarEngine.Script;
using System.ComponentModel;
namespace StarEngine.Scene
{
    public class GraphScript : GraphNode
    {



        [Description("The actual script code-link"),Category("Code")]
        public ScriptCaller Script
        {
            get;
            set;
        }

        [Description("URL/Path of the script."),Category("IO")]
        public string ScriptFile
        {
            get
            {
                return _SFile;
            }
            set
            {
                //Console.WriteLine("Script:" + new System.IO.FileInfo(value).Name);
               // while (true)
               

               
                Script = ScriptIO.LoadScript(value,new System.IO.FileInfo(value).Name.Replace(".cs",""));


                _SFile = value;
               
            }
        }
        public string _SFile = "";

       
        


    }
}
