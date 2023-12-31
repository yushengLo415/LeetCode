﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LeetCode.DP
{
    public class Solution55
    {
        #region Way1
        /*public bool CanJump(int[] nums)
        {
            if (nums.Length == 0)
                return false;
            if (nums.Length == 1)
                return true;

            Array.Reverse(nums);
            List<int> isZero = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    isZero.Add(i);
                    continue;
                }

                if (isZero.Any())
                    if (i - nums[i] < isZero[0] || i - nums[i] == 0)
                        isZero.Clear();

            }

            return !isZero.Any();
        }*/
        #endregion

        #region Way2
        public bool CanJump(int[] nums)
        {
            int necessary = nums.Length - 1;
            for (int i = nums.Length - 2; i > 0; i--)
            {
                if (i + nums[i] > necessary)
                    necessary = i;
            }

            return necessary == 0;
        }
        #endregion
    }

    /*class MainClass55
    {
        static int Main()
        {
            Solution55 sol = new Solution55();
            int[] nums = new int[3] {2, 0, 0};

            Console.WriteLine(sol.CanJump(nums));
            Thread.Sleep(10000);
            return 0;
        }
    }*/
}
