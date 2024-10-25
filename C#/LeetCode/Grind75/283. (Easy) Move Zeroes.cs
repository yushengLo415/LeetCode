using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Grind75
{
    public class Solution283
    {
        public int[] MoveZeroes(int[] nums)
        {
            int zeroes = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    zeroes++;
                    continue;
                }

                if (zeroes > 0)
                {
                    int swap = nums[i];
                    nums[i] = nums[i - zeroes];
                    nums[i - zeroes] = swap;
                }
            }

            return nums;
        }
    }
}
