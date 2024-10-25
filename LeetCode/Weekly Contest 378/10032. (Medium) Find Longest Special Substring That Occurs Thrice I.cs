using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Weekly_Contest_378
{
    class Q2
    {
        public int MaximumLength(string s)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            int longestSpecialLength = -1;
            int tempLength = 1;

            for (int p = tempLength; p <= s.Length; p++)
                for (int i = 0; i < s.Length; i++)
                {
                    if (i + p <= s.Length)
                    {
                        string substring = s.Substring(i, p);

                        if (!IsSpecial(substring))
                            continue;

                        if (!dict.ContainsKey(substring))
                            dict[substring] = 0;

                        dict[substring]++;
                    }
                }

            foreach (var temp in dict)
            {
                if (temp.Value >= 3 && longestSpecialLength < (temp.Key).Length)
                    longestSpecialLength = (temp.Key).Length;

            }

            //cccerrrecdcdccedecdcccddeeeddcdcddedccdceeedccecde
            return longestSpecialLength;
        }

        private bool IsSpecial(string s)
        {
            return s.Length > 0 && s.All(c => c == s[0]);
        }
    }
}
