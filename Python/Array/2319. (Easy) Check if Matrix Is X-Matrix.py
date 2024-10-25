from typing import List

class Solution:
    def checkXMatrix(self, grid: List[List[int]]) -> bool:
        length = len(grid)
        for i in range(length):
            for j in range(length):
                if (i == j or i + j + 1 == length):
                    if grid[i][j] == 0:
                        return False
                elif grid[i][j] != 0:
                    return False

        return True