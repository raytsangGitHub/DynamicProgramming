using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        Dictionary<string, bool> memo = new();
        Stopwatch stopwatch = new Stopwatch();

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

