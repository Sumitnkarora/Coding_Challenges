using System;
using System.Collections;

namespace BasicBTree
{
    public class BinarySearchTree
    {
        public Node Root;
        static int Count;
        public BinarySearchTree()
        {
            Root = null;
        }
        // Creates and returns a BST node
        public Node AddNode(int data)
        {
            Node temp = new Node(data);
            if (Root == null)
                Root = temp;
            Count++;
            return temp;
        }
        // Procedure inserts 'newNode' in BST at proper position
        public void Insert(Node root, Node newNode)
        {
            while (root != null)
            {
                if (newNode.data > root.data)
                {
                    if (root.right == null)
                    {
                        root.right = newNode;
                        break;
                    }
                    root = root.right;
                }
                else
                {
                    if (root.left == null)
                    {
                        root.left = newNode;
                        break;
                    }
                    root = root.left;
                }
            }
        }
        public void Inorder(Node root)
        {
            if (root != null)
            {
                Inorder(root.left);
                Console.Write(root.data + " ");
                Inorder(root.right);
            }
        }

        public void IterativeInorder(Node root)
        {
            if (root == null)
                return;
            Stack stack = new Stack();
            do
            {
                if (root != null)
                {
                    stack.Push(root);
                    root = root.left;
                }
                else
                {
                    root = (Node)stack.Pop();
                    Console.Write(root.data + " ");
                    root = root.right;
                }
            } while (stack.Count > 0 || root != null);
        }


        // Print a B tree
        public void Print()
        {
            Root.Print();
        }
    }
}
