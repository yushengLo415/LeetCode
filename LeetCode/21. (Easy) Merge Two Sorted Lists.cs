using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LeetCode
{
    class Solution21
    {
        
        public class ListNode {
            public int val;
            public ListNode next;
            public ListNode(int val=0, ListNode next=null) {
                this.val = val;
                this.next = next;
            }
        }
        
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            List<ListNode> list = new List<ListNode>();

            while(list1 != null && list2 != null)
            {
                if (list1.val >= list2.val)
                {
                    list.Add(list2);
                    list2 = list2.next;
                }
                else
                {
                    list.Add(list1);
                    list1 = list1.next;
                }
            }

            if (list1 == null)
                list.Add(list2);
            else if (list2 == null)
                list.Add(list1);

            for (int i = 0; i < list.Count - 1; i++)
            {
                list[i].next = list[i + 1];
            }

            if (list.Count == 0)
                return null;

            return list[0];
        }

        static int Main()
        {
            ListNode n1 = new ListNode(1);
            ListNode n2 = new ListNode(2);
            ListNode n3 = new ListNode(4);
            ListNode n4 = new ListNode(1);
            ListNode n5 = new ListNode(3);
            ListNode n6 = new ListNode(4);
            n1.next = n2;
            n2.next = n3;
            n4.next = n5;
            n5.next = n6;

            Solution21 sol = new Solution21();
            Console.WriteLine(sol.MergeTwoLists(n1, n4).val);
            Thread.Sleep(10000);
            return 0;
        }
    }
}
