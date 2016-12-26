using System;

namespace BubbleSort {
    class MainClass {
        static void Main(string[] args) {
            int[] arr = new int[100];
            for (int i = 0; i < arr.Length; i++) {
                arr[i] = i;
            }

            Random rand = new Random(1337);

            for (int j = arr.Length - 1; j >= 0; j--) {
                int k = rand.Next(j + 1);

                int temp = arr[k];
                arr[k] = arr[j];
                arr[j] = temp;
            }

            BubbleSort(arr);

            foreach (int num in arr) {
                Console.Write($"{num} ");
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Sorts array using an iterative Bubble sort.
        /// </summary>
        /// <param name="arr">Name of array.</param>
        static void BubbleSort(int[] arr) {
            bool swapped;

            // Swaps if current element is greater than next element
            for (int i = arr.Length - 1; i > 0; i--) {
                swapped = false;

                for (int j = 0; j < i; j++) {
                    if (arr[j] > arr[j + 1]) {
                        Swap(arr, j, j + 1);
                        swapped = true;
                    }
                }

                // When no swaps have taken place, then array is sorted
                if (swapped == false) {
                    return;
                }
            }
        }

        /// <summary>
        /// Swaps array at index A and index B.
        /// </summary>
        /// <param name="arr">Name of array.</param>
        /// <param name="A">Index A.</param>
        /// <param name="B">Index B.</param>
        static void Swap(int[] arr, int A, int B) {
            int temp = arr[A];
            arr[A] = arr[B];
            arr[B] = temp;
        }
    }
}
