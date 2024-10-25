class Solution:
    def isHappy(self, n: int) -> bool:

        Set = set()
        result = n

        while result != 1:
            Sum = 0
            while result != 0:
                num = result % 10
                Sum += num**2
                result = int(result / 10)

            result = Sum

            if result not in Set:
                Set.add(result)
            else:
                break
        
        if result != 1:
            return False

        return True