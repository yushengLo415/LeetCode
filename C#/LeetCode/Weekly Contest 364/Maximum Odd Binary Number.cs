using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Weekly_Contest_364
{
    class Maximum_Odd_Binary_Number
    {
        public string MaximumOddBinaryNumber(string s)
        {
            int countOne = 0;

            foreach (char c in s)
            {
                if (c == '1')
                    countOne++;
            }

            return new string('1', countOne) + new string('0', s.Length - countOne) + '1';
        }




        /*static int Main()
        {
            Maximum_Odd_Binary_Number sol = new Maximum_Odd_Binary_Number();
            Console.WriteLine(sol.MaximumOddBinaryNumber("0101"));
            Console.ReadKey();
            return 0;
        }*/
    }

    
}
