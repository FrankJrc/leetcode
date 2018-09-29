using System;
using System.Text;
namespace LeetCodeSolution.Solutions
{
    public class ZigZag
    {
        public string Convert(string s, int numRows)
        {
            if (numRows <= 1 || numRows >= s.Length) return s;

            StringBuilder sb = new StringBuilder();
            var denominator = numRows * 2 - 2;
            for (int i = 0; i <= denominator / 2; ++i)
            {
                var step = i + i;
                if (step == 0) step = denominator;
                for (int j = i; j <= s.Length - 1; j += step)
                {
                    sb.Append(s[j]);
                    if (step != denominator)
                        step = denominator - step;
                }
            }
            return sb.ToString();
        }
    }
}
