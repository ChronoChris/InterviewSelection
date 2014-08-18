using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace C.Fiddle.Threading5
{
    class Program
    {
        // Passing Data TO the thread

        static void Main(string[] args)
        {
            new Thread ( () => 
            {
            Console.WriteLine ("I'm running on another Thread!");
            Console.WriteLine("It's happening>!>!>");
            }).Start();
        }
    }
}
