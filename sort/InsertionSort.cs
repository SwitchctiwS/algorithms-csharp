using System;

namespace InsertionSort {
    class MainClass {
        public static void Main(string[] args) {
            int[] array = new int[] { 5, 7, 1, 0, 9, 4, 5, 5, 0, 3, 5, 7, 54, 3, 8, 9, 24, 6, 23, 45, 76, 12, 76, 13 };

            InsertionSort(array);

            foreach (int num in array) {
                Console.Write(num);
                Console.Write(" ");
            }
        }

        /// <summary>
        /// Sorts array with Insertion Sort
        /// </summary>
        /// <param name="array">Name of array.</param>
        public static void InsertionSort(int[] array) {
            for (int i = 0; i < array.Length - 1; i++) {
                Insert(array, i + 1);
            }
        }

        /// <summary>
        /// Inserts key into array.
        /// </summary>
        /// <param name="array">Name of array.</param>
        /// <param name="keyIndex">Index of key.</param>
        public static void Insert(int[] array, int keyIndex) {
            for (int i = 0; i < keyIndex; i++) {
                // If key is less than current element, replace element with key
                if (array[keyIndex] < array[i]) {
                    int key = array[keyIndex];

                    // Inserts key by moving all elements one to right
                    for (int j = keyIndex; j > i; j--) {
                        array[j] = array[j - 1];
                    }

                    array[i] = key;
                }
            }
        }
    }
}
