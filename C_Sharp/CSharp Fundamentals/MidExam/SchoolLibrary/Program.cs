using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> books = Console.ReadLine().Split('&').ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Done")
                {
                    break;
                }
                else
                {
                    string[] command = input.Split(" | ");
                    switch (command[0])
                    {
                        case "Add Book":
                            string bookName = command[1];

                            if (books.Contains(bookName))
                            {
                                continue;
                            }
                            else
                            {
                                books.Insert(0, bookName);
                            }
                            break;

                        case "Take Book":
                            string bookTitle = command[1];

                            if (books.Contains(bookTitle))
                            {
                                books.Remove(bookTitle);
                            }
                            else
                            {
                                continue;
                            }
                            break;

                        case "Swap Books":
                            string book1 = command[1];
                            string book2 = command[2];

                            if (books.Contains(book1) && books.Contains(book2))
                            {
                                string temporaryBook = book1;
                                int index1 = books.IndexOf(book1);
                                int index2 = books.IndexOf(book2);
                                books[index1] = book2;
                                books[index2] = temporaryBook;
                            }
                            break;

                        case "Insert Book":
                            books.Add(command[1]);
                            break;

                        case "Check Book":
                            int index = int.Parse(command[1]);
                            if (index < 0 || index >= books.Count)
                            {
                                continue;
                            }
                            else
                            {
                                Console.WriteLine(books[index]);
                            }
                            break;
                    }
                }
            }


            Console.WriteLine(string.Join(", ", books));

        }
    }
}
