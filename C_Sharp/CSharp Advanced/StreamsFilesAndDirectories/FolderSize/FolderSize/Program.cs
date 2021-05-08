using System;
using System.IO;

namespace FolderSize
{
    class Program
    {
        static void Main(string[] args)
        {
            var files = Directory.GetFiles(@"../../../");

            double size = 0;

            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);

                size += fileInfo.Length;
            }

            size = size / 1024 / 1024;

            File.WriteAllText(@"../../../output.txt", size.ToString());
        }
    }
}
