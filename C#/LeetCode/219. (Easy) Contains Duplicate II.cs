using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Solution219
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            #region HashSet
            HashSet<int> set = new HashSet<int>();
            int left = 0;
            int right = 0;

            while (right < nums.Length)
            {
                if (right - left < k + 1)
                {
                    set.Add(nums[right]);

                    right++;

                    if (right - left > set.Count)
                        return true;
                }
                else
                {
                    set.Remove(nums[left]);
                    set.Add(nums[right]);

                    if (set.Count < k + 1)
                        return true;

                    left++;
                    right++;
                }
            }

            return false;
            #endregion

            #region Dictionary

            //dic<nums, index>
            /*Dictionary<int, int> dic = new Dictionary<int, int>();
             for (int i = 0; i < nums.Length; i++)
             {
                 if (dic.ContainsKey(nums[i]))
                 {
                     if (i - dic[nums[i]] <= k)
                         return true;
                     dic[nums[i]] = i;
                 }
                 else
                     dic.Add(nums[i], i);
             }

             return false;*/
            #endregion
        }
    }
}
