using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaruCommandEditor.Common
{
    class Version
    {
        /// <summary>
        /// 最新のデータが存在するか確認
        /// </summary>
        /// <returns>true = 最新版がリリースされている、false = 現在のバージョンが最新</returns>
        public static bool UpdateCheck()
        {
            bool ret = false;

            try
            {
                // インターネットに接続されているか判断
                if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
                {
                    // 現在のバージョンを取得
                    var vi = System.Diagnostics.FileVersionInfo.GetVersionInfo(
                        System.Reflection.Assembly.GetExecutingAssembly().Location);

                    using (var wc = new System.Net.WebClient())
                    {
                        var newver = wc.DownloadString("https://skyblock.jp/dl/harueditorversion/");

                        if (vi.FileVersion != newver)
                        {
                            ret = true;
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("バージョン確認サーバーが応答しないため\nバージョンの確認ができませんでした\n\n最新版がリリースされている可能性があります。\n手動でアップデートしてください。",
                                Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return ret;
        }

        public static void Update()
        {
            try
            {
                if (UpdateCheck())
                {
                    var result = MessageBox.Show("新しいバージョンがリリースされています。\n更新しますか？", Application.ProductName,
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        using (var f = new Main.DownloadForm("https://skyblock.jp/dl/harueditorupdater/",
                            Application.StartupPath + @"\HaruEditorUpdater.exe"))
                        {
                            if (f.ShowDialog() == DialogResult.OK)
                            {
                                Process.Start(Application.StartupPath + @"\HaruEditorUpdater.exe");
                                Application.Exit();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
