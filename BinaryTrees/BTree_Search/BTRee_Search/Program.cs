using BasicBTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTRee_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            //Node root = new Node(10);
            BinarySearchTree bst = new BinarySearchTree();
            bst.Insert(bst.Root, bst.AddNode(10));
            bst.Insert(bst.Root, bst.AddNode(5));
            bst.Insert(bst.Root, bst.AddNode(15));
            bst.Insert(bst.Root, bst.AddNode(7));
            bst.Insert(bst.Root, bst.AddNode(12));
            bst.Insert(bst.Root, bst.AddNode(18));
            bst.Insert(bst.Root, bst.AddNode(14));
            bst.Print();
            bst.InsertNewer(bst.Root, new Node(3));
            bst.InsertNewer(bst.Root, new Node(6));
            bst.InsertNewer(bst.Root, new Node(11));

            bst.InsertNewer(bst.Root, new Node(16));
            bst.InsertNewer(bst.Root, new Node(20));


            bst.Print();
            //if(bst.Search(133, bst.Root) != null)
            //{
            //    Console.WriteLine("Found!");
            //}
            //else
            //{
            //    Console.WriteLine("Not Found!");
            //}
            Console.ReadLine();

        }
    }
}
