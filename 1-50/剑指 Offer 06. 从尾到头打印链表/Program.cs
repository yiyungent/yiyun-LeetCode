using System;
using System.Collections.Generic;

namespace 剑指_Offer_06._从尾到头打印链表
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode head = new ListNode(1)
            {
                next = new ListNode(3)
                {
                    next = new ListNode(2)
                }
            };

            int[] arr = ReversePrint(head);

            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();
        }

        #region 方法一:
        //static int[] ReversePrint(ListNode head)
        //{
        //    List<int> list = new List<int>();
        //    while (head != null)
        //    {
        //        // 插入到最前面 -> 逆序
        //        // 效率低: 在前面插入，需移动后面元素的位置
        //        list.Insert(0, head.val);
        //        head = head.next;
        //    }

        //    return list.ToArray();
        //}
        #endregion

        #region 方法二:栈
        /// <summary>
        /// 时间复杂度: O(n)     正向遍历一遍链表，然后从栈弹出全部节点，等于又反向遍历一遍链表。
        /// 空间复杂度: O(n)     额外使用一个栈存储链表中的每个节点。
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        //static int[] ReversePrint(ListNode head)
        //{
        //    Stack<ListNode> stack = new Stack<ListNode>();
        //    while (head != null)
        //    {
        //        stack.Push(head);
        //        head = head.next;
        //    }
        //    int size = stack.Count;
        //    int[] rtn = new int[size];
        //    for (int i = 0; i < size; i++)
        //    {
        //        rtn[i] = stack.Pop().val;
        //    }

        //    return rtn;
        //}
        #endregion

        #region 方法三:栈：直接存储值
        static int[] ReversePrint(ListNode head)
        {
            Stack<int> stack = new Stack<int>();
            while (head != null)
            {
                stack.Push(head.val);
                head = head.next;
            }
            int size = stack.Count;
            int[] rtn = new int[size];
            for (int i = 0; i < size; i++)
            {
                rtn[i] = stack.Pop();
            }
            return rtn;
        }
        #endregion
    }

    /// <summary>
    /// Definition for singly-linked list.
    /// </summary>
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
