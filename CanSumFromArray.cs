using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    /// <summary>
    /// Understand the problem. 
    /// Given a number(target) and an array of numbers, check to see if any number from the array can be sum up to the given number, if yes, return true, else return false.  
    /// assumption: 
    /// the number in the array are positive, and the target number is also positive.
    /// be able to use the numbers in the array as many time as needed.
    /// </summary>
    public static class CanSumFromArray
    {
        public static bool canSum(int targetSum, int[] arrayNum, Dictionary<int, bool> memo)
        {
            //memoization
            if (memo.ContainsKey(targetSum))
                return memo[targetSum];
            //base cases
            if (targetSum == 0) 
                return true;
            //targetSum is negative number
            if (targetSum < 0) 
                return false;

            foreach (var item in arrayNum)
            {
                int reminder = targetSum - item;
                //if either one of child is true, it will return true to parent node
                if (canSum(reminder, arrayNum, memo) == true) 
                {
                    memo[targetSum] = true;
                    return true;
                }
            }
            memo[targetSum] = false;
            return false;
        }
    }
}
