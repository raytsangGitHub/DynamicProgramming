namespace DynamicProgramming.Word
{
    public class WordBreak_139 : IWordBreak
    {
        //with memoization
        public bool ProcessWord(string target, string[] wordDict, Dictionary<string, bool> memo)
        {
            if (memo.ContainsKey(target)) { return memo[target]; }
            //this logic will return incorrect value if the initial target is empty?
            //The answer: an empty string can be generate from any give string[]. therefore the below code will do the trick. so its not a problem.
            if (target == "") { return true; }

            foreach (string word in wordDict)
            {
                //check if word is the prefix of target.
                //Note: the following line only look at the begining(prefix). if can't find prefix, then it move to the next word in Dictionay
                if (target.IndexOf(word) != -1)
                {
                    //return the rest of substring
                    string subStr = target.Substring(word.Length); //extra time O(m)
                    if (ProcessWord(subStr, wordDict, memo))
                    {
                        memo[target] = true;
                        return true;
                    }
                }
            }
            memo[target] = false;
            return false;
        }

        //with out memoization
        public bool ProcessWord(string target, string[] wordDict)
        {
            //this logic will return incorrect value if the initial target is empty?
            //The answer: an empty string can be generate from any give string[]. therefore the below code will do the trick. so its not a problem.
            if (target == "") { return true; }

            foreach (string word in wordDict)
            {
                //check if word is the prefix of target.
                //Note: the following line only look at the begining(prefix). if can't find prefix, then it move to the next word in Dictionay
                if (target.IndexOf(word) != -1)
                {
                    //return the rest of substring
                    string subStr = target.Substring(word.Length);
                    if (ProcessWord(subStr, wordDict) == true)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}