using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    class Singleton
    {
        private static Singleton instance;
        private static object lockObject = new object();
        private Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                    }
                }

                return instance;
            }
        }

        public void DoWork()
        {
            Console.WriteLine("Tryin' to work here");
        }

    }
}
