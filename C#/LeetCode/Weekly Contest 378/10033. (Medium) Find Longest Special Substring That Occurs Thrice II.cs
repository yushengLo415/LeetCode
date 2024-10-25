using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Weekly_Contest_378
{
    class Q3
    {
        /*public int MaximumLength(string s)
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
        }*/

        public int MaximumLength(string s)
        {
            int[][] arr = new int[26][];
            int n = s.Length;
            int longestSpecialLength = -1;

            for (int i = 0; i < 26; i++)
                arr[i] = new int[n];
            
            for (int i = 0; i < n; i++)
            {
                int j = i;
                while (j < n && s[i] == s[j])
                    j++;

                arr[s[i] - 'a'][j - i - 1] += 1;
            }


            for (int i = 0; i < 26; i++)
                for (int j = n - 1; j >= 0; j--)
                {
                    if (arr[i][j] >= 3 && j + 1 > longestSpecialLength)
                        longestSpecialLength = j + 1;

                    if (j >= 2 && arr[i][j] > 0 && j + 1 - 3 > longestSpecialLength)
                        longestSpecialLength = j + 1 - 2;
                }
                   


            return longestSpecialLength == 0 ? -1 : longestSpecialLength;
        }
        //aabcaba
        //aaaa
    }
}
