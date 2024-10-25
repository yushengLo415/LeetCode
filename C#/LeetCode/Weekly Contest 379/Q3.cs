using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Weekly_Contest_379
{
    class Q3
    {
        public int MaximumSetSize(int[] nums1, int[] nums2)
        {
            int n = nums1.Length / 2; // n/2 elements need to be removed

            Dictionary<int, int> dict1 = new Dictionary<int, int>();
            Dictionary<int, int> dict2 = new Dictionary<int, int>();

            foreach (int i in nums1)
            {
                if (!dict1.ContainsKey(i))
                    dict1[i] = 0;
                dict1[i]++;
            }

            foreach (int i in nums2)
            {
                if (!dict2.ContainsKey(i))
                    dict2[i] = 0;
                dict2[i]++;
            }

            // Sort the dictionaries by frequency in descending order
            var sortedDict1 = dict1.OrderByDescending(kv => kv.Value).ToDictionary(kv => kv.Key, kv => kv.Value);
            var sortedDict2 = dict2.OrderByDescending(kv => kv.Value).ToDictionary(kv => kv.Key, kv => kv.Value);

            // Combine the sorted keys of both dictionaries
            List<int> allKeys = sortedDict1.Keys.Concat(sortedDict2.Keys).ToList();

            // Initialize a set to store selected elements
            HashSet<int> selectedSet = new HashSet<int>();

            // Greedy selection of elements until the set size reaches n
            int setSize = 0;
            foreach (int key in allKeys)
            {
                if (setSize + Math.Min(dict1[key], dict2[key]) <= n)
                {
                    selectedSet.Add(key);
                    setSize += Math.Min(dict1[key], dict2[key]);
                }
                else
                {
                    break;
                }
            }

            return setSize * 2; // Return the maximum possible size of the set s
        }
    }
}
