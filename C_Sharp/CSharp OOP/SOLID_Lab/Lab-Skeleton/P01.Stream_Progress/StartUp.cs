namespace P01.Stream_Progress
{
    using System;
    using Models;
    using Streams;

    public class StartUp
    {
        static void Main()
        {
            var file = new Movie(60, 1040);

            var progressInfo = new StreamProgressInfo(file);

            var result = progressInfo.CalculateCurrentPercent();

            Console.WriteLine(result);

        }
    }
}
