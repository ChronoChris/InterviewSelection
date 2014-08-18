using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SingletonThreadSafe;

namespace SingletonThreadSafe
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public sealed class SingletonTest
        {
            private static SingletonTest instance = null;
            private static readonly object threadlock = new object();

            SingletonTest()
            {
            }

            public static SingletonTest Instance
            {
                get
                {
                    lock (threadlock) /// allows only 1 thread in at a time.
                    {
                        if (instance == null) ///processor intensive since if instance == null check is inside the lock
                        {
                            instance = new SingletonTest();
                        }
                        return instance;
                    }
                }
            }
        }
    }
}
