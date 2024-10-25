using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Grind75
{
    class Solution206
    {
        public ListNode ReverseList(ListNode head)
        {

            ListNode NewHead = null;
            ListNode KeepNext;

            while (head != null)
            {
                KeepNext = head.next;
                head.next = NewHead;
                NewHead = head;
                head = KeepNext;
            }

            return NewHead;
        }
    }
}
