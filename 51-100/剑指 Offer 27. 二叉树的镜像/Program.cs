using System;

namespace 剑指_Offer_27._二叉树的镜像
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode-cn.com/problems/er-cha-shu-de-jing-xiang-lcof/
            // 此题与 翻转二叉树 一致

        }


        #region 方法1: 递归
        /// <summary>
        /// 时间复杂度 O(N)： 其中 N 为二叉树的节点数量，建立二叉树镜像需要遍历树的所有节点，占用 O(N) 时间
        /// 空间复杂度 O(N) ： 最差情况下（当为满二叉树时），栈 stack最多同时存储 N/2 个节点，占用 O(N) 额外空间
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        static TreeNode MirrorTree(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }
            TreeNode temp = root.left;
            root.left = MirrorTree(root.right);
            root.right = MirrorTree(temp);

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
