using System;
using System.Collections.Generic;
namespace LeetCodeSolution.Solutions
{
    public class IsPalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0) return false;
            Stack<int> s = new Stack<int>();
            Queue<int> q = new Queue<int>();

            while(x!=0)
            {
                var lastDigit = x % 10;
                s.Push(lastDigit);
                q.Enqueue(lastDigit);
                x /= 10;
            }

            while(s.Count>0)
            {
                if (s.Pop() != q.Dequeue()) return false;
            }
            return true;
        }
    }
}
