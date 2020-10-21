using System;

namespace 剑指_Offer_18._删除链表的节点
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode head = new ListNode(4)
            {
                next = new ListNode(5)
                {
                    next = new ListNode(1)
                    {
                        next = new ListNode(9)
                    }
                }
            };


            ListNode node = DeleteNode(head, 5);

            while (node != null)
            {
                Console.WriteLine(node.val);

                node = node.next;
            }




            Console.ReadLine();

        }

        #region 方法一: 双指针: curr当前节点, prev上一个节点
        static ListNode DeleteNode(ListNode head, int val)
        {
            // 初始化一个虚拟节点
            ListNode dummy = new ListNode(0);
            // 让虚拟节点指向头节点
            dummy.next = head;
            ListNode prev = dummy;
            while (prev != null && prev.next != null)
            {
                ListNode curr = prev.next;
                if (curr.val == val)
                {
                    // 找到要求被删除的节点
                    // 删除当前节点: 上个节点指向当前节点的下个节点
                    prev.next = curr.next;
                    break;
                }
                else
                {
                    // 当前节点 不为被删除的节点，则在进行下一次循环时，沦为上一个节点
                    prev = curr;
                }
            }

            return dummy.next;
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
