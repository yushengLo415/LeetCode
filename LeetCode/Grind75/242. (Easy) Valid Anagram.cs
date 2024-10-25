using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Solution242
    {
        public bool IsAnagram(string s, string t)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            Dictionary<char, int> ans = new Dictionary<char, int>();

            if (s.Length != t.Length)
                return false;

            for (int i = 0; i < s.Length; i++)
            {
                if (!dic.ContainsKey(s[i]))
                    dic[s[i]] = 0;
                dic[s[i]]++;
            }

            for (int i = 0; i < t.Length; i++)
            {
                if (dic.ContainsKey(t[i]))
                    dic[t[i]]--;
            }

            foreach (KeyValuePair<char, int> kv in dic.Where(kv => kv.Value != 0))
                ans[kv.Key] = kv.Value;

            return ans.Count == 0;

        }

        /*
        static int Main()
        {
            Solution242 sol = new Solution242();
            string s = "rat", t = "car";

            Console.WriteLine(sol.IsAnagram(s, t));
            Console.ReadKey();
            return 0;
        }*/
    }
}
