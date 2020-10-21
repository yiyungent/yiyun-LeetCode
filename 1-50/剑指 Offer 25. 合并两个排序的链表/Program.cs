using System;

namespace 剑指_Offer_25._合并两个排序的链表
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1->2->4, 1->3->4
            ListNode l1 = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(4)
                }
            };
            ListNode l2 = new ListNode(1)
            {
                next = new ListNode(3)
                {
                    next = new ListNode(4)
                }
            };
            ListNode result = MergeTwoLists(l1, l2);

            while (result != null)
            {
                Console.Write(result.val + "->");
                result = result.next;
            }

            Console.ReadLine();
        }

        /// <summary>
        /// 双指针 交替前进
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            // dom 伪头结点, 返回 dom.next
            ListNode dom = new ListNode(0), cur = dom;
            while (l1 != null && l2 != null)
            {
                // 要小的那个
                if (l1.val < l2.val)
                {
                    cur.next = l1;
                    // l1 前进
                    l1 = l1.next;
                }
                else
                {
                    cur.next = l2;
                    // l2 前进
                    l2 = l2.next;
                }
                // cur 前进: 准备下一个节点的指向
                cur = cur.next;
            }
            // 合并剩余尾部
            // 跳出时两种情况: l1 为null, 或 l2 为 null
            // 若 l1 != null , 将 l1 添加到节点cur之后
            // 否则: 将 l2 添加到节点 cur 之后
            cur.next = l1 != null ? l1 : l2;

            return dom.next;
        }
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
