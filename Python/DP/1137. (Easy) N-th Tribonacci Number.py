class Solution:
    def tribonacci(self, n: int) -> int:
        if n == 0:
            return 0
        if n <= 2:
            return 1
            
        dp = [0] * (n + 1)
        dp[0], dp[1], dp[2] = 0, 1, 1

        for i in range(0, n - 2):
            dp[i + 3] = dp[i] + dp[i + 1] + dp[i + 2]

        return dp[-1]