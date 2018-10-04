using System;
using System.Collections.Generic;
namespace LeetCodeSolution.Solutions
{
    public class ValidParentheses
    {
        public bool IsValid(string s)
        {
            if (s.Length % 2 == 1)
                return false;
            Stack<char> parentheses = new Stack<char>();
            for (int i = 0; i < s.Length;++i)
            {
                char c = s[i];
                if (c == '(' || c == '{' || c == '[')
                    parentheses.Push(c);
                else if (c == ')')
                {
                    if (parentheses.Count==0 || parentheses.Pop() != '(')
                        return false;
                }
                else if (c == ']')
                {
                    if (parentheses.Count == 0 || parentheses.Pop() != '[')
                        return false;
                }
                else
                {
                    if (parentheses.Count == 0 || parentheses.Pop() != '{')
                        return false;
                }

            }
            return parentheses.Count == 0;
        }
    }
}
