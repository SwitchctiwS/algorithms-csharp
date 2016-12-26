using System;

namespace DataStructures {
    class Node {
        private int data;
        private Node left, right;
        private Node previous, next;

        public int Data {
            get {
                return data;
            } set {
                data = value;
            }
        }
        public Node Left {
            get {
                return left;
            } set {
                left = value;
            }
        }
        public Node Right {
            get {
                return right;
            } set {
                right = value;
            }
        }
        public Node Previous {
            get {
                return previous;
            } set {
                previous = value;
            }
        }
        public Node Next {
            get {
                return next;
            } set {
                next = value;
            }
        }

        public Node(int data) {
            this.data = data;
            left = right = next = previous = null;
        }
    }
}
