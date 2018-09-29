using System;
namespace LeetCodeSolution.Solutions
{
    public class StringToInt
    {
        public int MyAtoi(string str)
        {
            bool hasEncounteredValidChar = false;
            long res=0;
            bool isPositive = true;
            for (int i = 0; i < str.Length; ++i)
            {
                if(str[i]=='+')
                {
                    if (!hasEncounteredValidChar)
                        hasEncounteredValidChar = true;
                    else return (int)res;
                }
                else if(str[i]=='-')
                {
                    if (!hasEncounteredValidChar)
                    { 
                        hasEncounteredValidChar = true;
                        isPositive = false;
                    }
                    else return (int)res;
                }
                else if(str[i]>='0' && str[i]<='9')
                {
                    hasEncounteredValidChar = true;
                    var digit = str[i] - '0';
                    res = Math.Abs(res * 10) + digit;
                    res = isPositive ? res : -res;
                    if (res >= int.MaxValue) return int.MaxValue;
                    else if (res <= int.MinValue) return int.MinValue;
                }
                else if(str[i]==' ')
                {
                    if (hasEncounteredValidChar)
                        return (int)res;
                }
                else
                {
                    return (int)res;
                }
            }
            return (int)res;
        }
    }
}
