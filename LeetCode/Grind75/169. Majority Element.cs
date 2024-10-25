using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Grind75
{
    class Solution169
    {
        public int MajorityElement(int[] nums)
        {
            int ele = nums[0];
            int count = 0;
            foreach (int i in nums)
            {
                if (count == 0)
                {
                    ele = i;
                    count++;
                }
                else if (i == ele)
                    count++;
                else
                    count--;
            }

            return ele;
        }
    }
}
