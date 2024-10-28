from typing import Optional

# Definition for a Node.
class Node:
    def __init__(self, val = 0, neighbors = None):
        self.val = val
        self.neighbors = neighbors if neighbors is not None else []

class Solution:

    def cloneGraph(self, node: Optional['Node']) -> Optional['Node']:
        if node is None:
            return None

        clone = {}
         
        def dfs(self, node):
            if node in clone:
                return clone[node]

            newNode = Node(node.val)
            clone[node] = newNode
            for neighbor in node.neighbors:
                newNode.neighbors.append(dfs(self, neighbor))

            return newNode  

        dfs(self, node)

        return clone[node]

            


            