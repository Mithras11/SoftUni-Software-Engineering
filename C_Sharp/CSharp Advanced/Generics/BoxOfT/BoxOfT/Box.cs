using System;
using System.Collections.Generic;


namespace BoxOfT
{
    public class Box<T>
    {
        public List<T> Data { get; set; }

        public int Count => this.Data.Count;

        public Box()
        {
            this.Data = new List<T>();
        }

        public void Add(T element)
        {
            this.Data.Add(element);
        }

        public T Remove()
        {
            var lastElement = this.Data[this.Count - 1];
            this.Data.RemoveAt(this.Count - 1);

            return lastElement;
        }


    }
}
