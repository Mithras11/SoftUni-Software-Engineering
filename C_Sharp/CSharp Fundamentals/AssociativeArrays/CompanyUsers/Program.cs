using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyUsers = new Dictionary<string, List<string>>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] currentData = input.Split(" -> ").ToArray();

                string companyName = currentData[0];
                string employeeId = currentData[1];

                if (companyUsers.ContainsKey(companyName))
                {
                    if (companyUsers[companyName].Contains(employeeId) == false)
                    {
                        companyUsers[companyName].Add(employeeId);
                    }
                }
                else
                {
                    companyUsers.Add(companyName, new List<string>() { employeeId });
                }
            }

            var orderedCompanies = companyUsers.OrderBy(pair => pair.Key);

            foreach (var company in orderedCompanies)
            {
                Console.WriteLine($"{company.Key}");

                foreach (var employee in company.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }



        }
    }
}
