using System.Diagnostics;

namespace DynamicProgramming.Word
{
    public class AccessWordProblem
    {
        private IEnumerable<IWordBreak> _WordBreak;

        public AccessWordProblem(IEnumerable<IWordBreak> WordBreak)
        {
            this._WordBreak = WordBreak;
        }

        //test data:
        private Dictionary<string, bool> memo = new();

        private Stopwatch stopwatch = new Stopwatch();

        public void accessWordBreak()
        {
            foreach (var word in _WordBreak)
            {
                string s = "catsandog";
                //string s = "eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef";
                string[] wordDict = { "cats", "dog", "sand", "and", "cat" };
                //string[] wordDict = { "e", "ee", "eee", "eeee", "eeeee", "eeeeee" };
                Console.WriteLine($"The word break Memo: {word.ProcessWord(s, wordDict, memo)}");
            }
        }
    }
}