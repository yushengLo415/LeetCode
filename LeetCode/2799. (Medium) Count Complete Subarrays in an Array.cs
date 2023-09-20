using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    #region myCode
    class Solution1828
    {
        public int CountCompleteSubarrays(int[] nums)
        {
            HashSet<int> set = new HashSet<int>(nums);
            int distinctNumCount = set.Count;
            int left = 0;
            int right = distinctNumCount - 1;
            int count = 0;

            while (right < nums.Length)
            {
                if (GetDistinctCountOfSubArray(left, right, nums) == distinctNumCount)
                {
                    count += nums.Length - right;
                    left++;
                }
                else
                {
                    right++;
                }
            }

            return count;
        }

        public int GetDistinctCountOfSubArray(int left, int right, int[] nums)
        {
            int[] arr = new int[right - left + 1];
            for (int i = left; i <= right; i++)
            {
                arr[i - left] = nums[i];
            }
            HashSet<int> set = new HashSet<int>(arr);

            return set.Count;
        }
    }
    #endregion

    #region OthersCode

    class Solution1828_Others
    {
        public int CountCompleteSubarrays(int[] nums)
        {
            HashSet<int> set = new HashSet<int>(nums);
            int distinctNumCount = set.Count;
            int left = 0;
            int right = 0;
            Dictionary<int, int> counter = new Dictionary<int, int>();
            int count = 0;

            while(right < nums.Length)
            {
                if (!counter.ContainsKey(nums[right])){
                    counter[nums[right]] = 0;
                }

                counter[nums[right]]++;
                while (counter.Count == distinctNumCount)
                {
                    count += nums.Length - right;

                    counter[nums[left]]--;
                    if (counter[nums[left]] == 0)
                        counter.Remove(nums[left]);
                    left++;
                }

                right++;
                
            }

            return count;
        }
    }

    #endregion
}
