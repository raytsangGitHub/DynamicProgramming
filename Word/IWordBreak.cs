namespace DynamicProgramming.Word
{
    public interface IWordBreak
    {
        public bool ProcessWord(string s, string[] wordDict, Dictionary<string, bool> memo);
    }
}