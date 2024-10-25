using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    #region function 1
    public class Solution3_1
    {
        public int LengthOfLongestSubstring(string s)
        {
            int count = 0;
            int right = 0;
            int max = 0;
            Dictionary<char, int> counter = new Dictionary<char, int>();
            string str = s;

            while (right < str.Length)
            {

                if (!counter.ContainsKey(str[right]))
                {
                    counter[str[right]] = 0;
                    count++;
                }

                counter[str[right]]++;

                if (max < count)
                    max = count;

                if (counter.ContainsValue(2))
                {
                    str = str.Substring(str.IndexOf(str[right]) + 1);
                    right = 0;
                    count = 0;
                    counter.Clear();
                }
                else
                {
                    right++;
                }
            }

            return max;
        }
    }
    #endregion

    #region function2
    public class Solution3_2
    {
        public int LengthOfLongestSubstring(string s)
        {
            //divide and conquer，把所有字元檢查一遍，將重複最多的選出，然後切成很多substring，再取重複最多的，然後再切，然後再選
            Dictionary<char, int> counter = new Dictionary<char, int>();
            for(int i = 0; i < s.Length; i++)
            {
                if (!counter.ContainsKey(s[i]))
                {
                    counter[s[i]] = 0;
                }
                else
                {
                    counter[s[i]]++;
                }
            }

            return 0;
        }



    }
    #endregion


    #region function3
    public class Solution3_3
    {
        public int LengthOfLongestSubstring(string s)
        {
            //用Queue

            int count = 0;
            int max = 0;

            Queue<char> q = new Queue<char>();
            foreach (char c in s)
            {
                if (!q.Contains(c))
                {
                    q.Enqueue(c);
                    count++;
                }
                else
                {
                    while (q.Contains(c))
                    {
                        q.Dequeue();
                        count--;
                    }
                    q.Enqueue(c);
                    count++;
                }

                if (max < count)
                    max = count;
            }

            return max;
        }


    }
    #endregion

    /*class MainClass
    {
        private static int Main()
        {
            Solution3_3 sol = new Solution3_3();
            int count = sol.LengthOfLongestSubstring("");
            Console.WriteLine("Count is: " + count);
            Thread.Sleep(10000);
            return 0;
        }
    }*/
    
}
