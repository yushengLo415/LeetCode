using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Weekly_Contest_368
{
    class Q1
    {
        public class SolutionQ1
        {
            /*public int MinGroupsForValidAssignment(int[] nums)
            {

                Dictionary<int, int> dic = new Dictionary<int, int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    if (!dic.ContainsKey(nums[i]))
                        dic.Add(nums[i], 0);
                    dic[nums[i]]++;
                }

                int minCount = Int32.MaxValue;
                foreach (int count in dic.Values)
                {
                    if (minCount > count)
                        minCount = count;
                }

                int sum = 0;
                foreach (int count in dic.Values)
                {
                    if (count > minCount + 1)
                    {
                        sum += count / (minCount + 1);
                        if (count % (minCount + 1) != 0)
                            sum += 1;
                    }
                    else
                        sum += 1;
                }

                return sum;
            }*/
            public int MinOperations(int[] nums1, int[] nums2)
            {
                int n = nums1.Length;

                int last1 = nums1[n - 1];
                int last2 = nums2[n - 1];
                int ans = 0;
                int temp = 0;

                for (int i = 0; i < n - 1; i++)
                {
                    bool swap = false;

                    if (nums1[i] > last1)
                    {
                        if (nums1[i] > last2)
                            return -1;
                        else
                        {
                            ans += 1;
                            swap = true;
                        }
                    }

                    if (swap)
                    {
                        if (nums1[i] > last2)
                            return -1;
                    }
                    else
                    {
                        if (nums2[i] > last2)
                        {
                            if (nums1[i] > last2)
                                return -1;
                            else
                            {
                                ans += 1;
                                swap = true;
                            }
                        }

                    }

                    if (nums1[i] <= last1 && nums1[i] <= last2 && nums2[i] <= last1 && nums2[i] <= last2)
                        temp += 1;


                }

                if (ans >= n - ans)
                {
                    ans = n - ans - temp;
                }

                return ans;
            }


            /*static int Main()
            {
                SolutionQ1 sol = new SolutionQ1();
                int[] arr1 = new int[] { 8, 6, 6, 6, 7, 8 };
                int[] arr2 = new int[] { 5, 8, 8, 8, 7, 7 };
                Console.WriteLine(sol.MinOperations(arr1, arr2));
                Console.ReadKey();
                return 0;
            }*/
        }
    }
}
