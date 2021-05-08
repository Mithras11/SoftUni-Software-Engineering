<<<<<<< HEAD
<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace PartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();

            HashSet<string> filters = new HashSet<string>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Print")
            {
                string[] command = input.Split(';').ToArray();

                switch (command[0])
                {
                    case "Add filter":
                        filters.Add($"{command[1]}:{command[2]}");

                        break;

                    case "Remove filter":
                        filters.Remove($"{command[1]}:{command[2]}");

                        break;
                }

            }


            foreach (var filter in filters)
            {
                string[] filterTokens = filter.Split(':').ToArray();

                string type = filterTokens[0];
                string parameter = filterTokens[1];


                if (type == "Starts with")
                {
                    names = names.Where(n => n.StartsWith(parameter) == false).ToList();
                }
                else if (type == "Ends with")
                {
                    names = names.Where(n => n.EndsWith(parameter) == false).ToList();
                }
                else if (type == "Length")
                {
                    int length = int.Parse(parameter);

                    names = names.Where(n => n.Length != length).ToList();
                }
                else if (type == "Contains")
                {
                    names = names.Where(n => n.Contains(parameter) == false).ToList();

                }

            }


            Console.WriteLine(string.Join(' ', names));
        }
    }


}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace PartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();

            HashSet<string> filters = new HashSet<string>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Print")
            {
                string[] command = input.Split(';').ToArray();

                switch (command[0])
                {
                    case "Add filter":
                        filters.Add($"{command[1]}:{command[2]}");

                        break;

                    case "Remove filter":
                        filters.Remove($"{command[1]}:{command[2]}");

                        break;
                }

            }


            foreach (var filter in filters)
            {
                string[] filterTokens = filter.Split(':').ToArray();

                string type = filterTokens[0];
                string parameter = filterTokens[1];


                if (type == "Starts with")
                {
                    names = names.Where(n => n.StartsWith(parameter) == false).ToList();
                }
                else if (type == "Ends with")
                {
                    names = names.Where(n => n.EndsWith(parameter) == false).ToList();
                }
                else if (type == "Length")
                {
                    int length = int.Parse(parameter);

                    names = names.Where(n => n.Length != length).ToList();
                }
                else if (type == "Contains")
                {
                    names = names.Where(n => n.Contains(parameter) == false).ToList();

                }

            }


            Console.WriteLine(string.Join(' ', names));
        }
    }


}
>>>>>>> 3bfcca77a82c342506f09855d6678f5c182361c6
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace PartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();

            HashSet<string> filters = new HashSet<string>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Print")
            {
                string[] command = input.Split(';').ToArray();

                switch (command[0])
                {
                    case "Add filter":
                        filters.Add($"{command[1]}:{command[2]}");

                        break;

                    case "Remove filter":
                        filters.Remove($"{command[1]}:{command[2]}");

                        break;
                }

            }


            foreach (var filter in filters)
            {
                string[] filterTokens = filter.Split(':').ToArray();

                string type = filterTokens[0];
                string parameter = filterTokens[1];


                if (type == "Starts with")
                {
                    names = names.Where(n => n.StartsWith(parameter) == false).ToList();
                }
                else if (type == "Ends with")
                {
                    names = names.Where(n => n.EndsWith(parameter) == false).ToList();
                }
                else if (type == "Length")
                {
                    int length = int.Parse(parameter);

                    names = names.Where(n => n.Length != length).ToList();
                }
                else if (type == "Contains")
                {
                    names = names.Where(n => n.Contains(parameter) == false).ToList();

                }

            }


            Console.WriteLine(string.Join(' ', names));
        }
    }


}
>>>>>>> refs/remotes/origin/master
