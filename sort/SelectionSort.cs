using System;

namespace SelectionSort {
    class MainClass {
        public static void Main(string[] args) {
            int[] array = new int[] { 5, 7, 1, 0, 9, 4, 5, 5, 0, 3, 5, 7, 54, 3, 8, 9, 24, 6, 23, 45, 76, 12, 76, 13 };

            SelectionSort(array);

            foreach (int number in array) {
                Console.Write(number);
                Console.Write(" ");
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Sorts elements in an array using Selection Sort.
        /// </summary>
        /// <param name="array">Name of array.</param>
        public static void SelectionSort(int[] array) {
            for (int i = 0; i < array.Length; i++) {
                Swap(array, i, MinIndex(array, i));
            }
        }

        /// <summary>
        /// Finds index of the minimum value in an array.
        /// </summary>
        /// <returns>The index of the smallest value.</returns>
        /// <param name="array">Name of array.</param>
        /// <param name="startIndex">Starting index.</param>
        public static int MinIndex(int[] array, int startIndex) {
            int minValue = array[startIndex];
            int minIndex = startIndex;

            // Does not swap equal elements.
            // If current element is less than previous, make current element minValue.
            for (int i = startIndex + 1; i < array.Length; i++) {
                if (array[i] < minValue) {
                    minValue = array[i];
                    minIndex = i;
                }
            }

            return minIndex;
        }

        /// <summary>
        /// Swap the specified array, at indicies a and b.
        /// </summary>
        /// <param name="array">Name of array.</param>
        /// <param name="a">Index a.</param>
        /// <param name="b">Index B.</param>
        public static void Swap(int[] array, int a, int b) {
            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }
    }
}
