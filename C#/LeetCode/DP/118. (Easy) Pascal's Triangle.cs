using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Solution118
    {
        public IList<IList<int>> Generate(int numRows)
        {
            List<IList<int>> list = new List<IList<int>>();

            if (numRows == 0)
                return list;

            list.Add(new List<int>() { 1 });

            for (int i = 1; i < numRows; i++)
            {

                List<int> preRow = (List<int>)list[i - 1];
                List<int> newRow = new List<int>() { 1 };

                for (int j = 1; j < preRow.Count; j++)
                {
                    newRow.Add(preRow[j - 1] + preRow[j]);
                }

                newRow.Add(1);
                list.Add(newRow);
            }

            return list;
        }
    }

}
