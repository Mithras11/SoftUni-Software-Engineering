using System;
using System.Collections.Generic;
using System.Linq;

namespace AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> phrases = new List<string>(6);
            phrases.Add("Excellent product");
            phrases.Add("Such a great product.");
            phrases.Add("I always use that product.");
            phrases.Add("Best product of its category.");
            phrases.Add("Exceptional product.");
            phrases.Add("I can’t live without this product");

            List<string> events = new List<string>(6);
            events.Add("Now I feel good.");
            events.Add("I have succeeded with this product.");
            events.Add("Makes miracles. I am happy of the results!");
            events.Add("I cannot believe but now I feel awesome.");
            events.Add("Try it yourself, I am very satisfied.");
            events.Add("I feel great!");

            List<string> authors = new List<string>(8);
            authors.Add("Diana");
            authors.Add("Petya");
            authors.Add("Stella");
            authors.Add("Elena");
            authors.Add("Katya");
            authors.Add("Iva");
            authors.Add("Annie");
            authors.Add("Eva");

            List<string> cities = new List<string>(5);
            cities.Add("Burgas");
            cities.Add("Sofia");
            cities.Add("Plovdiv");
            cities.Add("Varna");
            cities.Add("Ruse");



            for (int i = 0; i < n; i++)
            {
                Random rnd = new Random();
                int randomPhrase = rnd.Next(0, 6);
                int randomEvent = rnd.Next(0, 6);
                int randomAuthor = rnd.Next(0, 8);
                int randomCity = rnd.Next(0, 5);

                Console.WriteLine($"{phrases[randomPhrase]} {phrases[randomEvent]} {phrases[randomAuthor]} - {phrases[randomCity]}");
            }
       



        }
    }
}
