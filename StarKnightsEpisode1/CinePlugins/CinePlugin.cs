using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
namespace CinePlugins
{
    public class CinePlugin
    {
        public virtual void Init()
        {

        }
        public virtual void Update()
        {

        }
        public virtual void Draw()
        {

        }

        public virtual Control GetUI()
        {
            return null;
        }

        public virtual string GetName()
        {
            return "";
        }

        public virtual void CloseUI()
        {

        }


    }
}
