using lab2_3semester;
using System.Collections.Generic;
using System.Collections;
using System.Xml.Linq;

namespace lab2_3semester
{
    public class BinaryTree<T> : IEnumerable<T> where T : IComparable
    {
        BinaryTreeNode<T> root;
        public BinaryTree()
        {
            root = null;
        }
        public BinaryTree(T data)
        {
            root = new BinaryTreeNode<T>(data);
        }

        public void AddItem(T data)
        {
            if (root == null)
                root = new BinaryTreeNode<T>(data);
            else
                AddIncer(root, new BinaryTreeNode<T>(data));
        }
        private void AddIncer(BinaryTreeNode<T> _root, BinaryTreeNode<T> newNode)
        {
            if (root == null)
                _root = newNode;
            try
            {
                if (newNode.Data.CompareTo(_root.Data) < 0)
                {
                    if (_root.LeftNode == null)
                        _root.LeftNode = newNode;
                    else
                        AddIncer(_root.LeftNode, newNode);
                }
                else
                {
                    if (_root.RightNode == null)
                        _root.RightNode = newNode;
                    else
                        AddIncer(_root.RightNode, newNode);
                }
            }
            catch (Exception message)
            {
                Console.WriteLine(message);
            }

        }

        private void Print(BinaryTreeNode<T> node)
        {
            if (node == null) return;
            Console.WriteLine("___" + node.Data);
            Print(node.LeftNode);
            Print(node.RightNode);
        }
        public void Print() { Print(root); }

        public IEnumerator<T> GetEnumerator()
        {
            return Preorder().GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Preorder()
        {
            if (root == null)
                yield break;
            var stack = new Stack<BinaryTreeNode<T>>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                var node = stack.Pop();
                yield return node.Data;
                if (node.RightNode != null)
                    stack.Push(node.RightNode);
                if (node.LeftNode != null)
                    stack.Push(node.LeftNode);
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}