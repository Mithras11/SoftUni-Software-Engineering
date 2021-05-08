using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple
{
    public class Tuple<T1, T2>
    {
        private T1 item1;
        private T2 item2;

        public Tuple(T1 item1, T2 item2)
        {
            this.Item1 = item1;
            this.Item2 = item2;
        }


        public T1 Item1
        {
            get => item1;

            set => item1 = value;
        }

        public T2 Item2
        {
            get => item2;

            set => item2 = value;
        }


        public void PrintInfo()
        {
            Console.WriteLine($"{Item1} -> {Item2}");

        }




    }
}
