using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C.Fiddle;

namespace C.Fiddle
{
    class Program
    {
        static void Main(string[] args)
        {
            tester.Stack<tester.Bear> bears = new tester.Stack<tester.Bear>();

///error that shows no covariance
            tester.Stack<tester.Animal> animals = bears;  ///Cannot implicitly convert
            animals.Push(new C.Fiddle.tester.Camel());
        }
    }
}