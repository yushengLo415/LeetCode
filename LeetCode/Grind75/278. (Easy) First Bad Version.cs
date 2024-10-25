using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Grind75
{
    public class Solution278
    {
        public int FirstBadVersion(int n)
        {
            int first = 0;
            int left = 1;
            int right = n;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (IsBadVersion(mid))
                {
                    first = mid;
                    right = mid - 1;
                }
                else
                    left = mid + 1;
            }

            return first;

        }

        bool IsBadVersion(int version)
        {
            return true;
        }
    }
}
