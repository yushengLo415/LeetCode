from typing import List

class Solution:
    def resolves(self, a,b , Operator):
        if Operator == '+':
            return a + b
        elif Operator == '-':
            return a - b
        elif Operator == '*':
            return a * b

        return int(a / b)

        
    def evalRPN(self, tokens: List[str]) -> int:
        stack = []
        for token in tokens:
            if token.isnumeric() or len(token) > 1:
                stack.append(int(token))
            else:
                b = stack.pop()
                a = stack.pop()
                stack.append(self.resolves(a, b, token))
        
        return stack.pop()