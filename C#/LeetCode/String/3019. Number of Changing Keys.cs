
namespace LeetCode
{
    public class Solution3019
    {
        public int CountKeyChanges(string s)
        {
            int count = 0;

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] != s[i+1] && Math.Abs(s[i] - s[i + 1]) != 32)
                {
                    count++;
                }
            }

            return count;
        }

		/*static int Main()
        {
			Solution3019 sol = new Solution3019();
			int[] coins = new int[3] { 3, 5, 7 };
			Console.WriteLine(sol.CoinChange(coins, 19));
			Console.ReadKey();
			return 0;
        }*/
    }
}
