using BasicBTree;
using System;

namespace Iterative_Inorder_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree bst = new BinarySearchTree();
            // Inserting Nodes to Binary search Tree
            bst.Insert(bst.Root, bst.AddNode(50));
            bst.Insert(bst.Root, bst.AddNode(40));
            bst.Insert(bst.Root, bst.AddNode(60));
            bst.Insert(bst.Root, bst.AddNode(35));
            bst.Insert(bst.Root, bst.AddNode(45));
            bst.Insert(bst.Root, bst.AddNode(42));
            bst.Insert(bst.Root, bst.AddNode(30));
            bst.Insert(bst.Root, bst.AddNode(70));
            bst.Insert(bst.Root, bst.AddNode(58));
            bst.Insert(bst.Root, bst.AddNode(59));
            bst.Insert(bst.Root, bst.AddNode(65));
            bst.Insert(bst.Root, bst.AddNode(75));
            //Traversing BST in Inorder fashion


            bst.Print();
            bst.Inorder(bst.Root);
            Console.WriteLine();
            bst.IterativeInorder(bst.Root);
            Console.ReadKey();
        }
    }
}
