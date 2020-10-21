using System;
using System.Collections.Generic;

namespace 剑指_Offer_09._用两个栈实现队列
{
    class Program
    {
        static void Main(string[] args)
        {
            CQueue obj = new CQueue();
            obj.AppendTail(1);
            obj.AppendTail(2);
            obj.AppendTail(3);
            obj.AppendTail(4);
            obj.AppendTail(5);
            int param_1 = obj.DeleteHead();
            Console.WriteLine(param_1);
            int param_2 = obj.DeleteHead();
            Console.WriteLine(param_2);
            int param_3 = obj.DeleteHead();
            Console.WriteLine(param_3);



            Console.ReadLine();
        }
    }

    public class CQueue
    {
        /// <summary>
        /// 栈1 负责维护 插入
        /// </summary>
        private Stack<int> _stack1;

        /// <summary>
        /// 栈2 负责维护 删除
        /// </summary>
        private Stack<int> _stack2;

        public CQueue()
        {
            _stack1 = new Stack<int>();
            _stack2 = new Stack<int>();
        }

        public void AppendTail(int value)
        {
            _stack1.Push(value);
        }

        public int DeleteHead()
        {
            if (_stack2.Count == 0)
            {
                // 注意: 只有当栈2 中没有元素时，才从栈1 中取, 否则直接弹出
                // 要删除时, 先将 栈1的元素全部弹出，全部压入 栈2, 这样弹出栈2 时 顺序就逆序了 -> 两栈实现队列
                while (_stack1.Count > 0)
                {
                    _stack2.Push(_stack1.Pop());
                }
            }
            if (_stack2.Count > 0)
            {
                // 栈2 中有元素
                return _stack2.Pop();
            }
            else
            {
                // 栈2 中无元素: 返回 -1
                return -1;
            }
        }
    }
}
