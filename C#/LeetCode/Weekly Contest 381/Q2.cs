using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Weekly_Contest_381
{
    class Q2
    {
        public int MaximumLength(int[] nums)
        {

            int max_length = 0;

            Array.Sort(nums);
            int n = nums.Length;

            if (nums[0] == 1)
                if (CheckAllOne(nums))
                    if (n % 2 == 0)
                        return n - 1;
                    else
                        return n;

            //Clear all 1
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
                if (nums[i] != 1)
                    list.Add(nums[i]);
                else
                    max_length++;

            if (max_length > 0 && max_length % 2 == 0)
                max_length--;

            Dictionary<int, int> freq = new Dictionary<int, int>();
            foreach (int num in list)
            {
                if (!freq.ContainsKey(num))
                    freq[num] = 0;
                freq[num]++;
            }

            foreach (int x in freq.Keys)
            {
                Int32 temp = 0;
                double count = freq[x];
                if (count == 1)
                    continue;
                double i = 2;
                while (freq.ContainsKey((Int32)Math.Pow(x, i)))
                {
                    temp++;
                    if (freq[(Int32)Math.Pow(x, i)] == 1)
                    {
                        count += freq[(Int32)Math.Pow(x, i)];
                        break;
                    }
                    else
                        count += 2;

                    i *= 2;
                }
                
                if (temp != 0)
                    if (count % 2 == 1)
                        max_length = Math.Max(max_length, (int)count);
                    else
                        max_length = Math.Max(max_length, (int)(count - 1));
            }

            return max_length == 0 ? 1 : max_length;
        }

        bool CheckAllOne(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
                if (nums[i] != 1)
                    return false;
            return true;
        }
    }
}
