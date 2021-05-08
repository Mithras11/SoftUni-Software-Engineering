using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public class Program
    {
        static void Main()
        {
            Singleton singleton1 = Singleton.Instance;
            Singleton singleton2 = Singleton.Instance;

            singleton1.DoWork();
            singleton2.DoWork();

        }




    }
}
