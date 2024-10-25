# Definition for singly-linked list.
class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next
        
class Solution:
    def getDecimalValue(self, head: ListNode) -> int:

        stack = []
        result = 0

        while head:
            stack.append(head.val)
            head = head.next

        for i in range(len(stack)):
            result += stack.pop() * (2**i)

        return result
        