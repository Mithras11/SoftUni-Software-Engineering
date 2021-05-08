using System;

namespace CustomList
{
    public class MyList<T>
    {
        //fields

        private const int initialCapacity = 2;

        private T[] items;



        //constructor
        public MyList()
        {
            this.items = new T[initialCapacity];
            this.Count = 0;
        }

        //properties
        public int Count { get; private set; }

        public T this[int index]
        {
            get
            {
                CheckIfIndexIsOutOfRange(index);

                return this.items[index];
            }

            set
            {
                CheckIfIndexIsOutOfRange(index);

                this.items[index] = value;
            }
        }


        //methods
        private void CheckIfIndexIsOutOfRange(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
        }





        private void Resize()
        {
            T[] copy = new T[items.Length * 2];

            for (int i = 0; i < items.Length; i++)
            {
                copy[i] = items[i];
            }

            this.items = copy;
        }


        public void Add(T item)
        {
            if (this.Count == this.items.Length)
            {
                this.Resize();
            }

            this.items[this.Count] = item;
            this.Count++;
        }


        public T RemoveAt(int index)
        {
            CheckIfIndexIsOutOfRange(index);

            T result = this.items[index];


            this.ShiftLeft(index);

            this.Count--;



            if (this.Count <= this.items.Length / 4)
            {
                this.Shrink();
            }


            return result;
        }



        public void InsertAt(int index, T item)
        {
            CheckIfIndexIsOutOfRange(index);

            if (this.Count == this.items.Length)
            {
                this.Resize();
            }


            this.ShiftRight(index);

            this.items[index] = item;

            this.Count++;

        }



        private void Shrink()
        {
            T[] copy = new T[this.items.Length / 2];

            for (int i = 0; i < this.Count; i++)
            {
                copy[i] = items[i];
            }

            this.items = copy;
        }




        private void ShiftLeft(int index)
        {
            for (int i = index; i < this.Count - 1; i++)
            {
                this.items[i] = this.items[i + 1];
            }

            this.items[this.Count - 1] = default(T);
        }


        private void ShiftRight(int index)
        {
            for (int i = this.Count; i > index; i--)
            {
                this.items[i] = this.items[i - 1];
            }

        }



        public bool Contains(T item)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.items[i].Equals(item))
                {
                    return true;

                }
            }

            return false;
        }


        public void Swap(int firstIndex,int secondIndex)
        {
            CheckIfIndexIsOutOfRange(firstIndex);
            CheckIfIndexIsOutOfRange(secondIndex);

            T temp = this.items[firstIndex];

            this.items[firstIndex] = this.items[secondIndex];

            this.items[secondIndex] = temp;
        }



    }
}
