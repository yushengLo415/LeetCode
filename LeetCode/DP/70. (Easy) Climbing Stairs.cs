using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.DP
{
    public class Solution70
    {
        public int ClimbStairs(int n)
        {

            List<int> list = new List<int>();
            list.Add(0);
            list.Add(1);
            list.Add(2);

            for (int i = 3; i <= n; i++)
                list.Add(list[i - 1] + list[i - 2]);

            return list[n];
        }

    }
}
