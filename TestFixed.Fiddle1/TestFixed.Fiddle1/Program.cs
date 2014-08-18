using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFixed.Fiddle1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write(new UnsafeClass("Unsafe String that will cause an exception because it is more than 30 bytes"));
            Console.ReadLine();

            ///causes a runtime error
            ///if UnsafeClass() carries 30 bytes or less the Console will only Write Assembly + UnsafeClass
        }

        unsafe struct UnsafeUnicodeString
        {
            public short Length;
            public fixed byte Buffer[30];
        }

        unsafe class UnsafeClass
        {
            UnsafeUnicodeString uus;
            

            public UnsafeClass(string s)
            {
                uus.Length = (short)s.Length;
                fixed (byte* p = uus.Buffer)
                    for (int i = 0; i < s.Length; i++)
                        p[i] = (byte)s[i];   /// takes argument string under unsafe struct UnsafeUnicodeString and creates a buffer of fixed size.
            }

        }
    }
}
