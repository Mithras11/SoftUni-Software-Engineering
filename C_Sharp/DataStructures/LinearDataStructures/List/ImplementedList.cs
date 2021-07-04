using System;
using System.Collections.Generic;
using System.Text;

namespace List
{
    class ImplementedList<T>
    {
        private T[] array;
        private int index = 0;



        public ImplementedList(int initialCapacity = 4)
        {
            array = new T[initialCapacity];
        }


        public int Count { get => index; } 
        public int InternalArrayCount { get => array.Length; }


        //indexer
        public T this[int i]
        {
            get => array[i];

            set => array[i] = value;
        }





        public void Add(T element)
        {
            if (index == array.Length)
            {
                array = Grow(array);
            }

            array[index] = element;
            index++;
        }



        private T[] Grow(T[] array)
        {
            T[] newArray = new T[array.Length * 2];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }

            return newArray;
        }
    }
}
