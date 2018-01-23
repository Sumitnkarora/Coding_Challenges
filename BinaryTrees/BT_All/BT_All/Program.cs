using System;

namespace BT_All
{
    public class Program
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
            bst.Insert(bst.Root, bst.AddNode(30));
            bst.Insert(bst.Root, bst.AddNode(48));
            bst.Insert(bst.Root, bst.AddNode(70));
            bst.Insert(bst.Root, bst.AddNode(58));
            bst.Insert(bst.Root, bst.AddNode(55));
            bst.Insert(bst.Root, bst.AddNode(65));
            bst.Insert(bst.Root, bst.AddNode(75));
            // Traversing BST in Inorder fashion
            //bst.Inorder(bst.Root);
            bst.Print();
            bst.SumOfAllPaths(bst.Root,0);
            Console.ReadKey();
        }
    }
}
