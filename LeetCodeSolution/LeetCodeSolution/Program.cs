﻿using System;
using LeetCodeSolution.Solutions;
namespace LeetCodeSolution
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //new ReverseInt().Reverse(123);
            //new StringToInt().MyAtoi("-42");
            //new IntToRomanSln().IntToRoman(3);
            new LongestCommonPrefixSln().LongestCommonPrefix(new[] { "flower", "flow", "flight" });
        }
    }
}
