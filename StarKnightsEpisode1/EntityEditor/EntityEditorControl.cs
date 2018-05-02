using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StarKnightGameplay;
namespace EntityEditor
{
    public partial class EntityEditorControl : UserControl
    {
        public EntityEditorControl()
        {
            InitializeComponent();
        }

        private void EntityEditorControl_Load(object sender, EventArgs e)
        {
            SyncClasses();
            ClassSelect.SelectedIndex = 0;
        }

        private void SyncClasses()
        {
            GameInfo.LoadClasses();
            ClassSelect.Items.Clear();
            foreach (var cls in GameInfo.Classes)
            {

                ClassSelect.Items.Add(cls);
            }
            ClassSelect.Invalidate();
            Invalidate();
        }
    }
}
