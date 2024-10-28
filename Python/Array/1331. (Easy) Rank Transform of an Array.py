from typing import List

class Solution:
    """
    def arrayRankTransform(self, arr: List[int]) -> List[int]:
        ranks = {}
        rank = 1
        sortedArr = sorted(arr)
        
        for num in sortedArr:
            if num not in ranks:
                ranks[num] = rank
                rank += 1
        return [ranks[num] for num in arr]
    """

    def arrayRankTransform(self, arr: List[int]) -> List[int]:
        nums = sorted(set(arr))
        rank = 1
        ranks = {}

        for num in nums:
            ranks[num] = rank
            rank += 1

        return [ranks[num] for num in arr]
