using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Weekly_Contest_378
{
    class Q3
    {
        public int MaximumLength(string s)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            for (int p = s.Length; p >= 1; p--)
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

                        if (dict[substring] >= 3)
                            return substring.Length;
                    }
                }


            //abcaba
            return -1;
        }

        private bool IsSpecial(string s)
        {
            if (s.Length < 1)
                return false;

            for (int i = 0;  i < s.Length - 1; i++)
            {
                if (s[i] != s[i + 1])
                    return false;
            }

            return true;
        }

    }
}
