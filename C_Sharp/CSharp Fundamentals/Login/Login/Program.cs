using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = String.Empty;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }

            string login = Console.ReadLine();
            int counter = 1;

            while (login != password)
            {
                if (counter == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                Console.WriteLine("Incorrect password. Try again.");

                login = Console.ReadLine();

                counter++;

            }

            Console.WriteLine($"User {username} logged in.");
        }
    }
}
