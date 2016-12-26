using System;

namespace MergeSort {
    class MainClass {
        static void Main(string[] args) {
            int[] array = new int[] { 5, 7, 1, 0, 9, 4, 5, 5, 0, 3, 5, 7, 54, 3, 8, 9, 24, 6, 23, 45, 76, 12, 76, 13 };

            MergeSort(testArray, 0, testArray.Length - 1);

            foreach (int num in array) {
                Console.Write(num);
                Console.Write(" ");
            }
        }

        /// <summary>
        /// Sorts array using merge sort algorithm.
        /// </summary>
        /// <param name="array">Name of array.</param>
        /// <param name="iStart">Starting index.</param>
        /// <param name="iEnd">Ending index.</param>
        static void MergeSort(int[] array, int iStart, int iEnd) {
            // While array size is greater than 1
            if (iStart < iEnd) {
                int iMiddle = (iStart + iEnd) / 2;

                // Recursively split array into two halves
                MergeSort(array, iStart, iMiddle);
                MergeSort(array, iMiddle + 1, iEnd);

                Merge(array, iStart, iMiddle, iEnd);
            }
        }

        /// <summary>
        /// Sorts then merges array.
        /// </summary>
        /// <param name="array">Name of array.</param>
        /// <param name="iStart">Starting index.</param>
        /// <param name="iMiddle">Middle index.</param>
        /// <param name="iEnd">Ending index.</param>
        static void Merge(int[] array, int iStart, int iMiddle, int iEnd) {
            // Two arrays that will contain the left and right halves of the base array
            int[] left = new int[iMiddle - iStart + 1];
            int[] right = new int[iEnd - iMiddle];

            // Go through first (left) half of base array
            for (int i = 0; i < left.Length; i++) {
                left[i] = array[iStart + i];
            }

            // Go through second (right) half of base array
            for (int i = 0; i < right.Length; i++) {
                right[i] = array[iMiddle + 1 + i];
            }

            int j = iStart;     // array
            int k = 0;          // left
            int h = 0;          // right

            // Compares each element in the arrays, puts lower value into base array
            while (k < left.Length && h < right.Length) {
                if (left[k] < right[h]) {
                    array[j] = left[k++];
                } else {
                    array[j] = right[h++];
                } j++;
            }

            // Since above code leaves some leftover elements, these two while loops
            // put the rest of the elements into the base array
            while (k < left.Length) {
                array[j++] = left[k++];
            }

            while (h < right.Length) {
                array[j++] = right[h++];
            }
        }
    }
}
