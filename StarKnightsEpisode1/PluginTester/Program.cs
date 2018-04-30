using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace PluginTester
{
    class Program
    {
        static void Main(string[] args)
        {
            var asm = Assembly.LoadFile("Plugins/EntityEditor/EntityEditor.dll");
            Console.WriteLine("Asm:" + asm.FullName);
            while (true)
            {

            }
        }
    }
}
