using System;
using System.Text;
namespace LeetCodeSolution.Solutions
{
    public class LongestCommonPrefixSln
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length ==0) return string.Empty;
            StringBuilder sb = new StringBuilder();
            int index = 0;
            while(true)
            {
                char common=' ';
                for (int i = 0; i < strs.Length; ++i)
                {
                    if (index >= strs[i].Length) return sb.ToString();
                    if (i == 0)
                    {
                        common = strs[i][index];
                    }
                    else
                    {
                        if (strs[i][index] != common) return sb.ToString();
                    }
                }
                sb.Append(common);
                index++;
            }
        }
    }
}
