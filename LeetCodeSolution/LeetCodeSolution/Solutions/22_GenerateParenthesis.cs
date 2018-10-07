using System;
using System.Collections.Generic;
namespace LeetCodeSolution.Solutions
{
    public class GenerateParenthesisSln
    {
        public IList<string> GenerateParenthesis(int n)
        {
            return Solve(n, n, "", new List<string>());
        }

        private IList<string> Solve(int left, int right, string s, List<string> res)
        {
            if(left==0)
            {
                while(right>0)
                {
                    s = s + ")";
                    right--;
                }
                res.Add(s);
                return res;
            }

            Solve(left - 1, right, s + "(", res);

            if (right > left) Solve(left, right - 1, s + ")", res);

            return res;

        }
    }
}
