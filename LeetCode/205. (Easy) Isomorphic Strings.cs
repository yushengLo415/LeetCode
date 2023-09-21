using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LeetCode
{
    class Solution205
    {
        public bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            Dictionary<char, char> dic = new Dictionary<char, char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (dic.ContainsKey(s[i]))
                {
                    if (dic[s[i]] != t[i])
                        return false;
                }
                else
                {
                    if (dic.ContainsValue(t[i]))
                        return false;
                    dic.Add(s[i], t[i]);
                }
            }

            return true;
        }
    }
    /*
    public class MainClass119
    {
        public static int Main()
        {
            Solution205 sol = new Solution205();


            Console.WriteLine(sol.IsIsomorphic("egg", "add"));
            Thread.Sleep(10000);
            return 0;
        }
    }*/
}
