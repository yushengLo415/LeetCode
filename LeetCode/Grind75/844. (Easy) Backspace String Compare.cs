using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Grind75
{
    class Solution844
    {
        public bool BackspaceCompare(string s, string t)
        {
            string[] split_s = s.Split('#');
            string[] split_t = t.Split('#');

            string str_s = "";
            string str_t = "";

            for (int i = 0; i < split_s.Length - 1; i++)
                if (split_s[i] != "")
                    str_s += split_s[i].Remove(split_s[i].Length - 1);


            for (int i = 0; i < split_t.Length - 1; i++)
                if (split_t[i] != "")
                    str_t += split_t[i].Remove(split_t[i].Length - 1);

            str_s += split_s[split_s.Length - 1];
            str_t += split_t[split_t.Length - 1];

            if (str_s == str_t)
                return true;
            else
                return false;
        }

        /*static int Main()
        {
            Solution844 sol = new Solution844();
            Console.WriteLine(sol.BackspaceCompare("a##c", "#a#c"));
            Console.ReadKey();
            return 0;
        }*/
    }
}
