using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Grind75
{
    class Solution973 : Solution
    {

        public override int RunScript()
        {

            return 0;
        }

        public int[][] KClosest(int[][] points, int k)
        {
            List<int[]> result = new List<int[]>();
            foreach (int[] arr in points)
                result.Add(arr);

            result.Sort((a, b) => (a[0] * a[0] + a[1] * a[1]).CompareTo(b[0] * b[0] + b[1] * b[1]));

            return result.Take(k).ToArray();
        }
    }
}
