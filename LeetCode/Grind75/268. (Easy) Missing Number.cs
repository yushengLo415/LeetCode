using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Grind75
{
    public class Solution268
    {
        public int MissingNumber(int[] nums)
        {

            // int x = 0;
            // for (int i = 0; i < nums.Length; i++){
            //     x ^= i ^ nums[i];
            // }

            // return x ^ nums.Length;

            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != i)
                    return i;
            }

            return nums.Length;

        }


    }
}
