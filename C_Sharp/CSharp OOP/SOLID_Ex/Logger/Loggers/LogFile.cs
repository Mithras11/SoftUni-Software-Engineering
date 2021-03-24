namespace Logger.Loggers
{
    using System.IO;
    using System.Linq;

    public class LogFile : ILogFile
    {
        private const string FilePath = "../../../log.txt";

        public int Size => File.ReadAllText(FilePath)
            .Where(char.IsLetter)
            .Sum(s => s);

        public void Write(string content)
        {
            File.AppendAllText(FilePath, content);
        }
    }
}
