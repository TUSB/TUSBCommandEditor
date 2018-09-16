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

        private void SelectorGenerator_Load(object sender, EventArgs e)
        {

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

        private void DistanceStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (DistanceStyle.SelectedIndex)
            {
                case 0:
                    DistanceLabel1.Text = "-";
                    DistanceValue1.Enabled = false;
                    DistanceLabel2.Text = "-";
                    DistanceValue1.Enabled = false;
                    break;
                case 1:
                    DistanceLabel1.Text = "値指定";
                    DistanceValue1.Enabled = true;
                    DistanceLabel2.Text = "-";
                    DistanceValue1.Enabled = false;
                    break;
                case 2:
                    DistanceLabel1.Text = "上限値";
                    DistanceValue1.Enabled = true;
                    DistanceLabel2.Text = "-";
                    DistanceValue1.Enabled = false;
                    break;
                case 3:
                    DistanceLabel1.Text = "-";
                    DistanceValue1.Enabled = false;
                    DistanceLabel2.Text = "下限値";
                    DistanceValue1.Enabled = true;
                    break;
                case 4:
                    DistanceLabel1.Text = "上限値";
                    DistanceValue1.Enabled = false;
                    DistanceLabel2.Text = "下限値";
                    DistanceValue1.Enabled = false;
                    break;
            }
        }

        private void XRotationStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (XRotationStyle.SelectedIndex)
            {
                case 0:
                    XRotationLabel1.Text = "-";
                    XRotationValue1.Enabled = false;
                    XRotationLabel2.Text = "-";
                    XRotationValue1.Enabled = false;
                    break;
                case 1:
                    XRotationLabel1.Text = "値指定";
                    XRotationValue1.Enabled = true;
                    XRotationLabel2.Text = "-";
                    XRotationValue1.Enabled = false;
                    break;
                case 2:
                    XRotationLabel1.Text = "上限値";
                    XRotationValue1.Enabled = true;
                    XRotationLabel2.Text = "-";
                    XRotationValue1.Enabled = false;
                    break;
                case 3:
                    XRotationLabel1.Text = "-";
                    XRotationValue1.Enabled = false;
                    XRotationLabel2.Text = "下限値";
                    XRotationValue1.Enabled = true;
                    break;
                case 4:
                    XRotationLabel1.Text = "上限値";
                    XRotationValue1.Enabled = false;
                    XRotationLabel2.Text = "下限値";
                    XRotationValue1.Enabled = false;
                    break;
            }
        }

        private void YRotationStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (YRotationStyle.SelectedIndex)
            {
                case 0:
                    YRotationLabel1.Text = "-";
                    YRotationValue1.Enabled = false;
                    YRotationLabel2.Text = "-";
                    YRotationValue1.Enabled = false;
                    break;
                case 1:
                    YRotationLabel1.Text = "値指定";
                    YRotationValue1.Enabled = true;
                    YRotationLabel2.Text = "-";
                    YRotationValue1.Enabled = false;
                    break;
                case 2:
                    YRotationLabel1.Text = "上限値";
                    YRotationValue1.Enabled = true;
                    YRotationLabel2.Text = "-";
                    YRotationValue1.Enabled = false;
                    break;
                case 3:
                    YRotationLabel1.Text = "-";
                    YRotationValue1.Enabled = false;
                    YRotationLabel2.Text = "下限値";
                    YRotationValue1.Enabled = true;
                    break;
                case 4:
                    YRotationLabel1.Text = "上限値";
                    YRotationValue1.Enabled = false;
                    YRotationLabel2.Text = "下限値";
                    YRotationValue1.Enabled = false;
                    break;
            }
        }
    }
}
