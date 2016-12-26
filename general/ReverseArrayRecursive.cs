using System;

namespace ReverseArray {
    class MainClass {
        static void Main(string[] args) {
            int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            ReverseArray(array, 0, array.Length - 1);

            foreach (int number in array) {
                Console.Write(number);
                Console.Write(" ");
            }
        }

        /// <summary>
        /// Reverses an array (sorted or unsorted) using recursion.
        /// </summary>
        /// <param name="array">Name of array.</param>
        /// <param name="iStart">Index of first element in array.</param>
        /// <param name="indexB">Index of last element in array.</param>
        static void ReverseArray(int[] array, int iStart, int iEnd) {
            // Handles both odd and even number of array elements
            if (iStart < iEnd) {
                Swap(array, iStart, iEnd);                      // Swaps first and last element then
                ReverseArray(array, iStart + 1, iEnd - 1);      // goes to next first and last element
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
