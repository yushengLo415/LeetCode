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
            public int MinGroupsForValidAssignment(int[] nums)
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
            }

           /* static int Main()
            {
                SolutionQ1 sol = new SolutionQ1();
                int[] arr = new int[] { 1, 1, 3, 3, 1, 1, 2, 2, 3, 1, 3, 2 };
                Console.WriteLine(sol.MinGroupsForValidAssignment(arr));
                Console.ReadKey();
                return 0;
            }*/
        }
    }
}
