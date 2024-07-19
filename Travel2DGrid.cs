using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    public class Travel2DGrid : FibBase
    {
        /// <summary>
        /// Memoization approach, performance is improved. Time O(m*n), Space O(n+m)
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static int GridTravler(int n, int m)
        {
            //the base case for a 1x1 grid, only one way the start is the end.
            if (n == 1 && m == 1) return 1;
            //invalid grid if either n or m equal 0
            if ((n == 0) || (m == 0)) 
                return 0;

            return GridTravler(m - 1, n) + GridTravler(m, n - 1);
        }

        
        /// <summary>
        /// Memoization approach, performance is improved. Time O(m*n), Space O(n+m)
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        /// <param name="memo"></param>
        /// <returns></returns>
        //public override long GridTravelerMemo(int n, int m, Dictionary<string , long> memo)
        //{
        //    string key = $"{m} + ',' + {n}";
        //    if (memo.ContainsKey(key)) return memo[key];
        //    //the base case for a 1x1 grid, only one way the start is the end.
        //    if (n == 1 && m == 1) return 1;
        //    //invalid grid if either n or m equal 0
        //    if ((n == 0) || (m == 0))
        //        return 0;
        //    memo[key]= GridTravelerMemo(m - 1, n, memo) + GridTravelerMemo(m, n - 1, memo);
        //    return memo[key];
        //}
    }
}
