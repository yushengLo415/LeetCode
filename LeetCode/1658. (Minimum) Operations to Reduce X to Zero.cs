using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LeetCode
{
    class Solution1658
    {
        public int MinOperations(int[] nums, int x)
        {
            Stack<int> stack = new Stack<int>();
            int left = 0;
            int right = 0;
            int len = nums.Length;
            int integer = x;
            int[] arr = nums;

            while (integer != 0)
            {
                if (left < len && GoLeft(arr[left], integer) >= 0)
                {
                    integer = GoLeft(arr[left], integer);
                    left++;
                }
                else if (right < len && GoRight(arr[len - 1 - right], integer) >= 0)
                {
                    integer = GoRight(arr[len - 1 - right], integer);
                    right++;
                }
                else
                {
                    return -1;
                }
            }
            
            return left + right;
        }

        int GoLeft(int element, int integer)
        {
            return integer - element;
        }

        int GoRight(int element, int integer)
        {
            return integer - element;
        }

    }

    class MainClass
    {
        static int Main()
        {
            Solution1658 sol = new Solution1658();
            int[] num = new int[5] { 1, 1, 4, 2, 3 };

            Console.WriteLine(sol.MinOperations(num, 5));
            Thread.Sleep(10000);
            return 0;
        }
    }

}
