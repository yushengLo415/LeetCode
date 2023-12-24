using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Weekly_Contest_377
{
    public class Solution10035
    {
        public int[] NumberGame(int[] nums)
        {
            Array.Sort(nums);
            for (int i = 0; i < nums.Length / 2; i++)
            {
                Swap(nums, i * 2);
            }

            return nums;
        }

        public static void Swap(int[] nums, int i)
        {
            int j = i + 1;
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
