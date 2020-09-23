using System;

namespace 剑指_Offer_52._两个链表的第一个公共节点
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode publicNode = new ListNode(7);

            ListNode headA = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(4)
                    {
                        next = publicNode
                    }
                }
            };

            publicNode.next = new ListNode(9)
            {
                next = new ListNode(-4)
            };
            ListNode headB = new ListNode(2)
            {
                next = publicNode,
            };

            ListNode firstPublicNode = GetIntersectionNode(headA, headB);
            Console.WriteLine(firstPublicNode.val);

            Console.ReadLine();
        }

        /// <summary>
        /// 双指针法
        /// </summary>
        /// <param name="headA"></param>
        /// <param name="headB"></param>
        /// <returns></returns>
        static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            ListNode node1 = headA, node2 = headB;
            // 双指针同时前进，指针到末尾，则交替到另一链表头
            while (node1 != node2)
            {
                node1 = node1 != null ? node1.next : headB;
                node2 = node2 != null ? node2.next : headA;
            }
            return node1;
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
