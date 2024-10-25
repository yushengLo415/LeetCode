from typing import Optional

# Definition for singly-linked list.
class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next

class Solution:

    def Add(self, node1, node2):
        if node1 is None:
            return node2.val
        elif node2 is None:
            return node1.val
        else:
            return node1.val + node2.val
            
    def addTwoNumbers(self, l1: Optional[ListNode], l2: Optional[ListNode]) -> Optional[ListNode]:
        carry = 0
        
        l3 = ListNode(0)
        ans = l3

        while l1 or l2:
            
            Sum = self.Add(l1, l2) + carry

            l3.next = ListNode(Sum % 10)
            l3 = l3.next

            carry = Sum // 10 if Sum >= 10 else 0            

            l1 = l1.next if l1 != None else l1
            l2 = l2.next if l2 != None else l2

        if carry != 0:
            l3.next = ListNode(carry)
            
        return ans.next