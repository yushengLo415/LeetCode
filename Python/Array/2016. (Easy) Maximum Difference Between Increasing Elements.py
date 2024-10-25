from typing import List

class Solution:
    def maximumDifference(self, nums: List[int]) -> int:
        max_difference = -1
        min_num = nums[0]

        for i in range(len(nums)):
            max_difference = max(max_difference, nums[i] - min_num)
            min_num = min(min_num, nums[i])


        return max_difference if max_difference != 0 else -1