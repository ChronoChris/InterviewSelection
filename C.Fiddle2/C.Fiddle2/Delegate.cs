using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.Fiddle2
{
    public delegate int Transformer (int x); /// delegate that takes methods of type int

    class Delegate
    {
        public static void Transform (int[] values, Transformer t)
        {
            for (int i = 0; i < values.Length; i++)
                values[i] = t (values[i]);
        }
        public static int Square(int x) { return x * x; }
    }
}
