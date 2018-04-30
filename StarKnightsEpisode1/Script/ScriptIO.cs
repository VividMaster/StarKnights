using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csscript;
using CSScriptLibrary;
using System.Reflection;
namespace StarEngine.Script
{
    public class ScriptIO
    {
        public static ScriptCaller LoadScript(string script,string typename)
        {

            return new ScriptCaller(CSScript.LoadFile(script, "ScriptDLL.dll", true, "StarEngine.dll").CreateInstance(typename));
            
            
        }
    }
    public class ScriptCaller
    {
        public Assembly Asmw
        {
            get;
            set;
        }

        public object Class
        {
            get;
            set;
        }

        public ScriptCaller(object asm)
        {
            Class = asm;            
        }

        public ScriptMethod GetMethod(string name,params object[] pars)
        {

            //return new ScriptMethod(Class.)
            return null;
        }

    }
    public class ScriptMethod
    {
        MethodDelegate Meth
        {
            get;
            set;
        }
        public ScriptMethod(MethodDelegate meth)
        {

            Meth = meth;

        }
        public void Call()
        {
            Meth();
        }

        public object CallR()
        {
            return Meth();
        }

        public void Call(params object[] pars)
        {
            Meth(pars);
        }

        public object CallR(params object[] pars)
        {
            return Meth(pars);
        }

    }
}
