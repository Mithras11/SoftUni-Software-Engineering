using System;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] users = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            bool isValid = true;

            foreach (var item in users)
            {
                if (item.Length < 3 || item.Length > 16)
                {
                    isValid = false;

                    continue;
                }


                for (int i = 0; i < item.Length; i++)
                {
                    if (!(char.IsDigit(item[i]))
                        && !(char.IsLetter(item[i]))
                        && (item[i] != '-'
                        && (item[i] != '_')))
                    {
                        isValid = false;

                        break;
                    }
                    else
                    {
                        isValid = true;
                    }
                }

                if (isValid)
                {
                    Console.WriteLine(item);
                }

            }
        }
    }
}
