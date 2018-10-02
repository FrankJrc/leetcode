using System;
using System.Collections.Generic;
namespace LeetCodeSolution.Solutions
{
    public class ThreeSumSln
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var res = new List<IList<int>>();
            Dictionary<int, int> numberCounts = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; ++i)
            {
                int c;
                if (numberCounts.TryGetValue(nums[i], out c))
                {
                    if (nums[i] != 0)
                    {
                        if (c < 2) numberCounts[nums[i]] = c + 1;
                    }
                    else
                    {
                        if(c<3) numberCounts[nums[i]] = c + 1;
                    }
                }
                else
                    numberCounts[nums[i]] = 1;
            }
            int reducedLen = 0;
            foreach(var kvp in numberCounts)
            {
                for (int i = 0; i < kvp.Value; ++i)
                {
                    nums[reducedLen] = kvp.Key;
                    reducedLen++;
                }
            }
            for (int i = 0; i < reducedLen; ++i)
            {
                var count = numberCounts[nums[i]];
                if (count <= 0)
                    continue;
                numberCounts[nums[i]] = count - 1;
                Dictionary<int, int> tmp = new Dictionary<int, int>();
                foreach (var kvp in numberCounts)
                    tmp[kvp.Key] = kvp.Value;
                for (int j = i + 1; j < reducedLen; ++j)
                {
                    var countJ = tmp[nums[j]];
                    if (countJ <= 0) continue;
                    tmp[nums[j]] = countJ - 1;
                    var thridNumber = 0 - nums[i] - nums[j];
                    int c;
                    if(tmp.TryGetValue(thridNumber, out c))
                    {
                        if(c>0)
                        {
                            var toAdd = new List<int>();
                            toAdd.Add(nums[i]);
                            toAdd.Add(nums[j]);
                            toAdd.Add(thridNumber);
                            res.Add(toAdd);
                        }
                        tmp[thridNumber] = 0;
                    }
                    tmp[nums[j]] = 0;
                }

                numberCounts[nums[i]] = 0;
            }


            return res;

        }
    }
}
