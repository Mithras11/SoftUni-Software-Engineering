using System;
using System.Globalization;

namespace DateModifier
{
    public class DateModifier
    {
        public static void GetDaysBetweenDates(string firstDate, string secondDate)
        {
            var dateOne = DateTime.ParseExact(firstDate, "yyyy MM dd", CultureInfo.InvariantCulture);
            var dateTwo = DateTime.ParseExact(secondDate, "yyyy MM dd", CultureInfo.InvariantCulture);

            if (dateOne > dateTwo)
            {
                Console.WriteLine((dateOne - dateTwo).Days);
            }
            else
            {
                Console.WriteLine((dateTwo - dateOne).Days);

            }
        }

    }
}
