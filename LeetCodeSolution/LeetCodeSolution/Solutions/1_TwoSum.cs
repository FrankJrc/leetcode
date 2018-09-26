using System;
using System.Collections.Generic;
namespace LeetCodeSolution.Solutions
{
    public class Solution_TwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> existingNumbers = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; ++i)
            {
                var wanted = target - nums[i];
                int index;
                if (existingNumbers.TryGetValue(wanted, out index))
                    return new[] { index, i };
                else existingNumbers[nums[i]] = i;
            }
            return Array.Empty<int>();
        }
    }

}
