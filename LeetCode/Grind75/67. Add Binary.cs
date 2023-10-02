using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Grind75
{
    public class Solution67
    {
        public string AddBinary(string a, string b)
        {
            string ans = "";
            int carry = 0;
            int len;

            if (a.Length > b.Length)
                b = b.Insert(0, new String('0', a.Length - b.Length));
            else if (a.Length < b.Length)
                a = a.Insert(0, new String('0', b.Length - a.Length));

            len = a.Length;

            for (int i = len - 1; i >= 0; i--)
            {
                int sum = ((a[i] - '0') + (b[i] - '0')) + carry;
                ans += (sum % 2).ToString();
                carry = sum / 2;
            }

            if (carry != 0)
                ans += carry;

            char[] charArray = ans.ToCharArray();
            Array.Reverse(charArray);
            ans = new string(charArray);
            return ans;
        }

        static int Main()
        {
            Solution67 sol = new Solution67();
            string a = "11";
            string b = "1";
            Console.WriteLine(sol.AddBinary(a, b));
            Console.ReadKey();
            return 0;
        }
    }
}
