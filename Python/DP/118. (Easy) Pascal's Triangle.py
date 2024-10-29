from typing import List

class Solution:
    def generate(self, numRows: int) -> List[List[int]]:

        result = []
        for i in range(numRows):
            newRow = [1] * (i + 1)

            for j in range(1, i):
                newRow[j] = result[i - 1][j - 1] + result[i - 1][j]

            result.append(newRow)

        return result


        