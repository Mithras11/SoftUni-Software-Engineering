using System;
using System.IO;

namespace CopyBinaryFile
{
    public class Program
    {
        static void Main()
        {

            using FileStream streamReader = new FileStream(@"../../../2021.jpg", FileMode.Open);

            using FileStream streamWriter = new FileStream(@"../../../copied.jpg", FileMode.OpenOrCreate);


            byte[] buffer = new byte[1024 * 1024];


            while (true)
            {
                int bytesRead = streamReader.Read(buffer, 0, buffer.Length);

                if (bytesRead == 0)
                {
                    break;
                }

                streamWriter.Write(buffer, 0, bytesRead);


            }


        }
    }
}