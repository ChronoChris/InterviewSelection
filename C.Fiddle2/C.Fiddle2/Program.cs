using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.Fiddle2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 1, 2, 5, 9 };
            Delegate.Transform(values, Delegate.Square);
            foreach(int i in values)
            Console.WriteLine("{0}", i);
            Console.ReadLine();
        }
    }
}
