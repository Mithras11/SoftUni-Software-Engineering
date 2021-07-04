using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace List
{
    class ImplementedList<T> : IAbstractList<T>
    {
        private T[] _array;


        public ImplementedList(int initialCapacity = 4)
        {

            if (initialCapacity < 0)
            {
                throw new ArgumentOutOfRangeException
                   ("Invalid capacity");
            }

            _array = new T[initialCapacity];
        }


        public int Count { get; set; }
        public int InternalArrayCount { get => _array.Length; }


        //indexer
        public T this[int i]
        {
            get => _array[i];

            set => _array[i] = value;
        }





        public void Add(T element)
        {
            if (this.Count == _array.Length)
            {
                _array = Grow(_array);
            }

            _array[Count] = element;
            Count++;
        }


        public void Insert(int index, T element)
        {
            this.ValidateIndex(index);

            if (this.Count == _array.Length)
            {
                _array = Grow(_array);
            }


            for (int i = _array.Length - 1; i > index; i--)
            {
                _array[i] = _array[i - 1];
            }

            _array[index] = element;

            Count++;

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

        public bool Contains(T element)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i].Equals(element))
                {
                    return true;
                }
            }

            return false;
        }

        public int IndexOf(T element)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i].Equals(element))
                {
                    return i;
                }
            }

            return -1;
        }

        public bool Remove(T element)
        {
            int indexToRemove = this.IndexOf(element);

            if (indexToRemove == -1)
            {
                return false;
            }

            for (int i = indexToRemove; i < this.Count - 1; i++)
            {
                _array[i] = _array[i + 1];
            }

            _array[Count] = default;

            Count--;

            return true;

        }

        public void RemoveAt(int index)
        {
            this.ValidateIndex(index);

            for (int i = index; i < this.Count - 1; i++)
            {
                _array[i] = _array[i + 1];
            }

            _array[Count] = default;

            Count--;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++)
            {
                yield return _array[i];

            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
        


        private void ValidateIndex(int index)
        {
            if (index < 0 || index > this.Count)
            {
                throw new IndexOutOfRangeException("Invalid index");
            }
        }
    }
}
