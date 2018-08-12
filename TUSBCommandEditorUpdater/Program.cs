using System;
using System.Diagnostics;
using System.IO;

namespace TUSBCommandEditorUpdater
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("バージョンを確認しています");
                Console.WriteLine("バージョンが検出されました");
                Console.WriteLine("新しいバージョンをダウンロードしています");

                var wc = new System.Net.WebClient();
                wc.DownloadFile("https://skyblock.jp/dl/harueditor/",
                    "NewVer.zip");
                wc.Dispose();

                Console.WriteLine("ファイルを展開しています");

                var unzipPath = "NewVer";
                Console.WriteLine("展開先 : " + unzipPath);

                var zip = new Zip();
                zip.DataUnZip("NewVer.zip", unzipPath);

                Console.WriteLine("いらないファイルを削除しています");
                File.Delete(@"NewVer\dll\ICSharpCode.SharpZipLib.dll");
                File.Delete(@"NewVer\HaruEditorUpdater.exe");

                Console.WriteLine("ファイルを上書きしています");
                Microsoft.VisualBasic.FileIO.FileSystem.CopyDirectory("NewVer",
                    Directory.GetCurrentDirectory(),
                    Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs,
                    Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing);

                Console.WriteLine("いらないファイルを削除しています");
                Directory.Delete("NewVer", true);
                File.Delete("NewVer.Zip");
                Console.WriteLine("アップデートが完了しました");
                Console.WriteLine("ハルの総合コマンドエディタを起動します");
                Process.Start("ハルの総合コマンドエディタ.exe");
                Console.WriteLine("本ソフトを終了します");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Environment.Exit(0);
            }
        }
    }
}
