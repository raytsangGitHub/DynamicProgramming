using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming.Word
{
    public interface IWordBreak
    {
        public bool ProcessWord(string s, string[] wordDict, Dictionary<string, bool> memo);
    }
}
