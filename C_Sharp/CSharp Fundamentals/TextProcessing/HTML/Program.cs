using System;

namespace HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            string content = Console.ReadLine();
            WriteLine(title, content);

            string comments = string.Empty;

            while ((comments = Console.ReadLine()) != "end of comments")
            {
                WriteComments(comments);
            }
        }

        static void WriteLine(string title, string content)
        {
            Console.WriteLine("<h1>");
            Console.WriteLine($"    {title}");
            Console.WriteLine("</h1>");
            Console.WriteLine("<article>");
            Console.WriteLine($"    {content}");
            Console.WriteLine("</article>");
        }

        static void WriteComments(string comments)
        {
            Console.WriteLine("<div>");
            Console.WriteLine($"    {comments}");
            Console.WriteLine("</div>");
        }
    }
}
