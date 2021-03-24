namespace Logger.Core.IO
{
    using System.IO;
    public class FileReader : IReader
    {
        private string[] fileLines;
        private int pointer;
        public FileReader(string path = "../../../input.txt")
        {
            this.fileLines = File.ReadAllLines(path);
        }
        public string ReadLine()
        {
            return fileLines[this.pointer++];
        }
    }
}
