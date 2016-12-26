using System;
using System.Collections;
using DataStructures;

namespace Search {
    class BreadthFirstSearch {
        public BreadthFirstSearch() {}

        public Node Search (Node root, int data) {
            Node current = root;
            Queue queue = new Queue();

            queue.Enqueue(root);

            while (queue.Count != 0) {
                current = (Node)queue.Dequeue();

                if (current.Data == data) {
                    return current;
                }

                if (current.Left != null) {
                    queue.Enqueue(current.Left);
                }

                if (current.Right != null) {
                    queue.Enqueue(current.Right);
                }
            }

            return null;
        }
    }
}
