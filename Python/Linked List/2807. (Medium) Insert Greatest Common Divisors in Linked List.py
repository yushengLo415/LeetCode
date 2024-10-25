from typing import Optional
import math

# Definition for singly-linked list.
class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next
class Solution:

    def insertGreatestCommonDivisors(self, head: Optional[ListNode]) -> Optional[ListNode]:
        ans = head

        while head and head.next:
            nextNode = head.next
            gcd = math.gcd(head.val, nextNode.val)
            head.next = ListNode(gcd)
            head.next.next = nextNode
            head = nextNode

        return ans