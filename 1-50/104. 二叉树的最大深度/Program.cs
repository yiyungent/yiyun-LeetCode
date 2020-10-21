using System;

namespace _104._二叉树的最大深度
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode treeNode = new TreeNode(3);
            treeNode.left = new TreeNode(9);
            treeNode.right = new TreeNode(20)
            {
                left = new TreeNode(15),
                right = new TreeNode(7)
            };

            Console.WriteLine(MaxDepth(treeNode));
        }

        #region 方法1：递归
        /// <summary>
        /// 空间复杂度: O(Height) : Height 为二叉树深度  递归函数需要栈空间，而栈空间取决于递归的深度，因此空间复杂度等价于二叉树的高度
        /// 时间复杂度: O(n) : n 节点个数
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        static int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            int leftHeight = MaxDepth(root.left);
            int rightHeight = MaxDepth(root.right);

            return Math.Max(leftHeight, rightHeight) + 1;
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
