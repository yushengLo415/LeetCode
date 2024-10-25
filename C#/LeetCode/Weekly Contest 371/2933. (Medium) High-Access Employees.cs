using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Weekly_Contest_371
{
    public class Solution2933
    {
        public IList<string> FindHighAccessEmployees(IList<IList<string>> access_times)
        {
            Dictionary<string, List<int>> accessMap = new Dictionary<string, List<int>>();
            List<string> result = new List<string>();

            foreach (IList<string> access in access_times)
            {
                string employee = access[0];
                int time = Convert.ToInt32(access[1]);

                if (!accessMap.ContainsKey(employee))
                    accessMap[employee] = new List<int>();

                accessMap[employee].Add(time);
            }

            foreach (var kvp in accessMap)
            {
                string employee = kvp.Key;
                List<int> accessTimes = kvp.Value;

                accessTimes.Sort();

                for (int i = 0; i < accessTimes.Count - 2; i++)
                {
                    if (accessTimes[i + 2] - accessTimes[i] < 100)
                    {
                        result.Add(employee);
                        break;
                    }
                }
            }

            return result;



        }
    }
}
