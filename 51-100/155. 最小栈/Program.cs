using System;
using System.Collections;
using System.Collections.Generic;

namespace _155._最小栈
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode-cn.com/problems/min-stack/

            // ["MinStack","push","push","push","getMin","pop","top","getMin"]
            // [[],[-2],[0],[-3],[],[],[],[]]

            /**
            * Your MinStack object will be instantiated and called as such:
            * MinStack obj = new MinStack();
            * obj.Push(x);
            * obj.Pop();
            * int param_3 = obj.Top();
            * int param_4 = obj.GetMin();
            */

            MinStack obj = new MinStack();
            obj.Push(-2);
            obj.Push(0);
            obj.Push(-3);
            int min1 = obj.GetMin();
            Console.WriteLine(min1);
            obj.Pop();
            int top1 = obj.Top();
            Console.WriteLine(top1);
            int min2 = obj.GetMin();
            Console.WriteLine(min2);
        }
    }

    public class MinStack
    {
        private Stack<int> _xStack;
        private Stack<int> _minStack;

        /** initialize your data structure here. */
        public MinStack()
        {
            _xStack = new Stack<int>();
            _minStack = new Stack<int>();
            _minStack.Push(int.MaxValue);
        }

        public void Push(int x)
        {
            _xStack.Push(x);
            _minStack.Push(Math.Min(_minStack.Peek(), x));
        }

        public void Pop()
        {
            _xStack.Pop();
            _minStack.Pop();
        }

        public int Top()
        {
            return _xStack.Peek();
        }

        public int GetMin()
        {
            return _minStack.Peek();
        }
    }

}
