using System;
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
            //new LongestCommonPrefixSln().LongestCommonPrefix(new[] { "flower", "flow", "flight" });


            var rate = 0.0315/12;
            int paymentTime = 12 * 25;

            var mortgage = 310292.1;
            var monthly = 1497.93;

            for (int i = 0; i < paymentTime; ++i)
                mortgage = mortgage * (1+rate) - monthly;

            Console.WriteLine($"remaining: {mortgage}");
            Console.ReadKey();
        }
    }
}
