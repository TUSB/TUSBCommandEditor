using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TUSBCommandEditor.Main
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Common.Version.Update();
        }

        /// <summary>
        /// Giveタブを追加メニュークリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var control = new Give.GiveControl();
            AddTab(control, "Give");
        }

        /// <summary>
        /// Summonタブを追加メニュークリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SummonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var control = new Summon.SummonControl();
            AddTab(control, "Summon");
        }

        /// <summary>
        /// SetBlockタブを追加メニュークリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetBlockToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// タブを閉じるメニュークリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveTab();
        }

        /// <summary>
        /// タブを全て閉じるメニュークリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AllTabCloseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 指定したコントロールのタブを開きます
        /// </summary>
        /// <param name="control">コントロール</param>
        /// <param name="name">タブ名</param>
        private void AddTab(Control control, string name)
        {
            tabControl1.TabPages.Add(name);
            var page = tabControl1.TabPages[tabControl1.TabPages.Count - 1];
            page.Controls.Add(control);
            tabControl1.SelectedTab = page;
        }

        /// <summary>
        /// 開いているタブの削除します
        /// </summary>
        private void RemoveTab()
        {
            int index = tabControl1.SelectedIndex;

            if (index > 0)
            {
                var page = tabControl1.TabPages[index];
                page.Controls.Clear();
                tabControl1.TabPages.Remove(page);
                tabControl1.SelectedIndex = index - 1;
            }
            else
            {
                MessageBox.Show("このページは削除することはできません", Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
