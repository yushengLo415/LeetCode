using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Weekly_Contest_377
{
    public class Solution10036
    {
        public int MaximizeSquareArea(int m, int n, int[] hFences, int[] vFences)
        {
            const int MOD = 1000000007;

            HashSet<int> hSet = new HashSet<int>();
            List<int> hList = new List<int>();
            hList.Add(1);
            for (int i = 0; i < hFences.Length; i++)
                hList.Add(hFences[i]);
            hList.Add(m);

            for (int i = 0; i < hList.Count - 1; i++)
            {
                for (int j = i + 1; j < hList.Count; j++)
                {
                    hSet.Add(Math.Abs(hList[j] - hList[i]));
                }
            }

            HashSet<int> vSet = new HashSet<int>();
            List<int> vList = new List<int>();
            vList.Add(1);
            for (int i = 0; i < vFences.Length; i++)
                vList.Add(vFences[i]);
            vList.Add(n);

            for (int i = 0; i < vList.Count - 1; i++)
            {
                for (int j = i + 1; j < vList.Count; j++)
                {
                    vSet.Add(Math.Abs(vList[j] - vList[i]));
                }
            }

            int max = -1;
            foreach (int i in hSet)
            {
                if (vSet.Contains(i))
                    if (i > max)
                        max = i;
            }

            return max == -1 ? -1 : (int)(((long)max * (long)max) % MOD);

        }



    }
}
