using System;
using System.Collections.Generic;
using System.Linq;

namespace DictSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>()
            {
                {"as", 2 },
                {"bs", 3 },
                {"sd", 4 }
            };

            int result = dict.Sum(x=>x.Value);
            Console.WriteLine(result);



        }
    }
}
