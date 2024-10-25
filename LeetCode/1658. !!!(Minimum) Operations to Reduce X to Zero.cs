using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LeetCode
{
    class Solution1658
    {
        public int MinOperations(int[] nums, int x)
        {
            int target = -x, n = nums.Length;
            foreach (int num in nums) target += num;

            if (target == 0) return n;

            int maxLen = 0;
            int curSum = 0;
            int left = 0;

            for (int right = 0; right < n; ++right)
            {
                curSum += nums[right];
                while (left <= right && curSum > target)
                {
                    curSum -= nums[left];
                    left++;
                }
                if (curSum == target)
                {
                    maxLen = Math.Max(maxLen, right - left + 1);
                }
            }

            return maxLen != 0 ? n - maxLen : -1;
        }

    }

    /*class MainClass
    {
        static int Main()
        {
            Solution1658 sol = new Solution1658();
            int[] num = new int[5] { 1, 1, 4, 2, 3 };

            Console.WriteLine(sol.MinOperations(num, 6));
            Thread.Sleep(10000);
            return 0;
        }
    }*/

}
