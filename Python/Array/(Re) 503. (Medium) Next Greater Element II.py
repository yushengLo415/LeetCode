from typing import List

class Solution:
    def nextGreaterElements(self, nums: List[int]) -> List[int]:
        n = len(nums)
        next_greater = []
        stack = []

        for i in range(2*n, -1, -1):
            while stack and stack[-1] <= nums[i % n]:
                stack.pop()
            
            if not stack:
                next_greater.append(-1)
            else:
                next_greater.append(stack[-1])
            stack.append(nums[i % n])

        return next_greater[::-1][:n]
