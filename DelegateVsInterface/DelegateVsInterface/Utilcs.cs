using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateVsInterface
{
    class Utilcs
    {
        public static void TransformAll (int[] values, ITransFormer t)
        {
            for (int i = 0; i < values.Length; i++)
                values[i] = t.Transform(values[i]);
        }
    }
}
