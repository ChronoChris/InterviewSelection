using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.Fiddle6
{
    class Program
    {
        static void Main()
        {
            foreach (int fib in Fibs(27))
             Console.WriteLine("{0}", fib);
            Console.ReadLine();
        }

        static IEnumerable<int> Fibs (int fibCount)
        {
            for (int i = 0, prevFib = 1, curFib = 1; i < fibCount; i++)
            {
                yield return prevFib;   /// starts as 1, this process yields the previous Fib (necessary when not using getEnumerator()) and adds it to the current Fib,
                                        /// then sets the previous fib as the current fib was before iteration, the current 
                                        /// fib then set to the previous fib + curent Fib
                int newFib = prevFib + curFib;
                prevFib = curFib;
                curFib = newFib;
            }
        }
    }
}
