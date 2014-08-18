using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.Fiddle
{
    public class tester
    {
            public class Stack<T>
            {
                int position;
                T[] data = new T[10];
                public void Push(T obj) { data[position++] = obj; }
                public T Pop() { return data[position--]; }
            }

            public class Animal { }
            public class Bear : Animal { }
            public class Camel : Animal { }


            public class ZooCleaner
            {
                private static void Wash<T>(Stack<Animal> animals) where T : Animal {}
            }
        }
    }

