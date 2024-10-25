class Solution:
    def romanToInt(self, s: str) -> int:
        mappingTable = {
            'I':1,
            'V':5,
            'X':10,
            'L':50,
            'C':100,
            'D':500,
            'M':1000
        }

        result = 0

        for i in range(len(s) - 1):
            if mappingTable[s[i]] < mappingTable[s[i + 1]]:
                result -= mappingTable[s[i]] 
            else:
                result += mappingTable[s[i]] 
        
        result += mappingTable[s[len(s) - 1]]
        return result


