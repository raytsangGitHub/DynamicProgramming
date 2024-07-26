namespace DynamicProgramming.Sum
{
    public interface ICanSum
    {
        public bool canSum(int targetSum, int[] arrayNum, Dictionary<int, bool> memo);
    }
}