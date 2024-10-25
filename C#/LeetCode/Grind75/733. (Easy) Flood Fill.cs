using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Solution733
    {
        public int[][] FloodFill(int[][] image, int sr, int sc, int color)
        {
            int startingColor = image[sr][sc];
            image[sr][sc] = color;

            if (sr > 0 && image[sr - 1][sc] == startingColor)
                FloodFill(image, sr - 1, sc, color);
            if (sr < image.Length - 1 && image[sr + 1][sc] == startingColor)
                FloodFill(image, sr + 1, sc, color);
            if (sc < image[sr].Length - 1　&&　image[sr][sc + 1] == startingColor)
                FloodFill(image, sr, sc + 1, color);
            if (sc > 0 && image[sr][sc - 1] == startingColor)
                FloodFill(image, sr, sc - 1, color);

            return image;
        }

        /*static int Main()
        {
            Solution733 sol = new Solution733();
            int[][] image = new int[3][] { new int[3] { 1, 1, 1 }, new int[3]{1, 1, 0}, new int[3]{ 1, 0, 1} };
            int sr = 1;
            int sc = 1;
            int color = 2;
            int[][] ans = sol.FloodFill(image, sr, sc, color);
            for (int i = 0; i < ans.Length; i++)
                for (int j = 0; j < ans[i].Length; j++)
                    Console.WriteLine(ans[i][j]);

            Console.ReadKey();
            return 0;
        }*/
    }
}
