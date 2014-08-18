using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.FiddleArray1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 2, 1 };
            string[] words = { "two", "three", "one" };
            Array.Sort(numbers, words);
            string s = numbers.ToString();
            Console.WriteLine("{0}, {1}", s, words); /// shows typeof numbers and words
            Console.ReadLine();
            foreach (int i in numbers)
            { Console.WriteLine(i);}
            foreach (string h in words)
            { Console.WriteLine(h); };
            Console.ReadLine();
            /// out put is System.Int32[] and System.String[]
            /// second output shows the action delegate in work for Tkey key, and Tkey value;
            /// it sorts in ascending order int 1, 2, 3. The words are sorted by the corresponding spot in the array
            /// so one, three, two

        }

    }
}
