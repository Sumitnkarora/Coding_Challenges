using System;

namespace BT_All
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
        // Recursive Procedure travels BST tree in Inorder Fashion (left subtree -> root -> right Subtree)
        public void Inorder(Node root)
        {
            if (root != null)
            {
                Inorder(root.left);
                Console.Write(root.data + " ");
                Inorder(root.right);
            }
        }

        public void SumOfAllPaths(Node root, int sum)
        {
            if (root == null)
                return;
            if(root.left == null && root.right == null)
            {
                Console.WriteLine(sum);
            }
            SumOfAllPaths(root.left, root.data + sum);
            SumOfAllPaths(root.right, root.data + sum);
        }

        // Print a B tree
        public void Print()
        {
            Root.Print();
        }
    }
}
