using LeetCode.Weekly_Contest_381;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;

namespace LeetCode.Grind75
{
    class SolutionMain
    {
       /* static int Main()
        {
            Solution sol = new Solution973();
            sol.RunScript();
            Console.ReadKey();
            return 0;

        }*/

        static int Main()
        {
            var stopWatch = Stopwatch.StartNew();

            Q2 q2 = new Q2();

            int[] nums = { 995,604,325,556516,409600,34596,780,625681,50625,556516,942,942,18496,37,567,18496,662,262144,567,38,178084,328329,1874161,990025,364816,908209,342102016,15,887364,573,217,150544,105625,186,1369,17956,321489,422,217,38,105625,225,15,342102016,34596,262144,1369,908209,1874161,990025,388,328329,910116,438244,342102016,954,321489,608400,37,225,2085136,791,134,134,1444,18496,388,325,17956,995,136,791,887364,18496,910116,512,409600,422,953,953,780,1444,746,662,150544,625681,342102016,640,746,573,954,322417936,47089,178084,322417936,608400,47089,364816,2085136,136,512,50625,438244,136,640,604,186,136 };
            int result = q2.MaximumLength(nums);
            Console.WriteLine(result);

            /*int a = 7, b = 3, c = 8, d = 1, e = 2, f = 7;
            Console.WriteLine();*/
            
            stopWatch.Stop(); //停止Stopwatch
            //Console.WriteLine(stopWatch.ElapsedMilliseconds);

            Console.ReadKey();
            return 0;
        }
    }
}
