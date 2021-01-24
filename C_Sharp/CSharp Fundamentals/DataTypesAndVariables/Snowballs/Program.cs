using System;
using System.Numerics;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            BigInteger highestValue = 0;
            short highestSnow = 0;
            short highestTime = 0;
            short highestQuality = 0;

            for (int i = 0; i < n; i++)
            {
                short snow = short.Parse(Console.ReadLine());
                short time = short.Parse(Console.ReadLine());
                byte quality = byte.Parse(Console.ReadLine());
                BigInteger value = BigInteger.Pow((snow / time), (quality));

                if (value > highestValue)
                {
                    highestValue = value;
                    highestSnow = snow;
                    highestTime = time;
                    highestQuality = quality;

                }
            }

            Console.WriteLine($"{highestSnow} : {highestTime} = {highestValue} ({highestQuality})");



        }
    }
}
