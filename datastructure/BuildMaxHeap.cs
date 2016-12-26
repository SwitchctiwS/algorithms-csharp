using System;

namespace DataStructures {
    class BuildMaxHeap {
        public BuildMaxHeap() {}

        public void Build(int[] arr) {
            for (int i = (arr.Length - 1) / 2; i >= 0; i--) {
                MaxHeapify(arr, arr.Length - 1, i);
            }
        }

        private void MaxHeapify(int[] arr, int end, int parent) {
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

        private void Swap(int[] arr, int a, int b) {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }
    }
}
