using System;

namespace HeapSort {
    class MainClass {
        static void Main(string[] args) {
            int[] arr = new int[] { 5, 7, 1, 0, 9, 4, 5, 5, 0, 3, 5, 7, 54, 3, 8, 9, 24, 6, 23, 45, 76, 12, 76, 13 };

            HeapSort(arr);

            foreach (int num in arr) {
                Console.Write($"{num} ");
            }
        }

        static void HeapSort(int[] arr) {
            BuildMaxHeap(arr);

            int end = arr.Length - 1;
            for (int i = arr.Length - 1; i > 0; i--) {
                Swap(arr, 0, i);

                MaxHeapify(arr, --end, 0);
            }
        }

        static void BuildMaxHeap(int[] arr) {
            for (int i = (arr.Length - 1) / 2; i >= 0; i--) {
                MaxHeapify(arr, arr.Length - 1, i);
            }
        }

        static void MaxHeapify(int[] arr, int end, int parent) {
            int left = 2 * parent + 1;
            int right = 2 * parent + 2;

            if (left <= end && right <= end) {
                if (arr[left] > arr[parent] || arr[right] > arr[parent]) {
                    if (arr[left] > arr[right]) {
                        Swap(arr, parent, left);
                        MaxHeapify(arr, end, left);
                    } else {
                        Swap(arr, parent, right);
                        MaxHeapify(arr, end, right);
                    }
                }
            } else if (left <= end) {
                if (arr[left] > arr[parent]) {
                    Swap(arr, parent, left);
                    MaxHeapify(arr, end, left);
                }
            } else {
                return;
            }
        }

        static void Swap(int[] arr, int a, int b) {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }
    }
}
