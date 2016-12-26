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
        /// Sorts array using a recursive Bubble sort.
        /// </summary>
        /// <param name="array">Name of array.</param>
        /// <param name="indexB">Index of last element in array.</param>
        static void BubbleSort(int[] array, int iEnd) {
            bool swapped = false;

            // Swaps if current element is greater than next element
            for (int i = 0; i < iEnd; i++) {
                if (array[i] > array[i + 1]) {
                    Swap(array, i, i + 1);
                    swapped = true;
                }
            }

            // When no swaps have taken place, then array is sorted
            if (!swapped) {
                return;
            }

            BubbleSort(array, iEnd - 1);
        }

        /// <summary>
        /// Swaps array at index A and index B.
        /// </summary>
        /// <param name="array">Name of array.</param>
        /// <param name="indexA">Index A.</param>
        /// <param name="indexB">Index B.</param>
        static void Swap(int[] array, int indexA, int indexB) {
            int temp = array[indexA];
            array[indexA] = array[indexB];
            array[indexB] = temp;
        }
    }
}
