class Solution:
    def wordPattern(self, pattern: str, s: str) -> bool:

        word = s.split(' ')
        dic = dict()

        if len(pattern) != len(word):
            return False

        if len(set(pattern)) != len(set(word)):
            return False

        for i in range(len(pattern)):
            if pattern[i] not in dic:
                dic[pattern[i]] = word[i]
            elif (dic[pattern[i]] == word[i]) == False:
                    return False

        return True