using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.Fiddle3
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgressReporter p = C.Fiddle3.Util.WriteProgressToConsole;
            p += C.Fiddle3.Util.WriteProgressToFile;
            Util.HardWork(p);
        }
    }
}
