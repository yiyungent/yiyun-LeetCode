using System;

namespace _226._翻转二叉树
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode-cn.com/problems/invert-binary-tree/
            TreeNode treeNode = new TreeNode(4)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(1),
                    right = new TreeNode(3)
                },
                right = new TreeNode(7)
                {
                    left = new TreeNode(6),
                    right = new TreeNode(9)
                }
            };

            TreeNode result = InvertTree(treeNode);

            Console.ReadLine();
        }


        #region 方法1: 递归
        /// <summary>
        /// 时间复杂度：O(N)，其中 N 为二叉树节点的数目
        /// 空间复杂度：O(N)。使用的空间由递归栈的深度决定，它等于当前节点在二叉树中的高度
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        static TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }
            // 递归
            TreeNode left = InvertTree(root.left);
            TreeNode right = InvertTree(root.right);
            root.left = right;
            root.right = left;
            return root;
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
