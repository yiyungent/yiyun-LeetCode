using System;

namespace _617._合并二叉树
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode-cn.com/problems/merge-two-binary-trees/


        }
    }


    public class Solution
    {


        #region 方法1
        /// <summary>
        /// 时间复杂度: O(min(m, n))，其中 m 和 n 分别是 两棵二叉树 的节点个数。对两个二叉树 同时 进行 深度优先搜索，仅当 两个二叉树中的对应节点都不为空时 才会 对该节点进行显性合并操作，因此 被访问到的节点数不会超过较小的二叉树的节点数
        /// 
        /// 空间复杂度: O(min(m, n)) 其中 m 和 n 分别是 两棵二叉树 的节点个数。空间复杂度取决于 递归调用层数，递归调用层数 不会超过 较小二叉树的最大高度，最坏情况下，二叉树高度等于节点数
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            // 当前有一个根节点为 null 时，返回另一个
            if (t1 == null)
            {
                return t2;
            }
            if (t2 == null)
            {
                return t1;
            }
            TreeNode merged = new TreeNode(t1.val + t2.val);
            merged.left = MergeTrees(t1.left, t2.left);
            merged.right = MergeTrees(t1.right, t2.right);

            return merged;
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
