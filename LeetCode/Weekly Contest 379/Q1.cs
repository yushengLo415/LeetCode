using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Weekly_Contest_379
{
    class Q1
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

    }
}
