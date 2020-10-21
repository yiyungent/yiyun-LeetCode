using System;

namespace 剑指_Offer_24._反转链表
{
    class Program
    {
        static void Main(string[] args)
        {
            // 输入: 1->2->3->4->5->NULL
            // 输出: 5->4->3->2->1->NULL
            ListNode listNode = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(4)
                        {
                            next = new ListNode(5)
                        }
                    }
                }
            };

            ListNode result = ReverseList(listNode);
            while (result != null)
            {
                Console.Write(result.val + "->");
                result = result.next;
            }

            Console.ReadKey();
        }

        #region 方法1: 双指针
        //static ListNode ReverseList(ListNode head)
        //{
        //    // pre在cur前，cur跟随pre向前一步
        //    ListNode cur = null, pre = head;
        //    while (pre != null)
        //    {
        //        // 记下 pre 的下一步
        //        ListNode temp = pre.next;
        //        // pre反转指向
        //        pre.next = cur;
        //        // cur 向前一步
        //        cur = pre;
        //        // pre 向前一步
        //        pre = temp;
        //    }

        //    return cur;
        //}
        #endregion

        #region 方法二: 递归
        static ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            ListNode ret = ReverseList(head.next);
            // 在递归回退时做操作
            // TODO: 没懂
            head.next.next = head;
            head.next = null;
            return ret;
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
