using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Grind75
{
    public class Solution876
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                    this.val = val;
                    this.next = next;
            }
        }

        public ListNode MiddleNode(ListNode head)
        {
            ListNode slowPointer = head;
            ListNode fastPointer = head;

            while (fastPointer != null && fastPointer.next != null)
            {
                fastPointer = fastPointer.next.next;
                slowPointer = slowPointer.next;
            }
            return slowPointer;
        }
    }
}
