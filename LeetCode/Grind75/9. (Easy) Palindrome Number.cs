using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Grind75
{
    public class Solution9
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;

            int reverseNum = 0;
            int originNum = x;

            while (originNum > 0)
            {
                reverseNum = reverseNum * 10 + originNum % 10;
                originNum /= 10;
            }

            return reverseNum == x;
        }
    }
}
