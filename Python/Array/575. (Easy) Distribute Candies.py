from typing import List

class Solution:
    def distributeCandies(self, candyType: List[int]) -> int:
        typeCount = len(set(candyType))
        return typeCount if typeCount < len(candyType) // 2 else len(candyType) // 2