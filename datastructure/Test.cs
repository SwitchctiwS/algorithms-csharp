using System;

namespace DataStructures {
    class Test {
        static void Main(string[] args) {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Insert(new Node(4));
            bst.Insert(new Node(9));
            bst.Insert(new Node(6));
            bst.Insert(new Node(2));
            bst.Insert(new Node(3));
            bst.Insert(new Node(8));
            bst.Insert(new Node(5));
            bst.Insert(new Node(7));
            bst.Insert(new Node(2));
            bst.Traverse(bst.Root);
            Console.WriteLine();
            Console.WriteLine(bst.TreeHeight);
            Console.WriteLine(bst.Search(2).Data);

        }

        static void Display(int[] arr) {
            foreach (int i in arr) {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
