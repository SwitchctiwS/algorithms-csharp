using System;

namespace QuickSort {
    class MainClass {
        public static void Main (string[] args) {
            int[] array = new int[] { 5, 7, 1, 0, 9, 4, 5, 5, 0, 3, 5, 7, 54, 3, 8, 9, 24, 6, 23, 45, 76, 12, 76, 13 };

            // Which indices the array starts/stops at
            int startIndex = 0;                 // i.e. First element
            int endIndex = array.Length - 1;    // i.e. Last element

            // Quicksort array
            Quicksort(array, startIndex, endIndex);

            // Display sorted array
            foreach (int num in array) {
                    Console.Write(num);
                    Console.Write(" ");
            }
        }

        /// <summary>
        /// Quicksort the specified array.
        /// </summary>
        /// <param name="array">Array.</param>
        /// <param name="left">Left partition.</param>
        /// <param name="right">Right partition.</param>
        static void Quicksort(int[] array, int left, int right) {
            if (left < right) {
                int pivot = Partition(array, left, right);
                Quicksort(array, left, pivot - 1);
                Quicksort(array, pivot + 1, right);
            }
        }

        /// <summary>
        /// Partition the specified array into left part and right part.
        /// </summary>
        /// <param name="array">Array.</param>
        /// <param name="left">Left partition.</param>
        /// <param name="right">Right partition.</param>
        static int Partition(int[] array, int left, int right)         // The real "meat" of the algorithm
        {
            int pivot = array[right];     // Sets pivot to right-most element in array
            int lessThanPivot = left;

            for (int greaterThanPivot = left; greaterThanPivot < right; greaterThanPivot++) {
                if (array[greaterThanPivot] <= pivot) {
                        Swap(array, lessThanPivot, array[lessThanPivot], greaterThanPivot, array[greaterThanPivot]);
                        lessThanPivot++;
                }
            }

            Swap(array, lessThanPivot, array[lessThanPivot], right, array[right]);

            return lessThanPivot;
        }

        /// <summary>
        /// Swap values in specified array.
        /// </summary>
        /// <param name="array">Array.</param>
        /// <param name="indexA">Index1.</param>
        /// <param name="a">Value1.</param>
        /// <param name="indexB">Index2.</param>
        /// <param name="b">Value2.</param>
        static void Swap(int[] array, int indexA, int a, int indexB, int b) {
            array[indexA] = b;
            array[indexB] = a;
        }
    }
}
