using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Grind75
{
    public class Solution190
    {
        public uint reverseBits(uint n)
        {
            int result = 0;

            for (int i = 0; i < 32; i++)
            {
                if ((n & 1) == 1)
                    result += (int)Math.Pow((double)2, (double)(31 - i));
                n = n >> 1;
            }

            return (uint)result;
        }
    }
}
