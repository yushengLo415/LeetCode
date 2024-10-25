using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LeetCode
{
    class Solution13
    {
        public int RomanToInt(string s)
        {
            int num = 0;
            List<int> list = new List<int>();
            Dictionary<char, int> dic = new Dictionary<char, int>()
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };

            foreach(char c in s)
                list.Add(dic[c]);

            int i;
            for(i = 0; i < list.Count - 1; i++)
            {
                num += list[i] < list[i + 1] ? list[i + 1] - list[i] : list[i];

                if (list[i] < list[i + 1])
                    i++;
            }

            return i == list.Count ? num : num + list[list.Count - 1];
        }
    }
    /*
    class MainClass
    {
        private static int Main()
        {
            Solution13 sol = new Solution13();
            Console.WriteLine(sol.RomanToInt("MCMXCIV"));
            Thread.Sleep(10000);
            return 0;
        }
    }*/
}
