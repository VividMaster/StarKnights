using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarEngine.Scene;
using StarEngine.Script;
namespace StarKnightGameplay
{
    public class Entity
    {

        public GraphNode Node
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public List<string> Scripts = new List<string>();



        public Entity()
        {
            Name = ""; ;
            Node = null;

        }

    }
}
