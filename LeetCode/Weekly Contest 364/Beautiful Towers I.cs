using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Weekly_Contest_364
{
    class Beautiful_Towers_I
    {
        public long MaximumSumOfHeights(IList<int> maxHeights)
        {
            if (maxHeights.Count == 1)
                return maxHeights[0];
            if (maxHeights.Count == 2)
                return maxHeights[0] + maxHeights[1];

            long needToReduce = long.MaxValue;
            long maxSum = 0;

            for (int i = 0; i < maxHeights.Count; i++)
                maxSum += maxHeights[i];

            bool isSorted = true;
            for (int i = 1; i < maxHeights.Count; i++)
            {
                if (maxHeights[i - 1] > maxHeights[i])
                {
                    isSorted = false;
                    break;
                }
            }

            if (isSorted)
            {
                return maxSum;
            }

            for (int i = 0; i < maxHeights.Count; i++)
            {
                IList<int> tempMaxHeights = maxHeights.ToList<int>();
                long leftSum = 0;
                long rightSum = 0;

                for (int p = i; p > 0; p--)
                {
                    if (tempMaxHeights[p - 1] - tempMaxHeights[p] > 0)
                    {
                        leftSum += tempMaxHeights[p - 1] - tempMaxHeights[p];
                        tempMaxHeights[p - 1] -= tempMaxHeights[p - 1] - tempMaxHeights[p];
                    }
                }

                for (int q = i; q < tempMaxHeights.Count - 1; q++)
                {
                    if (tempMaxHeights[q + 1] - tempMaxHeights[q] > 0)
                    {
                        rightSum += tempMaxHeights[q + 1] - tempMaxHeights[q];
                        tempMaxHeights[q + 1] -= tempMaxHeights[q + 1] - tempMaxHeights[q];
                    }
                }

                if (needToReduce > (leftSum + rightSum))
                    needToReduce = leftSum + rightSum;

            }


            return maxSum - needToReduce;
        }



        /*static int Main()
        {
            Beautiful_Towers_I sol = new Beautiful_Towers_I();
            List<int> list = new List<int>() { 3, 2, 5, 5, 2, 3 };
            Console.WriteLine(sol.MaximumSumOfHeights(list));
            Console.ReadKey();
            return 0;
        }*/
    }
}
