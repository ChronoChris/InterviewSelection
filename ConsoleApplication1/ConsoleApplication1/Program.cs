using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ABCDE".IndexOf("AC")); /// gets the array location where AC begins, returns -1
                                                     
            Console.ReadLine();
            Display(Nut.Macadamia);
            Display(Size.Small);
            Console.ReadLine();
        }
        enum Nut { Walnut, Hazelnut, Macadamia}
        enum Size { Small, Medium, Large }

        static void Display (Enum value)
        {
            Console.WriteLine(value.GetType().Name);
            Console.WriteLine(value.ToString());
        }
    }
}
