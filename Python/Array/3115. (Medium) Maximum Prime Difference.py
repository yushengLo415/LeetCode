import math
from typing import List

class Solution:
    def isPrime(self, n):
        if n == 1:
            return False
        for i in range(2,int(math.sqrt(n))+1):
            if (n%i) == 0:
                return False
        return True
    
    def maximumPrimeDifference(self, nums: List[int]) -> int:
        isPrime = []
        for i in range(len(nums)):
            if self.isPrime(nums[i]):
                isPrime.append(i)
            
        return max(isPrime) - min(isPrime)
        