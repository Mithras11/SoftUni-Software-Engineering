using System;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var dice1 = new Dice() { Side = 6, Color = "Red", Player = new Player("Nemo") };

            Console.WriteLine(dice1.Side);
            Console.WriteLine(dice1.Color);
            Console.WriteLine(dice1.Player.Name);


            var dice2 = (Dice)dice1.Clone();

            Console.WriteLine(dice2.Side);
            Console.WriteLine(dice2.Color);
            Console.WriteLine(dice2.Player.Name);

            dice2.Player.Name = "Omen";

            Console.WriteLine(dice2.Player.Name);
            Console.WriteLine(dice1.Player.Name);

            dice2.Color = "Blue";

            Console.WriteLine(dice1.Color);
            Console.WriteLine(dice2.Color);
        }
    }
}
