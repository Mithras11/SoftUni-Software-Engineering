using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] currentCourse = input
                    .Split(" : ")
                    .ToArray();
                string courseName = currentCourse[0];
                string userName = currentCourse[1];

                if (courses.ContainsKey(courseName))
                {
                    courses[courseName].Add(userName);
                }
                else
                {
                    courses.Add(courseName, new List<string>() { userName });
                }
            }

            var sortedCourses = courses
                .OrderByDescending(pair => pair.Value.Count)
                .ToDictionary(pair => pair.Key, pair => pair.Value);

            foreach (var course in sortedCourses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");

                var sortedUsers = course.Value
                    .OrderBy(userName => userName)
                    .ToList();

                foreach (var user in sortedUsers)
                {
                    Console.WriteLine($"-- {user}");
                }
            }



        }
    }
}
