using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TUSBCommandEditor.Main
{
    public partial class DownloadForm : Form
    {
        /// <summary>
        /// ダウンロードURL
        /// </summary>
        private string _url;

        /// <summary>
        /// セーブパス
        /// </summary>
        private string _savepath;

        private WebClient downloadClient = null;

        public DownloadForm(string url, string savepath)
        {
            InitializeComponent();

            _url = url;
            _savepath = savepath;
        }

        private void DownloadForm_Load(object sender, EventArgs e)
        {
            //WebClientの作成
            if (downloadClient == null)
            {
                downloadClient = new System.Net.WebClient();
                //イベントハンドラの作成
                downloadClient.DownloadProgressChanged +=
                    new System.Net.DownloadProgressChangedEventHandler(
                        downloadClient_DownloadProgressChanged);
                downloadClient.DownloadFileCompleted +=
                    new System.ComponentModel.AsyncCompletedEventHandler(
                        downloadClient_DownloadFileCompleted);
            }

            //非同期ダウンロードを開始する
            downloadClient.DownloadFileAsync(new Uri(_url), _savepath);
        }

        private void downloadClient_DownloadProgressChanged(object sender,
            System.Net.DownloadProgressChangedEventArgs e)
        {
            label2.Text = string.Format("{0}% ({1}byte 中 {2}byte) ",
                e.ProgressPercentage, e.TotalBytesToReceive, e.BytesReceived);
            progressBar1.Value = e.ProgressPercentage;
        }

        private void downloadClient_DownloadFileCompleted(object sender,
            System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                DialogResult = DialogResult.Cancel;
            }
            else if (e.Error != null)
            {
                DialogResult = DialogResult.Abort;
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
