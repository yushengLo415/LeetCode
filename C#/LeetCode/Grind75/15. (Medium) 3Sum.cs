using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Grind75
{
    class Solution15 : Solution
    {
        public override int RunScript()
        {
            return 0;
        }

        public IList<IList<int>> ThreeSum(int[] nums)
        {

            // -4 -1 -1 0 1 2
            int n = nums.Length;

            IList<IList<int>> result = new List<IList<int>>();

            if (nums.Length < 3)
                return result;

            Array.Sort(nums);
            for (int i = 0; i < n - 2; i++)
            {

                if (i > 0 && nums[i] == nums[i - 1])
                    continue;

                int left = i + 1;
                int right = n - 1;


                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];
                    if (sum == 0)
                    {
                        result.Add(new List<int> { nums[i], nums[left], nums[right] });
                        while (left < right && nums[left] == nums[left + 1])
                            left++;
                        while (left < right && nums[right] == nums[right - 1])
                            right--;
                        right--;
                        left++;
                    }
                    else if (sum > 0)
                    {
                        right--;
                    }
                    else
                    {
                        left++;
                    }
                }
            }

            return result;
        }
    }
}
