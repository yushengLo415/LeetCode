from typing import List

class Solution:
    def intersection(self, nums1: List[int], nums2: List[int]) -> List[int]:
        intersection = set(nums1).intersection(set(nums2))
        return intersection
    
    """
    Another solution:
    def intersection(self, nums1: List[int], nums2: List[int]) -> List[int]:
        dic = dict()
        for num in set(nums1):
            if num not in dic:
                dic[num] = 0
            dic[num] += 1

        for num in set(nums2):
            if num not in dic:
                dic[num] = 0
            dic[num] += 1


        return [key for key, value in dic.items() if value >= 2]
        """