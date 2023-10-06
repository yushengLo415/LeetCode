using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Solution322
    {
        public int CoinChange(int[] coins, int amount)
        {
            int[] each_amount_needed_coins_count = new int[amount + 1];

            for (int i = 1; i < each_amount_needed_coins_count.Length; i++)
                each_amount_needed_coins_count[i] = amount + 1;

            each_amount_needed_coins_count[0] = 0;

            foreach (int coin in coins)
            {
                for (int i = coin; i <= amount; i++)
                {
                    each_amount_needed_coins_count[i] = Math.Min(each_amount_needed_coins_count[i], each_amount_needed_coins_count[i - coin] + 1);
                }
            }

            return each_amount_needed_coins_count[amount] <= amount ? each_amount_needed_coins_count[amount] : -1;
        }

		/*static int Main()
        {
			Solution322 sol = new Solution322();
			int[] coins = new int[3] { 3, 5, 7 };
			Console.WriteLine(sol.CoinChange(coins, 19));
			Console.ReadKey();
			return 0;
        }*/
    }
}
