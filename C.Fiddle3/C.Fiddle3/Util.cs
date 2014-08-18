using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.Fiddle3
{
    public delegate void ProgressReporter (int percentComplete); 

    public class Util
    {
        public static void HardWork (ProgressReporter p)
        {
            for (int i= 0; i <10; i++)
            {
                p (i *10);
                System.Threading.Thread.Sleep (100);
            }
        }
        public static void WriteProgressToConsole (int percentComplete)
        {
            Console.WriteLine(percentComplete);
        }
        public static void WriteProgressToFile ( int percentComplete)
        {
            System.IO.File.WriteAllText("progress.txt", percentComplete.ToString());
        }
    }
}
