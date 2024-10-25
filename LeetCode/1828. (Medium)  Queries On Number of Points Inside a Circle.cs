using System;
using System.Threading;

namespace LeetCode
{

}
public class Solution1828
{
    public int[] CountPoints(int[][] points, int[][] queries)
    {
        int[] count = new int[queries.Length];
        int index = 0;

        foreach (int[] circle in queries)
        {
            int rr = circle[2] * circle[2];
            foreach(int[] p in points)
            {
                count[index] += (p[0] - circle[0]) * (p[0] - circle[0]) + (p[1] - circle[1]) * (p[1] - circle[1]) <= rr ? 1: 0;
            }
            index++;
        }


        return count;
    }

    /*public static void Main()
    {
        int[][] points = new int[4][];
        points[0] = new int[] { 1, 3 };
        points[1] = new int[] { 3, 3 };
        points[2] = new int[] { 5, 3 };
        points[3] = new int[] { 2, 2 };

        int[][] queries = new int[][]{  new int[] { 2, 3, 1 }, 
                                        new int[] { 4, 3, 1 }, 
                                        new int[] { 1, 1, 2 } };

        int[] arr = new int[3] { 1, 2, 3};
        Solution1828 so = new Solution1828();
        arr = so.CountPoints(points, queries);
        foreach(int i in arr)
        {
            Console.Write(i.ToString() + ", ");
        }
        Thread.Sleep(1000);
    }*/
}