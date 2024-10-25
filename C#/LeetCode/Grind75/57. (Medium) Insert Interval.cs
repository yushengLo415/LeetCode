using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Grind75
{
    class Solution57 : Solution
    {
        public override int RunScript()
        {

            return 0;
        }

        public int[][] Insert(int[][] intervals, int[] newInterval)
        {
            List<int[]> result = new List<int[]>();

            foreach (int[] interval in intervals)
            {
                if (newInterval[0] > interval[1])
                {
                    result.Add(interval);
                }
                else if (newInterval[1] < interval[0])
                {
                    result.Add(newInterval);
                    newInterval = interval;
                }
                else
                {
                    newInterval[0] = Math.Min(interval[0], newInterval[0]);
                    newInterval[1] = Math.Max(interval[1], newInterval[1]);
                }
            }

            result.Add(newInterval);

            return result.ToArray();
        }

    }
}
