using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Solution121
    {
        public int MaxProfit(int[] prices)
        {
            int left = 0;
            int right = 0;
            int max = 0;

            while (left < prices.Length && right < prices.Length)
            {
                if (prices[right] > prices[left])
                {
                    int temp = prices[right] - prices[left];
                    if (temp > max)
                        max = temp;
                }

                if (prices[left] > prices[right])
                    left = right;
                else
                    right++;
            }

            return max;
        }


        /*static int Main()
        {
            Solution121 sol = new Solution121();
            int[] prices = new int[7] { 7, 1, 5, 3, 0, 6, 4 };
            Console.WriteLine(sol.MaxProfit(prices));
            Console.ReadKey();
            return 0;
        }*/
    }

    
}
