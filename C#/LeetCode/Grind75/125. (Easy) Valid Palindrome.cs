using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Solution125
    {
        public bool IsPalindrome(string s)
        {
            string temp = "";

            temp += string.Concat(s.Where(c => Char.IsLetterOrDigit(c)));
            temp = temp.ToLower();


            int left = 0;
            int right = temp.Length - 1;
            while (left < right)
            {
                if (temp[left] != temp[right])
                    return false;
                left++;
                right--;
            }

            return true;
        }

        /*static int Main()
        {
            Solution125 sol = new Solution125();
            string s = "A man, a plan, a canal: Panama";
            Console.WriteLine(sol.IsPalindrome(s));
            Console.ReadKey();
            return 0;
        }*/
    }
}
