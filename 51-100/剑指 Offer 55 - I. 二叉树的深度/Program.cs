using System;

namespace 剑指_Offer_55___I._二叉树的深度
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode-cn.com/problems/er-cha-shu-de-shen-du-lcof/
            // 树的遍历方式总体分为两类：深度优先搜索（DFS）、广度优先搜索（BFS）；
            // 常见的 DFS ： 先序遍历、中序遍历、后序遍历；
            // 常见的 BFS ： 层序遍历（即按层遍历）。
            // 参考: https://leetcode-cn.com/problems/er-cha-shu-de-shen-du-lcof/solution/mian-shi-ti-55-i-er-cha-shu-de-shen-du-xian-xu-bia/

            TreeNode treeNode = new TreeNode(3)
            {
                left = new TreeNode(9),
                right = new TreeNode(20)
                {
                    left = new TreeNode(15),
                    right = new TreeNode(7)
                }
            };
            // 返回它的最大深度 3 
            Console.WriteLine(MaxDepth(treeNode));


        }

        #region 方法1: 后序遍历（DFS）
        /// <summary>
        /// 时间复杂度 O(N) ： N 为树的节点数量，计算树的深度需要遍历所有节点
        /// 空间复杂度 O(N) ： 最差情况下（当树退化为链表时），递归深度可达到 N
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        static int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;

            return Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;
        }
        #endregion

    }

    /// <summary>
    /// Definition for a binary tree node.
    /// </summary>
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }


}
