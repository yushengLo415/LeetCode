class Solution:
    def maxRepeating(self, sequence: str, word: str) -> int:
        n = len(sequence)
        m = len(word)
        dp = [0] * (n + 1)

        for i in range(n - m + 1):
            if sequence[i : i + m] == word:
                dp[i] = dp[i - m] + 1
        
        return max(dp)