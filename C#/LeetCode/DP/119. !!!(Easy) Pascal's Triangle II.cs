using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LeetCode
{
    public class Solution119
    {
        public IList<int> GetRow(int rowIndex)
        {
            int[] list = new int[rowIndex + 1];
            list[0] = 1;

            for (int i = 0; i <= rowIndex; i++)
                for (int j = i; j > 0; j--)
                {
                    list[j] = list[j] + list[j - 1];
                }
            

            return list;
        }
    }

    /*public class MainClass119
    {
        //   1
        //  1 1
        // 1 2 1
        //1 3 3 1 

        public static int Main()
        {
            Solution119 sol = new Solution119();
            IList<int> list = sol.GetRow(4);
            foreach (int i in list)
                Console.WriteLine(i);
            Thread.Sleep(10000);
            return 0;
        }
    }*/
}
