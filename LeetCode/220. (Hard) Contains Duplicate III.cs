using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Solution220
    {
        public bool ContainsNearbyAlmostDuplicate(int[] nums, int indexDiff, int valueDiff)
        {
            int left = 0;
            int right = 0;

            while (right < nums.Length)
            {

                for (int i = right - indexDiff < 0 ? 0 : right - indexDiff; i < right; i++)
                {
                    if (Math.Abs(nums[i] - nums[right]) <= valueDiff)
                        return true;
                }

                if (right - left < indexDiff)
                {
                    right++;
                }
                else
                {
                    left++;
                    right++;
                }
            }
            return false;
        }

        static int Main()
        {
            Solution220 sol = new Solution220();
            Console.WriteLine(sol.ContainsNearbyAlmostDuplicate(new int[6] { 1, 2, 2, 3, 4, 5}, 3, 0));
            Console.ReadKey();
            return 0;
        }
    }
}
