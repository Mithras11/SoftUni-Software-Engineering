using System;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            Article article = new Article(input[0], input[1], input[2]);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(": ");

                switch (command[0])
                {
                    case "Edit":
                        article.Edit(command[1]);
                        break;

                    case "ChangeAuthor":
                        article.ChangeAuthor(command[1]);
                        break;

                    case "Rename":
                        article.Rename(command[1]);
                        break;


                }

            }
              
              

            Console.WriteLine(article.ToString());

        }

        public class Article
        {
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

            public Article(string title, string content, string author)
            {
                this.Title = title;
                this.Content = content;
                this.Author = author;
            }

            public string Edit(string newContent)
            {
                this.Content = newContent;
                return this.Content;

            }

            public string ChangeAuthor(string newAuthor)
            {
                this.Author = newAuthor;
                return this.Author;
            }

            public string Rename(string newTitle)
            {
                this.Title = newTitle;
                return this.Title;
            }

            public override string ToString()
            {
                return ($"{this.Title} - {this.Content}: {this.Author}");
            }
        }
    }
}
