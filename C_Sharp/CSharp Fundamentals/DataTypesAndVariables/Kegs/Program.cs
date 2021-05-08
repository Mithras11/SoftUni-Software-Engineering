using System;

namespace Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            double biggestVolume = 0.0;
            string biggestModel = String.Empty;


            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2) * height;

                if (volume > biggestVolume)
                {
                    biggestVolume = volume;
                    biggestModel = model;

                }
            }

            Console.WriteLine(biggestModel);
        }
    }
}
