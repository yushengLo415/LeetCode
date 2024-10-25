
namespace LeetCode
{
    public class Solution3000
    {
        public int AreaOfMaxDiagonal(int[][] dimensions)
        {
            double maxDiagonal = 0;
            int maxArea = 0;

            foreach (var rect in dimensions)
            {
                int length = rect[0];
                int width = rect[1];
                double diagonal = Math.Sqrt(Math.Pow(length, 2) + Math.Pow(width, 2));

                if (diagonal > maxDiagonal || (diagonal == maxDiagonal && length * width > maxArea))
                {
                    maxDiagonal = diagonal;
                    maxArea = length * width;
                }
            }

            return maxArea;
        }

		/*static int Main()
        {
			Solution3000 sol = new Solution3000();
			int[] coins = new int[3] { 3, 5, 7 };
			Console.WriteLine(sol.CoinChange(coins, 19));
			Console.ReadKey();
			return 0;
        }*/
    }
}
