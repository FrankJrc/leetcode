using System;
using System.Collections.Generic;
using System.Linq;
namespace LeetCodeSolution.Solutions
{
    public class LetterCombinationsOnPhone
    {
        static List<List<string>> Mappings = new List<List<string>>(10);
        public IList<string> LetterCombinations(string digits)
        {
            if (string.IsNullOrEmpty(digits)) return Array.Empty<string>();

            Mappings.Add(null);
            Mappings.Add(null);
            Mappings.Add(new List<string>() { "a", "b", "c" });
            Mappings.Add(new List<string>() { "d", "e", "f" });
            Mappings.Add(new List<string>() { "g", "h", "i" });
            Mappings.Add(new List<string>() { "j", "k", "l" });
            Mappings.Add(new List<string>() { "m", "n", "o" });
            Mappings.Add(new List<string>() { "p", "q", "s","r" });
            Mappings.Add(new List<string>() { "t", "u", "v" }); 
            Mappings.Add(new List<string>() { "w", "x", "y", "z" });

            return Solve(digits);


        }

        private IList<string> Solve(string s)
        {
            if (s.Length == 1)
                return Mappings[s[0] - '0'].ToList();


            var partialRes = Solve(s.Substring(1, s.Length - 1));
            partialRes.Select(r => "a" + r);

            return Mappings[s[0] - '0'].SelectMany(tmp => partialRes.Select(r => tmp + r)).ToList();
        }
    }
}
