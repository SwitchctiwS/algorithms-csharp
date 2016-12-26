using System;

namespace DataStructures {
    class LinkedList {
        private Node head;

        public LinkedList() {
            this.head = null;
        }

        public void Insert(Node newNode) {
            if (this.head == null) {
                this.head = newNode;
                return;
            }

            Node current = this.head;
            while (current.Next != null) {
                current = current.Next;
            }

            current.Next = newNode;
        }
        public void Traverse() {
            Node current = this.head;
            while (current != null) {
                Console.Write($"{current.Data} ");
                current = current.Next;
            }
            Console.WriteLine();
        }
        public Node Find(int data) {
            Node current = this.head;
            while (current != null) {
                if (current.Data == data) {
                    return current;
                }
                current = current.Next;
            }
            return null;
        }
        public Node Find(Node node) {
            Node current = this.head;
            while (current != null) {
                if (current == node) {
                    return current;
                }
                current = current.Next;
            }
            return null;
        }
        public void Delete(int data) {
            if (this.head.Data == data) {
                this.head = this.head.Next;
            }

            Node current = this.head;
            while (current != null) {
                if (current.Next.Data == data) {
                    current.Next = current.Next.Next;
                    return;
                }
                current = current.Next;
            }
        }
        public void Delete(Node node) {
            if (this.head == node) {
                this.head = this.head.Next;
            }

            Node current = this.head;
            while (current != null) {
                if (current.Next == node) {
                    current.Next = current.Next.Next;
                    return;
                }
                current = current.Next;
            }
        }
    }
}
