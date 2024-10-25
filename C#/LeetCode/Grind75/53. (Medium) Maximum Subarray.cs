using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Grind75
{
    public class Solution53
    {
        public int MaxSubArray(int[] nums)
        {
            int sum = 0;
            int max = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {

                sum += nums[i];

                if (sum < nums[i])
                    sum = nums[i];

                if (sum > max)
                    max = sum;
            }

            return max;
        }
    }
}
