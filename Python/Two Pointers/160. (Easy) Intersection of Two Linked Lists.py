# Definition for singly-linked list.
class ListNode:
    def __init__(self, x):
        self.val = x
        self.next = None

class Solution:
    def getIntersectionNode(self, headA: ListNode, headB: ListNode) -> Optional[ListNode]:
        if headA == None or headB == None:
            return None

        copyA = headA
        copyB = headB

        while copyA != copyB:
            copyA = headB if copyA == None else copyA.next
            copyB = headA if copyB == None else copyB.next

        return copyA