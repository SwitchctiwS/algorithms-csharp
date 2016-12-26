using System;
using Search;
using DataStructures;

namespace Program {
    class MainClass {
        static void Main(string[] args) {
            Node node1 = new Node(0);
            Node node2 = new Node(4);
            Node node3 = new Node(7);
            Node node4 = new Node(5);
            Node node5 = new Node(3);
            Node node6 = new Node(1);

            node1.Left = node2;
            node1.Right = node3;
            node2.Left = node4;
            node2.Right = node5;
            node3.Left = node6;

            BreadthFirstSearch bfs = new BreadthFirstSearch();
            bfs.Search(node1, 10);
        }
    }
}
