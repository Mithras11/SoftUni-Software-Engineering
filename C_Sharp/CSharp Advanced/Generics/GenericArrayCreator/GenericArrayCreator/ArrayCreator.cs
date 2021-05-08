using System;
using System.Collections.Generic;
using System.Text;

namespace GenericArrayCreator
{
    public class ArrayCreator
    {
        public static T[] Create<T>(int length, T item)
        {
            T[] result = new T[length];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = item;
            }

            return result;
        }
    }
}
