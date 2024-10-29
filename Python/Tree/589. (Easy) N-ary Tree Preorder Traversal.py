# Definition for a Node.
class Node:
    def __init__(self, val: Optional[int] = None, children: Optional[List['Node']] = None):
        self.val = val
        self.children = children


from typing import List, Optional

class Solution:
    def preorder(self, root: 'Node') -> List[int]:
        if root is None:
            return None
            
        result = []
        result.append(root.val)

        for node in root.children:
            result += self.preorder(node)

        return result