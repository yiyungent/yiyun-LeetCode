using System;
using System.Collections;
using System.Collections.Generic;

namespace 二叉树的层次遍历II
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

            var listList = LevelOrderBottom(treeNode);
            foreach (var list in listList)
            {
                foreach (var item in list)
                {
                    Console.Write(item + ",");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }

        public static IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            IList<IList<int>> levelOrder = new List<IList<int>>();
            if (root == null)
            {
                return levelOrder;
            }

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                IList<int> level = new List<int>();
                int count = queue.Count;
                for (int i = 0; i < count; i++)
                {
                    TreeNode node = queue.Dequeue();
                    level.Add(node.val);
                    TreeNode left = node.left, right = node.right;
                    if (left != null)
                    {
                        queue.Enqueue(left);
                    }
                    if (right != null)
                    {
                        queue.Enqueue(right);
                    }
                }

                // 插入到最前面
                levelOrder.Insert(0, level);
            }

            return levelOrder;
        }



    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
}
