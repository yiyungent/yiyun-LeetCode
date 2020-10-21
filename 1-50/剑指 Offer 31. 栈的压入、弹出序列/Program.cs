using System;
using System.Collections;
using System.Collections.Generic;

namespace 剑指_Offer_31._栈的压入_弹出序列
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pushed = { 1, 2, 3, 4, 5 };
            int[] popped = { 4, 5, 3, 2, 1 };
            Console.WriteLine(ValidateStackSequences(pushed, popped));
        }

        static bool ValidateStackSequences(int[] pushed, int[] popped)
        {
            Stack<int> stack = new Stack<int>();
            int i = 0;
            foreach (var num in pushed)
            {
                // num 入栈
                stack.Push(num);
                while (stack.Count != 0 && stack.Peek() == popped[i]) // 循环判断与出栈
                {
                    // 将栈顶元素 与 当前指针指向值相等的 全弹出
                    stack.Pop();
                    i++;
                }
            }
            return stack.Count == 0;
        }



    }
}
