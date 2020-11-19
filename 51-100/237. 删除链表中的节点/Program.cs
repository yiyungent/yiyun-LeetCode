using System;

namespace _237._删除链表中的节点
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode-cn.com/problems/delete-node-in-a-linked-list/
            Solution sol = new Solution();
            ListNode deletedNode = new ListNode(5);
            deletedNode.next = new ListNode(1)
            {
                next = new ListNode(9)
            };
            //  [4,5,1,9]
            ListNode listNode = new ListNode(4)
            {
                next = deletedNode
            };


            // 传入函数的唯一参数为 要被删除的节点
            sol.DeleteNode(deletedNode);

            while (listNode != null)
            {
                Console.Write(listNode.val + " ");
                listNode = listNode.next;
            }

        }

    }


    public class Solution
    {

        #region 方法1
        /// <summary>
        /// 时间复杂度: O(1)
        /// 空间复杂度: O(1)
        /// </summary>
        /// <param name="node"></param>
        public void DeleteNode(ListNode node)
        {
            // 将要删除节点的值 换为下一个节点 的值
            node.val = node.next.val;
            // 再将要删除的节点 指向 下下个节点，即跳过下个节点
            node.next = node.next.next;
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
