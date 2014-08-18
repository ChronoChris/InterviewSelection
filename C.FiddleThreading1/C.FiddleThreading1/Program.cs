using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace C.FiddleThreading1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(Go);
            Thread y = new Thread(Go);
            t.Start();
            y.Start();
            t.Join();

            Console.WriteLine("Done SON");
            Console.ReadLine();

        }
        static void Go()
        {
            for (int i = 0; i < 1000; i++) { Console.WriteLine(i); }
        }
    }
}
