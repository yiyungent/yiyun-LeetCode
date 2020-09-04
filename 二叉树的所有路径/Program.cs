using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 二叉树的所有路径
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode treeNode = new TreeNode(1);
            treeNode.left = new TreeNode(2) { right = new TreeNode(5) };
            treeNode.right = new TreeNode(3);

            var paths = BinaryTreePaths(treeNode);
            foreach (var path in paths)
            {
                Console.WriteLine(path);
            }

            Console.ReadLine();
        }

        #region 深度优先
        public static IList<string> BinaryTreePaths(TreeNode root)
        {
            IList<string> paths = new List<string>();
            ConstructPaths(root, "", paths);
            return paths;
        }

        public static void ConstructPaths(TreeNode root, string path, IList<string> paths)
        {
            if (root != null)
            {
                StringBuilder pathSb = new StringBuilder(path);
                pathSb.Append(root.val);
                if (root.left == null && root.right == null)
                {
                    // 叶子节点
                    // 把路径加入到答案中
                    paths.Add(pathSb.ToString());
                }
                else
                {
                    // 非叶子节点
                    // 当前节点不是叶子节点，继续递归遍历
                    pathSb.Append("->");
                    ConstructPaths(root.left, pathSb.ToString(), paths);
                    ConstructPaths(root.right, pathSb.ToString(), paths);
                }
            }
        } 
        #endregion
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
}
