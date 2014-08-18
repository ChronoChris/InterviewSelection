using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace C.Fiddle.Threading3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool _done = false;
            ThreadStart action = () =>
                {
                    if (_done != true) { _done = true; Console.WriteLine("Done"); }
                };
            new Thread(action).Start();
            action();
            Console.ReadLine();

            /// <summary> expresses action lambda on secondary and main thread sharing fields.
            /// This works with static fields too as follows
           ///  * static bool _done;
           ///  * static void Main()
            /// * { 
            ///     new Thread(Go).Start();
            ///     Go();
            ///   }
            ///   static void Go()
            ///   {if (_done != true) {_done = true; Console.WriteLine("Done")};}
            ///   </summary>
        }
    }
}
