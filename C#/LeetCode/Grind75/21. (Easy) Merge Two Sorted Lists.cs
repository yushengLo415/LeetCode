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
            ListNode dummyNode = new ListNode();
            ListNode head = dummyNode;


            // 1 2 4
            // 3 3 4
            while (list1 != null && list2 != null)
            {
                if (list1.val > list2.val)
                {
                    dummyNode.next = list2;
                    list2 = list2.next;
                }
                else
                {
                    dummyNode.next = list1;
                    list1 = list1.next;
                }

                dummyNode = dummyNode.next;
            }

            if (list1 != null)
                dummyNode.next = list1;
            if (list2 != null)
                dummyNode.next = list2;

            return head.next;
        }

       /* static int Main()
        {
            ListNode n1 = new ListNode(1);
            ListNode n2 = new ListNode(2);
            ListNode n3 = new ListNode(4);
            ListNode n4 = new ListNode(3);
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
        }*/
    }
}
