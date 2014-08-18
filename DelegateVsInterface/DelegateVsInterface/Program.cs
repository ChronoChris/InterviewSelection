using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateVsInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 1, 2, 3 };
            Utilcs.TransformAll(values, new Square());
            foreach (int i in values)
            { Console.WriteLine("{0}", i); }
            Console.ReadLine();
        }
    }
}
