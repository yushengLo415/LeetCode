using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Grind75
{
    public class Solution977
    {
        public int[] SortedSquares(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > -1)
                    break;
                nums[i] *= -1;
            }

            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
                nums[i] *= nums[i];

            return nums;
        }
    }
}
