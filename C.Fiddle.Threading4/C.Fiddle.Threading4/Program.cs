using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace C.Fiddle.Threading4
{
    class Program
    {
        /// static Locking and Thread Safety
        static bool _done;
        static readonly object _locker = new Object();

        static void Main(string[] args)
        {
            new Thread(Go).Start();
            Go();
            Console.ReadLine();
            ///apparently this is threadsafe even though it seems like it's synchronous.???
        }

        static void Go()
        {
            lock (_locker)
            {
                if (_done != true) { Console.WriteLine("Fin"); _done = true; }
            }
        }
    }
}
