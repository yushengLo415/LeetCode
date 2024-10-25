using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Grind75
{
    public class Solution191
    {
        public int HammingWeight(uint n)
        {
            uint ones = 0;
            while (n > 0)
            {
                if ((n & 1) == 1)
                {
                    ones++;
                }
                n >>= 1;
            }
            return (int)ones;
        }
    }
}
