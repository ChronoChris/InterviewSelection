using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace C.FiddleThreading2
{
    class Program
    {
        bool _done;

        static void Main(string[] args)
        {
            Program tt = new Program();
            new Thread(tt.Go).Start();
            
            tt.Go();
            Console.ReadLine();
        }
        public void Go()
        {
            if (!_done) { _done = true; Console.WriteLine("Done"); }
            /// THIS IS NOT THREADSAFE
        }
    }
}
