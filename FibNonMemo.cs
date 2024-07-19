using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    public class FibNonMemo : FibBase
    {
        public override int Fib(int n)
        {
            if (n <= 2) return 1;

            return Fib(n - 1) + Fib(n - 2);
        }
    }
}
