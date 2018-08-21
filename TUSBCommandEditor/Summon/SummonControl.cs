using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TUSBCommandEditor.Summon
{
    public partial class SummonControl : UserControl
    {
        public SummonControl()
        {
            InitializeComponent();
        }

        private void EntityNameGenerate_Click(object sender, EventArgs e)
        {
            string json = Tool.JsonGenerator.ShowForm(EntityName.Text);
            if (json != null) { EntityName.Text = json; }
        }
    }
}
