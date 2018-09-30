using System;
namespace LeetCodeSolution.Solutions
{
    public class MaxAreaSln
    {
        public int MaxArea(int[] height)
        {
            int res = 0;
            for (int i = 0; i < height.Length; ++i)
            {
                for (int j = i + 1; j < height.Length;++j)
                {
                    var area = (j - i) * Math.Min(height[i], height[j]);
                    if (area > res) res = area;
                }
            }

            return res;
        }
    }
}
