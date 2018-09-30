using System;
using System.Text;
namespace LeetCodeSolution.Solutions
{
    public class IntToRomanSln
    {
        public string IntToRoman(int num)
        {
            if (num < 1 || num > 3999) return string.Empty;

            StringBuilder sb = new StringBuilder(50);
            string[] singles = new string[] { "M", "C", "X", "I" }; //1000,100,10,1
            string[] fours = new string[] { "", "CD", "XL", "IV" };//4000, 400, 40, 4
            string[] fives = new string[] { "", "D", "L", "V" }; //5000, 500, 50, 5
            string[] nines = new string[] { "", "CM", "XC", "IX" }; //9000, 900, 90, 9
            int d = 1000;
            for (int i = 0; i <= 3; ++i)
            {
                var digit = num / d;
                num = num % d;
                d /= 10;
                if (digit == 0)
                    continue;
                else if (digit > 0 && digit < 4)
                {
                    for (int j = 0; j < digit; ++j)
                        sb.Append(singles[i]);
                }
                else if (digit == 4)
                    sb.Append(fours[i]);
                else if (digit == 9)
                    sb.Append(nines[i]);
                else
                {
                    sb.Append(fives[i]);
                    for (int j = 0; j < digit - 5; j++)
                        sb.Append(singles[i]);
                }
            }
            return sb.ToString();
        }
    }
}
