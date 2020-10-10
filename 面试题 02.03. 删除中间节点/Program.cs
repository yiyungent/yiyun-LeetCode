using System;

namespace 面试题_02._03._删除中间节点
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode-cn.com/problems/delete-middle-node-lcci/
            ListNode deletedNode = new ListNode(3)
            {
                next = new ListNode(4)
                {
                    next = new ListNode(5)
                }
            };
            ListNode listNode = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = deletedNode
                }
            };

            DeleteNode(deletedNode);

            ListNode temp = listNode;
            while (temp != null)
            {
                Console.Write(temp.val + "->");
                temp = temp.next;
            }


            Console.ReadLine();
        }

        #region 方法1: 狸猫换太子
        static void DeleteNode(ListNode node)
        {
            // 利用单链表的一个节点,并删除该节点
            // 由于只能知道 此节点的下一个节点地址
            // 而此节点的上一个节点保存的是此节点的地址, 所以删除此节点，即需将此节点 【变为】 下一个节点, 然后删除此节点的下一个节点
            // 注意: 此节点上一个节点的 next 保存的是此节点地址，所以需选择变换数据，而不是地址
            // 此节点的数据 替换为下一节点的对应数据
            node.val = node.next.val;
            // 删除下一节点
            node.next = node.next.next;

            // 狸猫换太子: 即此节点内存地址不变，因为上一节点.next就是保存的地址，所以不能变，而是把下一节点的数据复制过来，下一节点的next指向地址也复制过来, 我（此节点）虽没变，但数据变了
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
