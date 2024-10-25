using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Grind75
{
    class Solution232
    {
        public class MyQueue
        {

            Stack<int> stack = new Stack<int>();
            Stack<int> tempStack = new Stack<int>();

            public MyQueue()
            {

            }

            public void Push(int x)
            {
                while (stack.Count > 0)
                    tempStack.Push(stack.Pop());

                tempStack.Push(x);

                while (tempStack.Count > 0)
                    stack.Push(tempStack.Pop());
            }

            public int Pop()
            {
                return stack.Pop();
            }

            public int Peek()
            {
                return stack.Peek();
            }

            public bool Empty()
            {
                return stack.Count == 0;
            }
        }
    }
}
