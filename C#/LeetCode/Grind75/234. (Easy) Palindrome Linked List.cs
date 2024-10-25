using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Grind75
{
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null) {
            this.val = val;
            this.next = next;
        }
    }
    public class Solution234
    {
        public bool IsPalindrome(ListNode head)
        {
            Stack<int> stack = new Stack<int>();
            ListNode fast_pointer = head;

            while (fast_pointer != null && fast_pointer.next != null)
            {
                stack.Push(head.val);
                head = head.next;
                fast_pointer = fast_pointer.next.next;
            }

            if (fast_pointer != null)
                head = head.next;

            while (head != null)
            {
                if (stack.Pop() != head.val)
                    return false;
                head = head.next;
            }

            return true;
        }
    }
}
