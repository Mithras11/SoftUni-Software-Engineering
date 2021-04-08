namespace AquaShop.IO
{
    using System;
    using System.IO;
    using AquaShop.IO.Contracts;

    public class Writer : IWriter
    {
        string path = "../../../result.txt";

        public Writer()
        {
            using (var writer = new StreamWriter(path))
            {
                writer.Write("");
            }
        }

        public void Write(string message)
        {
            //Console.Write(message);

            using (var writer = new StreamWriter(path, true))
            {
                writer.Write(message);
            }
        }

        public void WriteLine(string message)
        {
            //Console.WriteLine(message);

            using (var writer = new StreamWriter(path, true))
            {
                writer.WriteLine(message);
            }
        }
    }
}
