using System;
using System.Collections.Generic;

namespace ListMergeSort {
    class MainClass {
        static void Main(string[] args) {
            int[] array = new int[] { 5, 7, 1, 0, 9, 4, 5, 5, 0, 3, 5, 7, 54, 3, 8, 9, 24, 6, 23, 45, 76, 12, 76, 13 };

            MergeSort(array, 0, array.Length - 1);

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
            // while array size is greater than 1
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
            // Two lists that will contain the left and right halves of the base array
            List<int> left = new List<int>();
            List<int> right = new List<int>();

            // Go through first (left) half of base array
            for (int i = iStart; i <= iMiddle; i++) {
                left.Add(array[i]);
            }

            // Go through second (right) half of base array
            for (int i = iMiddle + 1; i <= iEnd; i++) {
                right.Add(array[i]);
            }

            int c = iStart;     // array
            int d = 0;          // left
            int e = 0;          // right

            // Compares each element in the lists, puts lower value into base array
            while (d < left.Count && e < right.Count) {
                if (left[d] < right[e]) {
                    array[c] = left[d++];
                } else {
                    array[c] = right[e++];
                } c++;
            }

            // Since above code leaves some leftover elements, these two while loops
            // put the rest of the elements in the base array
            while (d < left.Count) {
                array[c++] = left[d++];
            }

            while (e < right.Count) {
                array[c++] = right[e++];
            }
        }
    }
}
