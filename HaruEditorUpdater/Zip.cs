using System;
using System.IO;

namespace HaruEditorUpdater
{
    class Zip
    {
        /// <summary>
        /// データをZip圧縮する
        /// </summary>
        /// <param name="saveFolder">Zip書庫を格納するフォルダのパス</param>
        /// <param name="zipFileName">圧縮したデータのパス</param>
        /// <param name="sourceDirectory">圧縮するデータのパス</param>
        public void DataZip(string saveFolder, string zipFileName, string sourceDirectory)
        {
            Directory.CreateDirectory(saveFolder);
            var fastZip = new ICSharpCode.SharpZipLib.Zip.FastZip();

            //空のフォルダも書庫に入れるか
            fastZip.CreateEmptyDirectories = true;

            fastZip.CreateZip(zipFileName, sourceDirectory, true, null);
        }

        /// <summary>
        /// Zip書庫を展開する
        /// </summary>
        /// <param name="zipFileName">展開するZip書庫のパス</param>
        /// <param name="unZipDirectory">展開したファイルを保存するフォルダ(存在しないと作成される)</param>
        public void DataUnZip(string zipFileName, string unZipDirectory)
        {
            try
            {
                var fastZip = new ICSharpCode.SharpZipLib.Zip.FastZip();

                //属性を復元するかどうか
                fastZip.RestoreAttributesOnExtract = true;

                //空のフォルダの復元
                fastZip.CreateEmptyDirectories = true;

                //Zip書庫の展開
                fastZip.ExtractZip(zipFileName, unZipDirectory, null);
                File.Delete(zipFileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ファイルの展開に失敗しました");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
