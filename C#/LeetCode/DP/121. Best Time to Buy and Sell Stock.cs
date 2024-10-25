namespace LeetCode
{
    public class Solution121
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
			int[] coins = new int[3] { 3, 5, 7 };
			Console.WriteLine(sol.CoinChange(coins, 19));
			Console.ReadKey();
			return 0;
        }*/
    }
}
