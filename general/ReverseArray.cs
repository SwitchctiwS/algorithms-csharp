using System;

namespace ReverseArray {
    class MainClass {
        static void Main(string[] args) {
            int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            ReverseArray(array);

            foreach (int number in array) {
                Console.Write(number);
                Console.Write(" ");
            }
        }

        /// <summary>
        /// Reverses an array (sorted or unsorted) using iteration.
        /// </summary>
        /// <param name="array">Name of array.</param>
        static void ReverseArray(int[] array) {
            // Handles both odd and even number of array elements
            int i = 0;
            int j = array.Length - 1;

            while (i < j) {
                Swap(array, i++, j--);
            }
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
