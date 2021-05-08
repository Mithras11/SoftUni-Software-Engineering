using System;
using System.Collections.Generic;

namespace GenericCountMethodDouble
{
    public class Box<T> where T : IComparable
    {
        private List<T> values;

        public Box()
        {
            this.values = new List<T>();
        }

        public void Add(T item)
        {
            this.values.Add(item);
        }

        public void Compare(T element)
        {

            int counter = 0;

            foreach (var item in this.values)
            {
                if (item.CompareTo(element) > 0)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
