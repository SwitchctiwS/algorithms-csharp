using System;
using System.Collections;
using DataStructures;

namespace Search {
    class DepthFirstSearch {
        public DepthFirstSearch() {}

        public Node Search(Node root, Node node) {
            Node current = root;
            Stack stack = new Stack();

            stack.Push(current);

            while (stack.Count != 0) {
                current = (Node)stack.Pop();

                if (current == node) {
                    return current;
                }

                if (current.Right != null) {
                    stack.Push(current.Right);
                }

                if (current.Left != null) {
                    stack.Push(current.Left);
                }
            }

            return null;
        }

        public Node Search(Node root, int data) {
            Node current = root;
            Stack stack = new Stack();

            stack.Push(current);

            while (stack.Count != 0) {
                current = (Node)stack.Pop();

                Console.WriteLine(current.Data);

                if (current.Data == data) {
                    return current;
                }

                if (current.Right != null) {
                    stack.Push(current.Right);
                }

                if (current.Left != null) {
                    stack.Push(current.Left);
                }
            }

            return null;
        }
    }
}
