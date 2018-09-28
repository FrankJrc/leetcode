using System;
using System.Collections.Generic;
namespace LeetCodeSolution.Solutions
{
    public class LongestSubStringNoRepeat
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;
            int res = 1;
            Dictionary<char, int> existing = new Dictionary<char, int>();
            existing[s[0]] = 0;
            int startingIndex = 0;
            int count = 1;
            for (int i = 1; i < s.Length;++i)
            {
                int match;
                if(existing.TryGetValue(s[i], out match))
                {
                    for (int j = startingIndex; j <= match; ++j)
                    {
                        existing.Remove(s[j]);
                    }
                    count = count - (match - startingIndex);
                    startingIndex = match + 1;
                    existing.Add(s[i], i);
                }
                else
                {
                    existing.Add(s[i], i);
                    count++;
                }
                if (count > res)
                    res = count;
            }
            return res;
        }
    }
}
