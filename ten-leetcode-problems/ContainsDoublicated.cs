using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ten_leetcode_problems
{
    static internal class ContainsDoublicated
    {
        public static bool GetContainsNearbyDuplicate(int[] nums, int k)
        {
            for (int i = 0; i < nums.Length - 1; i++)
                for (int j = i + 1; j < nums.Length & j <= i + k; j++)
                {
                    if (nums[i] == nums[j])
                        return true;

                }
            return false;
        }
    }
}
