using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarEngine.Scene;
namespace StarEngine.Script
{
    public class ScriptNode : ScriptObj
    {
        public GraphNode Node
        {
            get;
            set;
        }

        public virtual void Render()
        {

        }

    }
}
