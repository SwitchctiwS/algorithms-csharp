using System;

namespace Search {
    class BinarySearch {
        public BinarySearch() {}

        /// <summary>
        /// Uses binary search algorithm to search through an array.
        /// </summary>
        /// <returns>Index of the key. -1 (error) if the key is not found.</returns>
        /// <param name="array">Array to search.</param>
        /// <param name="key">Key in array.</param>
        /// <param name="min">Minimum index.</param>
        /// <param name="max">Maximum index.</param>
        public int Search(int[] array, int key, int min, int max) {
            if (min > max) {
                    return -1;
            }

            int middle = (min + max) / 2;

            if (key < array[middle]) {
                return Binary(array, key, min, middle - 1);
            } else if (key > array[middle]) {
                return Binary(array, key, middle + 1, max);
            } else {
                return middle;
            }
        }
    }
}
