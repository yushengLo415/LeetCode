from typing import List

class Solution:
    def intersect(self, nums1: List[int], nums2: List[int]) -> List[int]:
        nums1Arr = sorted(nums1)
        nums2Arr = sorted(nums2)

        i = 0
        j = 0

        ans = []
        while i < len(nums1Arr) and j < len(nums2Arr):
            if nums1Arr[i] > nums2Arr[j]:
                j += 1
            elif nums2Arr[j] > nums1Arr[i]:
                i += 1
            else:
                ans.append(nums1Arr[i])
                i += 1
                j += 1

        return ans