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
            #region brute solution (time limit exceed)
            /*int left = 0;
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
            return false;*/
            #endregion
            Dictionary<long, long> bucket = new Dictionary<long, long>();
            for (int i = 0; i < nums.Length; i++)
            {
                long index = ((long)nums[i] - int.MinValue) / (valueDiff + 1);

                if (i > indexDiff)
                    bucket.Remove(((long)nums[i - indexDiff - 1] - int.MinValue) / (valueDiff + 1));


                if (bucket.ContainsKey(index) || bucket.ContainsKey(index - 1) && Math.Abs(bucket[index - 1] - nums[i]) <= valueDiff || bucket.ContainsKey(index + 1) && Math.Abs(bucket[index + 1] - nums[i]) <= valueDiff)
                    return true;
                else if (!bucket.ContainsKey(index))
                    bucket.Add(index, nums[i]);
            }

            return false;
        }

        /*static int Main()
        {
            Solution220 sol = new Solution220();
            Console.WriteLine(sol.ContainsNearbyAlmostDuplicate(new int[6] { 1, 5, 9, 1, 5, 9 }, 2, 3));
            Console.ReadKey();
            return 0;
        }*/
    }
}
