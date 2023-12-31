using LeetCode.Weekly_Contest_378;
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

            Q3 q3 = new Q3();
            Console.WriteLine(q3.MaximumLength("edvjicilcvrzngyffduvzniqksazazxuibbhnjzzlizmcesiyhxkqwahszqspghitkhgdfqkcmggtaozzzzzzzzzzzzzzzzzzzeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeekkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooowwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwalzxulgaclfrelrvknbcshnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnleosbwvtulqbjjuqcljiemtdzorsdywglafpyttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttzfvqqhxx"));
            
            stopWatch.Stop(); //停止Stopwatch
            Console.WriteLine(stopWatch.ElapsedMilliseconds);

            Console.ReadKey();
            return 0;
        }
    }
}
