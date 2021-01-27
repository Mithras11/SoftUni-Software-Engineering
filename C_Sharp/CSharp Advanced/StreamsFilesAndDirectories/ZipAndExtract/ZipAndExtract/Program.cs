using System;
using System.IO;
using System.IO.Compression;

namespace _06ZipAndExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            string picPath = @"../../../copyMe.png";
            string zipFile = @"../../../result.zip";
            string extractPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "ExtractedZip");

            using (var archive = ZipFile.Open(zipFile, ZipArchiveMode.Create))
            {
                archive.CreateEntryFromFile(picPath, "copyMe.png");
            }


            ZipFile.ExtractToDirectory(zipFile, extractPath);

        }
    }
}