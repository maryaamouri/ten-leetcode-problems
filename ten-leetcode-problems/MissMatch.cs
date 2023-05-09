using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ten_leetcode_problems
{
    internal static class MissMatch
    {
        internal static int[] Find(int[] nums)
        {
            var result = new int[2];
            Array.Sort(nums);
            var sumi = 0;
            var sumj = 0;
            for (var i = 0, j = 1; i < nums.Length; i++, j++)
            {


                // find repeated number
                if (i + 1 < nums.Length && nums[i] == nums[i + 1])
                {
                    result[0] = nums[i];
                    nums[i] = 0;
                }

                sumi += nums[i];
                sumj += j;
            }
            // find loss number
            result[1] = sumj - sumi;
            return result.ToArray();
        }
    }
}
