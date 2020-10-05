using System;
using System.Collections.Generic;

namespace 剑指_Offer_30._包含min函数的栈
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode-cn.com/problems/bao-han-minhan-shu-de-zhan-lcof/solution/mian-shi-ti-30-bao-han-minhan-shu-de-zhan-fu-zhu-z/


            MinStack minStack = new MinStack();
            minStack.Push(-2);
            minStack.Push(0);
            minStack.Push(-3);
            Console.WriteLine(minStack.Min());
            minStack.Pop();
            Console.WriteLine(minStack.Top());
            Console.WriteLine(minStack.Min());


        }
    }

    /// <summary>
    /// 时间复杂度: O(1): Push(), Pop(), Top(), Min() 四函数的时间复杂度均为常数级别
    /// 空间复杂度: O(n): 当共有n个待入栈元素时，辅助栈B最差情况下存储n个元素，使用 O(n) 额外空间
    /// </summary>
    public class MinStack
    {
        private Stack<int> _stackA, _stackB;

        /** initialize your data structure here. */
        public MinStack()
        {
            _stackA = new Stack<int>();
            _stackB = new Stack<int>();
        }

        /// <summary>
        /// 重点为保持栈 BB 的元素是 非严格降序 的。
        /// 1. 将 x 压入栈A
        /// 2. 若栈B为空 或 x 小于等于 栈B 的栈顶元素，则将 x 压入栈B
        /// </summary>
        /// <param name="x"></param>
        public void Push(int x)
        {
            _stackA.Push(x);
            if (_stackB.Count == 0 || x <= _stackB.Peek())
            {
                _stackB.Push(x);
            }
        }

        /// <summary>
        /// 重点为保持栈 A, BA,B 的 元素一致性 
        /// 1. 执行栈A出栈，出栈元素y
        /// 2. 若y等于栈B的栈顶元素，则执行栈B出栈
        /// </summary>
        public void Pop()
        {
            // 若主栈A 弹出的和 辅助栈B 栈顶相同，则也弹出栈B： 维护元素一致性
            if (_stackA.Pop().Equals(_stackB.Peek()))
            {
                _stackB.Pop();
            }
        }

        /// <summary>
        /// 直接返回栈 AA 的栈顶元素即可
        /// </summary>
        /// <returns></returns>
        public int Top()
        {
            return _stackA.Peek();
        }

        /// <summary>
        /// 直接返回栈 BB 的栈顶元素即可
        /// </summary>
        /// <returns></returns>
        public int Min()
        {
            return _stackB.Peek();
        }
    }

    /**
     * Your MinStack object will be instantiated and called as such:
     * MinStack obj = new MinStack();
     * obj.Push(x);
     * obj.Pop();
     * int param_3 = obj.Top();
     * int param_4 = obj.Min();
     */
}
