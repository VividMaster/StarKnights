using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarKnightsEpisode1.Tex;
using OpenTK;
namespace StarKnightsEpisode1.Scene
{
    public class GraphLight : GraphNode
    {
        public Vector3 Diffuse
        {
            get;
            set;
        }
        public Vector3 Specular
        {
            get;
            set;
        }
        public float Shiny
        {
            get;
            set;
        }
        public float Range
        {
            get;
            set;
        }
        public LightType Type
        {
            get;
            set;
        }
        public bool On
        {
            get;
            set;
        }
        public bool CastShadows
        {
            get;
            set;
        }
        public GraphLight()
        {
            Diffuse = new Vector3(0.5f, 0.5f, 0.5f);
            Specular = new Vector3(0, 0, 0);
            Shiny = 0.2f;
            Range = 500;
            Type = LightType.Point;
            On = true;
            CastShadows = true;
        }
        
    }
    public enum LightType
    {
        Point,Directional,Ambient,Spot
    }
}
