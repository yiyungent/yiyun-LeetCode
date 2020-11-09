using System;
using System.Collections.Generic;

namespace _1290._二进制链表转整数
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode-cn.com/problems/convert-binary-number-in-a-linked-list-to-integer/
            // head = [1,0,1]
            ListNode listNode = new ListNode(1)
            {
                next = new ListNode(0)
                {
                    next = new ListNode(1)
                }
            };
            Console.WriteLine(GetDecimalValue(listNode));

        }

        #region 方法1
        ///// <summary>
        ///// 遍历了两次，时间开销大，中途还用一个list存储
        ///// </summary>
        ///// <param name="head"></param>
        ///// <returns></returns>
        //static int GetDecimalValue(ListNode head)
        //{
        //    ListNode node = head;
        //    List<int> list = new List<int>();
        //    while (node != null)
        //    {
        //        list.Add(node.val);
        //        node = node.next;
        //    }
        //    int rtn = 0;
        //    for (int i = list.Count - 1; i >= 0; i--)
        //    {
        //        rtn += list[i] == 1 ? (int)Math.Pow(2, list.Count - 1 - i) : 0;
        //    }

        //    return rtn;
        //}
        #endregion

        #region 方法2
        /// <summary>
        /// 时间复杂度： O(N)，其中 NN 是链表中的节点个数
        /// 空间复杂度： O(1)
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        static int GetDecimalValue(ListNode head)
        {
            ListNode cur = head;
            int ans = 0;
            while (cur != null)
            {
                // TODO: 没懂为什么可以这么做
                ans = ans * 2 + cur.val;
                cur = cur.next;
            }

            return ans;
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
