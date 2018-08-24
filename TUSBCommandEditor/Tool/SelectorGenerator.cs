using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaruCommandEditor.Tool
{
    public partial class SelectorGenerator : Form
    {
        public SelectorGenerator()
        {
            InitializeComponent();
        }

        private void LevelStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (LevelStyle.SelectedIndex)
            {
                case 0:
                    LevelLabel1.Text = "-";
                    LevelValue1.Enabled = false;
                    LevelLabel2.Text = "-";
                    LevelValue1.Enabled = false;
                    break;
                case 1:
                    LevelLabel1.Text = "値指定";
                    LevelValue1.Enabled = true;
                    LevelLabel2.Text = "-";
                    LevelValue1.Enabled = false;
                    break;
                case 2:
                    LevelLabel1.Text = "上限値";
                    LevelValue1.Enabled = true;
                    LevelLabel2.Text = "-";
                    LevelValue1.Enabled = false;
                    break;
                case 3:
                    LevelLabel1.Text = "-";
                    LevelValue1.Enabled = false;
                    LevelLabel2.Text = "下限値";
                    LevelValue1.Enabled = true;
                    break;
                case 4:
                    LevelLabel1.Text = "上限値";
                    LevelValue1.Enabled = false;
                    LevelLabel2.Text = "下限値";
                    LevelValue1.Enabled = false;
                    break;
            }
        }
    }
}
