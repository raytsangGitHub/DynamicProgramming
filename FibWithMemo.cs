using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    public class FibWithMemo : FibBase
    {
        /// <summary>
        /// The above fib(n) take too long to caculate, to improve performance, using memoization by adding extra paramenter, using Dictionary as look up table to reduce redundance steps. 
        /// </summary>
        /// <param name="n"></param>
        /// <param name="memo"></param>
        /// <returns></returns>
        public override long Fib(int n, Dictionary<int, long> memo)
        {
            //return to the recursive call if exist. but not to the caller.
            if (memo.ContainsKey(n))
                return memo[n];
            //base case 
            if (n == 0) return 0;
            if (n == 1) return 1;
            //store memo
            memo[n] = Fib(n - 1, memo) + Fib(n - 2, memo);
            return memo[n];
        }
    }
}
