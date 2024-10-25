using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Solution11
    {
        public int MaxArea(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;
            int max = 0;
            int area = 0;

            while (left != right)
            {
                area = (right - left) * Math.Min(height[left], height[right]);
                if (max < area)
                    max = area;

                if (height[left] > height[right])
                    right--;
                else
                    left++;
            }


            return max;
        }
    }
}
