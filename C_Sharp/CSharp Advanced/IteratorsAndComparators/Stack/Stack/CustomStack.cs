using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class CustomStack<T> : IEnumerable<T>
    {
        private List<T> elements;

        public CustomStack(params T[] elements)
        {
            this.elements = new List<T>(elements);
        }


        public void Push(T element)
        {
            this.elements.Add(element);
        }


        public void Pop()
        {
            if (this.elements.Count == 0)
            {
                Console.WriteLine("No elements");
            }
            else
            {
                int index = this.elements.Count - 1;

                this.elements.RemoveAt(index);

            }


        }



        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.elements.Count - 1; i >= 0; i--)
            {
                yield return this.elements[i];
            }
        }



        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
