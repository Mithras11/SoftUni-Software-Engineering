using System;
using System.Collections.Generic;
using System.Linq;

namespace StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Box> boxes = new List<Box>();

            while (input != "end")
            {
                string[] data = input.Split();

                int serialNumber = int.Parse(data[0]);
                string itemName = data[1];
                int itemQuality = int.Parse(data[2]);
                double itemPrice = double.Parse(data[3]);

                double totalPrice = itemQuality * itemPrice;

                Box currentBox = new Box(serialNumber, itemName, itemQuality, itemPrice, totalPrice);

                boxes.Add(currentBox);

                input = Console.ReadLine();
            }

            List<Box> sortedBoxes = boxes.OrderBy(boxes => boxes.TotalPrice).ToList();
            sortedBoxes.Reverse();

            foreach (Box box in sortedBoxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.ItemName} – ${box.ItemPrice}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.TotalPrice:f2}");
            }

        }



        public class Box
        {
            public int SerialNumber { get; set; }
            public string ItemName { get; set; }
            public int ItemQuantity { get; set; }
            public double ItemPrice { get; set; }

            public double TotalPrice { get; set; }

            public Box(int serialNumber, string itemName, int itemQuantity, double itemPrice, double totalPrice)
            {
                SerialNumber = serialNumber;
                ItemName = itemName;
                ItemQuantity = itemQuantity;
                ItemPrice = itemPrice;
                TotalPrice = totalPrice;
            }
        }





    }
}
