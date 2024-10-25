using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Solution704
    {
        public int Search(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left);
                if (nums[mid] == target)
                    return mid;
                else if (nums[mid] > target)
                    right = mid - 1;
                else
                    left = mid + 1;
            }

            return -1;
        }


        /*static int Main()
        {
            Solution704 sol = new Solution704();
            int[] nums = new int[6] { -1, 0, 3, 5, 9, 12 };
            int target = 2;
            Console.WriteLine(sol.Search(nums, target));
            Console.ReadKey();
            return 0;
        }*/
    }
}
