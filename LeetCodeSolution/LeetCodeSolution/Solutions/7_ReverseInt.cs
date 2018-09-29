using System;
using System.Collections.Generic;
namespace LeetCodeSolution.Solutions
{
    public class ReverseInt
    {
        public int Reverse(int x)
        {
            if (x==0) return 0;

            bool isNeg = x < 0;
            long l = x;
            l = Math.Abs(l);
            Queue<long> digits = new Queue<long>();
            while(l!=0)
            {
                digits.Enqueue(l % 10);
                l /= 10;
            }
            long res=0;
            while (digits.Count>0)
            {
                res = res*10+digits.Dequeue();
            }
            res = isNeg ? -res : res;
            if (res > int.MaxValue || res < int.MinValue) return 0;

            return (int)res;
        }
    }
}
