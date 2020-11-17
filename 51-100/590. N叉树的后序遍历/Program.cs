using System;
using System.Collections.Generic;

namespace _590._N叉树的后序遍历
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode-cn.com/problems/n-ary-tree-postorder-traversal/




        }


        #region 方法1: 迭代

        static List<int> _list;

        static Stack<Node> _stack;

        static IList<int> Postorder(Node root)
        {
            _list = new List<int>();
            _stack = new Stack<Node>();
            Order(root);

            return _list;
        }

        static void Order(Node root)
        {
            if (root == null) return;

            _stack.Push(root);
            Node current;

            while (_stack.Count != 0)
            {
                current = _stack.Pop();
                _list.Add(current.val);
                foreach (Node child in current.children)
                {
                    _stack.Push(child);
                }
            }
            _list.Reverse();
        }
        #endregion


        /// <summary>
        /// Definition for a Node.
        /// </summary>
        public class Node
        {
            public int val;
            public IList<Node> children;

            public Node() { }

            public Node(int _val)
            {
                val = _val;
            }

            public Node(int _val, IList<Node> _children)
            {
                val = _val;
                children = _children;
            }
        }


    }
}
