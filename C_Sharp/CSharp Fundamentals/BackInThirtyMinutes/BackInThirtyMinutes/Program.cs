using System;

namespace BackInThirtyMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());

            minutes += 30;
            if (minutes >= 60)
            {
                hour++;
                minutes -= 60;
            }

            if (hour==24)
            {
                hour = 0;
            }

            Console.WriteLine("{0}:{1:D2}", hour, minutes);
        }
    }
}
