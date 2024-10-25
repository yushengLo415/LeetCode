using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Solution20
    {
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> dic = new Dictionary<char, char>();

            dic['}'] = '{';
            dic[']'] = '[';
            dic[')'] = '(';

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '{' || s[i] == '[' || s[i] == '(')
                    stack.Push(s[i]);
                else if (dic[s[i]] == stack.Peek())
                {
                    stack.Pop();
                }
            }

            return stack.Count == 0;
        }
    }
}
