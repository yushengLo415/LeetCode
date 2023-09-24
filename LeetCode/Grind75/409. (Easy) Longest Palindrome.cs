using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Grind75
{
    public class Solution409
    {
        public int LongestPalindrome(string s)
        {
            int ans = 0;
            int[] count = new int[52];
            int checkSingleNum = 0;

            foreach (char c in s)
                if (c - 'A' <= 25)
                    count[c - 'A']++;
                else
                    count[c - 'a' + 26]++;

            foreach (int i in count)
            {
                if (i / 2 > 0)
                    ans += i - (i % 2);
                if (i % 2 == 1)
                    checkSingleNum = 1;
            }


            return ans + checkSingleNum;
        }
    }
}
