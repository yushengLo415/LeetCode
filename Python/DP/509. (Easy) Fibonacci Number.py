
class Solution:
    """
    # solution 1
    def fib(self, n: int) -> int:
        if n == 1:
            return 1
        if n == 0:
            return 0

        return self.fib(n - 1) + self.fib(n - 2)
    """

    # solution 2
    def fib(self, n: int) -> int:
        if n <= 1:
            return n
            
        dp = [0] * (n + 1)

        dp[0] = 0
        dp[1] = 1

        for i in range(2, n + 1):
            dp[i] = dp[i - 1] + dp[i - 2]

        return dp[n]

   