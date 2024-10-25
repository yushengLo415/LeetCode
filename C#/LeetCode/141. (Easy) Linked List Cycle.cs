using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LeetCode
{
    

     public class ListNode {

         public int val;
         public ListNode next;
         public ListNode(int x) {
             val = x;
             next = null;
         }
     }
 
    public class Solution141
    {
        public bool HasCycle(ListNode head)
        {
            HashSet<ListNode> nodeHash = new HashSet<ListNode>();

            while (head != null)
            {
                if (nodeHash.Contains(head))
                    return true;

                nodeHash.Add(head);
                head = head.next;
            }

            return false;
        }

        public bool HasCycleTwoPointer(ListNode head)
        {
            HashSet<ListNode> nodeHash = new HashSet<ListNode>();
            ListNode slowPointer = head;
            ListNode fastPointer = head;

            while (slowPointer != null && fastPointer != null)
            {
                if (slowPointer == fastPointer)
                    return true;
                slowPointer = slowPointer.next;
                fastPointer = fastPointer.next.next;
            }
            

            return false;
        }
    }

    /*public class MainClass141
    {
        public static int Main()
        {
            Solution141 sol = new Solution141();
            ListNode n1 = new ListNode(1);
            ListNode n2 = new ListNode(2);
            n1.next = n2;

            Console.WriteLine(sol.HasCycle(n1));


            Thread.Sleep(10000);
            return 0;
        }
    }*/
}
