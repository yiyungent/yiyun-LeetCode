using System;

namespace 剑指_Offer_22._链表中倒数第k个节点
{
    class Program
    {
        static void Main(string[] args)
        {
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

            ListNode result = GetKthFromEnd(listNode, 2);

            while (result != null)
            {
                Console.Write(result.val + "->");
                result = result.next;
            }

            Console.ReadLine();
        }

        #region 方法一:自己想的: 循环遍历+正数置换倒数
        //static ListNode GetKthFromEnd(ListNode head, int k)
        //{
        //    ListNode temp = head;
        //    // 链表长度
        //    int size = 0;
        //    while (temp != null)
        //    {
        //        temp = temp.next;
        //        size++;
        //    }
        //    ListNode rtn = head;
        //    // 倒数第k个 就是 正数 第 size-k+1 个
        //    // 正数 第 n 个，需要 n-1次 next,  即 size-k
        //    for (int i = 0; i < size - k; i++)
        //    {
        //        rtn = rtn.next;
        //    }

        //    return rtn;
        //} 
        #endregion

        #region 方法二：双指针:不专门统计链表长度, 慢指针跟随快指针(在其后k-1间隔)
        /// <summary>
        /// 时间复杂度: O(n) :n为链表长度，总体看， former 走了n步，latter，走了 n-k步
        /// 空间复杂度: O(1) :双指针 former, latter 使用常数大小的额外空间
        /// </summary>
        /// <param name="head"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        static ListNode GetKthFromEnd(ListNode head, int k)
        {
            ListNode former = head, latter = head;
            // 让快指针先走出 k 的长度
            // k 次 next, 与慢指针中间相隔 k - 1 个节点
            for (int i = 0; i < k; i++)
            {
                former = former.next;
            }
            // 同时前进 - 直到 former快指针指向末尾后null
            while (former != null)
            {
                former = former.next;
                latter = latter.next;
            }

            return latter;
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
