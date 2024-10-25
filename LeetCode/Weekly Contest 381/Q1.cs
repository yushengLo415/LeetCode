using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Weekly_Contest_381
{
    class Q1
    {
        public int CountKeyChanges(string s)
        {
            int count = 0;

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] != s[i+1] && Math.Abs(s[i] - s[i + 1]) != 32)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
