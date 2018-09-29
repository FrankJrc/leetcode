using System;
namespace LeetCodeSolution.Solutions
{

    public class LongestPalindromeSubString
    {
        /*
         * 
         * 
         * "babad"
         * "abcd"
         * "a"
         * "abcddcbaeeeabc"
         */
        public string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s) || s.Length == 1) return s;
            int maxSoFar = 0;
            int startIdx = -1;
            for (int i = 0; i < s.Length-maxSoFar;++i)
            {
                for (int j = i + 1; j < s.Length;++j)
                {
                    if(s[i]==s[j])
                    {
                        if(IsPalindrome(s, i, j))
                        {
                            if(j-i+1>maxSoFar)
                            {
                                maxSoFar = j - i + 1;
                                startIdx = i;
                            }
                        }
                    }
                }
            }
            if (startIdx == -1) return s.Substring(0,1);
            return s.Substring(startIdx, maxSoFar);

        }
        public bool IsPalindrome(string s, int start, int end)
        {
            if (string.IsNullOrEmpty(s)) return false;
            for (int i = start, j = end; i < j; ++i, --j )
            {
                if (s[i] != s[j]) return false;
            }
            return true;
        }
    }
}
