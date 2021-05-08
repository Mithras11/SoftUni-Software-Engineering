using System;
using System.IO;
using System.Linq;

namespace SliceAFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using var stream = new FileStream(@"../../../input.txt", FileMode.OpenOrCreate);


            int parts = 4;
            int length = (int)Math.Ceiling(stream.Length / (decimal)parts);

            byte[] buffer = new byte[length];

            for (int i = 0; i < parts; i++)
            {
                var readBytes = stream.Read(buffer, 0, buffer.Length);

                if (readBytes < buffer.Length)
                {
                    buffer = buffer.Take(readBytes).ToArray();

                }

                using var currentFile = new FileStream($"../../../Part-{i + 1}.txt", FileMode.Create);

                currentFile.Write(buffer, 0, buffer.Length);

            }



        }
    }
}
