using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfArticles = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>(numOfArticles);

            for (int i = 0; i < numOfArticles; i++)
            {
                string[] data = Console.ReadLine().Split(", ");

                Article article = new Article(data[0], data[1], data[2]);
                articles.Add(article);
            }

            string criteria = Console.ReadLine();
            List<Article> orderedArticles = new List<Article>();

            switch (criteria)
            {
                case "title":
                    orderedArticles = articles.OrderBy(article => article.Title).ToList();
                    break;

                case "content":
                    orderedArticles = articles.OrderBy(article => article.Content).ToList();
                    break;

                case "author":
                    orderedArticles = articles.OrderBy(article => article.Author).ToList();
                    break;
            }

            foreach (Article article in orderedArticles)
            {
                Console.WriteLine(article.ToString());
            }

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


            public override string ToString()
            {
                return ($"{this.Title} - {this.Content}: {this.Author}");
            }
        }
    }
}
