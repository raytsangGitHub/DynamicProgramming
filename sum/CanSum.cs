namespace DynamicProgramming.Sum
{
    public class CanSum : ICanSum
    {
        public bool canSum(int targetSum, int[] arrayNum, Dictionary<int, bool> memo)
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