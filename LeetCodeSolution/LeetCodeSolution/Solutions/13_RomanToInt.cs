using System;
namespace LeetCodeSolution.Solutions
{
    /*
     * 
     * I can be placed before V (5) and X (10) to make 4 and 9. 
     * X can be placed before L (50) and C (100) to make 40 and 90. 
     * C can be placed before D (500) and M (1000) to make 400 and 900.

    */
    public class RomanToInt
    {
        public int RomanToInt(string s)
        {
            int res = 0;
            for (int i = 0; i < s.Length;++i)
            {
                if (s[i] == 'M')
                    res += 1000;
                else if (s[i] == 'D')
                    res += 500;
                else if (s[i] == 'C')
                {
                    if (i + 1 < s.Length)
                    {
                        if (s[i + 1] == 'D')
                        {
                            res += 400;
                            i++;
                            continue;
                        }
                        else if (s[i + 1] == 'M')
                        {
                            res += 900;
                            i++;
                            continue;
                        }
                    }
                    res += 100;
                }
                else if (s[i] == 'L')
                    res += 50;
                else if (s[i] == 'X')
                {
                    if (i + 1 < s.Length)
                    {
                        if (s[i + 1] == 'L')
                        {
                            res += 40;
                            i++;
                            continue;
                        }
                        else if (s[i + 1] == 'C')
                        {
                            res += 90;
                            i++;
                            continue;
                        }
                    }
                    res += 10;
                }
                else if (s[i] == 'V')
                    res += 5;
                else if (s[i] == 'I')
                {
                    if (i + 1 < s.Length)
                    {
                        if (s[i + 1] == 'V')
                        {
                            res += 4;
                            i++;
                            continue;
                        }
                        else if (s[i + 1] == 'X')
                        {
                            res += 9;
                            i++;
                            continue;
                        }
                    }
                    res += 1;
                }
                else return 0;
            }
            return res;
        }
    }
}
