from typing import List

class Solution:
    def maxProfit(self, prices: List[int]) -> int:
        min_price = prices[0]
        maxprof = 0

        for price in prices[1:]:
            maxprof = max(maxprof, price - min_price)
            min_price = min(price, min_price)

        return maxprof
        