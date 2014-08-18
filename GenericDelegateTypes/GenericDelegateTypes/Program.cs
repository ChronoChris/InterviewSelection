using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegateTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //// No different except Generic used instead of explicit int

            int[] values = { 1, 2, 4, 8 };
            Util.Transform(values, Square);
            foreach (int i in values)
            {
                Console.WriteLine("{0}", i);
            }
            Console.ReadLine();
        }

        static int Square(int x) { return x * x; }  
    }
}
