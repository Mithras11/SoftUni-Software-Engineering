using PlayersAndMonsters.IO.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PlayersAndMonsters.IO
{
    public class FileWriter : IWriter
    {
        string path = "../../../result.txt";

        public FileWriter()
        {
            using (var streamWriter = new StreamWriter(path))
            {
                streamWriter.Write("");
            }
        }

        public void Write(string message)
        {
            using (var streamWriter = new StreamWriter(path, true))
            {
                streamWriter.Write(message);
            }
        }

        public void WriteLine(string message)
        {
            using (var streamWriter = new StreamWriter(path, true))
            {
                streamWriter.WriteLine(message);
            }
        }
    }
}
