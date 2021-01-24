using System;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split('\\', StringSplitOptions.RemoveEmptyEntries);
            string name = string.Empty;
            string extension = string.Empty;

            foreach (var item in text)
            {
                if (item.Contains('.'))
                {
                    string[] file = item.Split('.', StringSplitOptions.RemoveEmptyEntries);
                    name = file[0];
                    extension = file[1];

                    break;
                }
            }

            Console.WriteLine($"File name: {name}\nFile extension: {extension}");
        }
    }
}
