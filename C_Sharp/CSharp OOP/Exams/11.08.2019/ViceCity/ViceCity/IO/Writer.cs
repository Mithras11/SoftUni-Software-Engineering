using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ViceCity.IO.Contracts;

namespace ViceCity.IO
{
    public class Writer :IWriter
    {
        string path = "../../../result.txt";

        public Writer()
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.Write("");
            }

        }


        public void Write(string line)
        {
            Console.Write(line);

            using (var writer = new StreamWriter(path, true))
            {
                writer.Write(line);

            }
        }

        public void WriteLine(string line)
        {
            Console.WriteLine(line);

            using (var writer = new StreamWriter(path, true))
            {
                writer.WriteLine(line);

            }
        }
    }
}
