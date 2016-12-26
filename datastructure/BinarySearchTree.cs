using System;

namespace DataStructures {
    class BinarySearchTree {
        Node root;

        public BinarySearchTree() {
            this.root = null;
        }

        public Node Root {
            get {
                return this.root;
            }
        }
        public int TreeHeight {
            get {
                return GetTreeHeight(root);
            }
        }
        private int GetTreeHeight(Node node) {
            if (node == null) {
                return -1;
            }

            int leftHeight = GetTreeHeight(node.Left) + 1;
            int rightHeight = GetTreeHeight(node.Right) + 1;

            return (leftHeight > rightHeight) ? leftHeight : rightHeight;
        }
        public Node Search(int data) {
            Node current = this.root;

            while (current != null) {
                if (data < current.Data) {
                    current = current.Left;
                } else if (data > current.Data) {
                    current = current.Right;
                } else {
                    return current;
                }
            }

            return null;
        }
        public void Insert(Node node) {
            if (this.root == null) {
                this.root = node;
            }

            Node current = this.root;
            while (true) {
                if (node.Data == current.Data) {
                    return; // Prevents dupilcates
                }

                if (node.Data < current.Data) {
                    if (current.Left == null) {
                        current.Left = node;
                        return;
                    } else {
                        current = current.Left;
                    }
                } else {
                    if (current.Right == null) {
                        current.Right = node;
                        return;
                    } else {
                        current = current.Right;
                    }
                }
            }
        }
        public void Delete(Node node) {
            
        }
        public void Traverse(Node node) {
            if (node == null) {
                return;
            }

            Console.Write($"{node.Data} ");

            Traverse(node.Left);
            Traverse(node.Right);
        }
    }
}
