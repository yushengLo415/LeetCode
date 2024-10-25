using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Grind75
{
    class Solution1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] ans = new int[2];
            for (int i = 0; i < nums.Length; i++)
                for (int j = 1; j < nums.Length; j++)
                    if (i != j)
                        if (nums[i] + nums[j] == target)
                        {
                            ans[0] = i;
                            ans[1] = j;
                            return ans;
                        }

            return ans;
        }
    }
}
