using System;
using System.Collections.Generic;
using System.Text;

namespace List
{
    interface IAbstractList<T> : IEnumerable<T>
    {
        int Count { get; }

        T this[int index] { get; set; }

        void Add(T element);

        void Insert(int index, T element);

        bool Contains(T element);

        int IndexOf(T element);

        bool Remove(T element);

        void RemoveAt(int index);
    }
}
