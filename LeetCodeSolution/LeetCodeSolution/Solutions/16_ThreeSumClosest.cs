using System;
namespace LeetCodeSolution.Solutions
{
    public class ThreeSumClosestSln
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            int res = 0;
            int difference = int.MaxValue;
            for (int i = 0; i < nums.Length-2;++i)
            {
                for (int j = i + 1; j < nums.Length-1; j++)
                {
                    for (int k = j + 1; k < nums.Length; ++k)
                    {
                        int s = nums[i] + nums[j] + nums[k];
                        int d = Math.Abs(s - target);
                        if (d<difference)
                        {
                            res = s;
                            difference = d;
                        }
                        if (difference == 0) return res;
                    }
                }
            }
            return res;
        }
    }
}
