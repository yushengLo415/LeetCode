using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Grind75
{
    public class Solution383
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {

            Dictionary<char, int> dic = new Dictionary<char, int>();

            foreach (char c in magazine)
            {
                if (!dic.ContainsKey(c))
                    dic[c] = 0;
                dic[c]++;
            }

            foreach (char c in ransomNote)
            {
                if (!dic.ContainsKey(c) || dic[c] == 0)
                    return false;
                dic[c]--;
            }

            return true;
        }
    }
}
