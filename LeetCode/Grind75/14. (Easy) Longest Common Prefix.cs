using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Grind75
{
    public class Solution14
    {
        public string LongestCommonPrefix(string[] strs)
        {

            for (int i = 0; i < strs[0].Length; i++)
            {
                for (int j = 1; j < strs.Length; j++)
                {
                    if ((strs[j].Length < i + 1) || (strs[j][i] != strs[0][i]))
                        return strs[0].Substring(0, i);
                }
            }
            return strs[0];
        }

        /*static int Main()
        {
            Solution14 sol = new Solution14();
            String[] str = new string[3];
            str[0] = "flower";
            str[1] = "fl";
            str[2] = "flol";
            Console.WriteLine(sol.LongestCommonPrefix(str));
            Console.ReadKey();
            return 0;
        }*/
    }
}
