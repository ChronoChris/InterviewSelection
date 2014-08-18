using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateVsInterface
{
    public interface ITransFormer
    {
      int Transform(int x);
    }

    // making square subclass interface ITransFormer
    public class Square : ITransFormer
    {
        public int Transform(int x) { return x * x; }
    }
}
