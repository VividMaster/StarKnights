using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarKnightsEpisode1
{
    class Program
    {
        static void Main(string[] args)
        {

            var game = new StarKnightsEpisode1.App.StarKnightsAPP(640,480, "Ep5isode 1", false);

            game.Run(30, 30);

        }
    }
}
