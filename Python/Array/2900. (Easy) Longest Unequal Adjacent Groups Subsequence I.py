from typing import List

class Solution:
    def getLongestSubsequence(self, words: List[str], groups: List[int]) -> List[str]:
        n = len(words)
        result = []
        result.append(words[0])
        for i in range(1, n):
            if groups[i - 1] != groups[i]:
                result.append(words[i])

        return result