using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {

            var directoryInfo = new DirectoryInfo("../../../");

            var allFiles = directoryInfo.GetFiles();


            var data = new Dictionary<string, Dictionary<string, double>>();

            foreach (var file in allFiles)
            {
                double size = (double)file.Length / 1024;
                string fileName = file.Name;
                string extension = file.Extension;

                if (!data.ContainsKey(extension))
                {
                    data.Add(extension, new Dictionary<string, double>());
                }

                if (!data[extension].ContainsKey(fileName))
                {
                    data[extension].Add(fileName, size);
                }
            }

            var sortedData = data
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(k => k.Key, v => v.Value);



            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"/report.txt";


            foreach (var item in sortedData)
            {
                File.AppendAllText(path, $"{item.Key}\n");

                foreach (var file in item.Value.OrderBy(x => x.Value))
                {
                    File.AppendAllText(path, $"-- {file.Key} - {Math.Round(file.Value, 3)}kb\n");

                }
            }
        }
    }
}