using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Weekly_Contest_378
{
    class Q1
    {
        public bool HasTrailingZeros(int[] nums)
        {
            int even = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                    even++;
            }

            return even >= 2;
        }
    }
}
