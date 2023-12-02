using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Grind75
{
    class Solution542 : Solution
    {
        public override int RunScript()
        {
            int[][] mat = new int[4][]{ new int[4] { 0, 0, 0, 0 }, new int[4] { 0, 1, 0, 0 }, new int[4] { 1, 1, 1, 0 }, new int[4] { 1, 1, 1, 0 } };


            int[][] res = UpdateMatrix(mat);
            foreach(int[] i in res)
                foreach(int j in i)
                    Console.WriteLine(j);

            return 0;
        }

        private int[][] UpdateMatrix(int[][] mat)
        {
            int m = mat.Length;
            int n = mat[0].Length;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i][j] != 0)
                    {
                        mat[i][j] = Int32.MaxValue - 1;
                        if (i > 0)
                            mat[i][j] = Math.Min(mat[i][j], mat[i - 1][j] + 1);
                        if (j > 0)
                            mat[i][j] = Math.Min(mat[i][j], mat[i][j - 1] + 1);
                    }
                }
            }

            for (int i = m - 1; i >= 0; i--)
            {
                for (int j = n - 1; j >= 0; j--)
                {
                    if (mat[i][j] != 0)
                    {
                        if (i < m - 1)
                            mat[i][j] = Math.Min(mat[i][j], mat[i + 1][j] + 1);
                        if (j < n - 1)
                            mat[i][j] = Math.Min(mat[i][j], mat[i][j + 1] + 1);
                    }
                }
            }

            return mat;
        }

    }
}
