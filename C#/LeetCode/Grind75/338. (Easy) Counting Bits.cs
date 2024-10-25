using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Grind75
{
    public class Solution338
    {
        public int[] CountBits(int n)
        {

            int[] ans = new int[n + 1];
            int offset = 1;
            ans[0] = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i / offset == 2)
                    offset *= 2;
                ans[i] = ans[i - offset] + 1;
            }

            return ans;
        }
    }
}
