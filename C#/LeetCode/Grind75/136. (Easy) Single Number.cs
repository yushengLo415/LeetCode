using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Grind75
{
    public class Solution136
    {
        public int SingleNumber(int[] nums)
        {
            #region
            /*int ans = 0;
            HashSet<int> set = new HashSet<int>();
            foreach (int i in nums)
            {
                if (!set.Contains(i))
                    set.Add(i);
                else
                    set.Remove(i);
            }

            foreach (int i in set)
                ans = i;
            return ans;*/
            #endregion

            int ans = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                ans ^= nums[i];
            }
            return ans;

        }

        /*static int Main()
        {
            Solution136 sol = new Solution136();
            int[] nums = new int[7] { 4, 0, 7, 2, 7, 2 , 0};
            Console.WriteLine(sol.SingleNumber(nums));
            Console.ReadKey();
            return 0;
        }*/
    }
}
