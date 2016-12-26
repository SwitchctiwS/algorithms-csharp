using System;

namespace Algorithms {
    class Sort {
        public Sort() {}

        private void ActualMerge(int[] array, int iStart, int iEnd) {
            // While array size is greater than 1
            if (iStart < iEnd) {
                int iMiddle = (iStart + iEnd) / 2;

                // Recursively split array into two halves
                ActualMerge(array, iStart, iMiddle);
                ActualMerge(array, iMiddle + 1, iEnd);

                SplitAndMerge(array, iStart, iMiddle, iEnd);
            }
        }

        private void ActualQuick(int[] array, int left, int right) {
            if (left < right) {
                int pivot = Partition(array, left, right);
                ActualQuick(array, left, pivot - 1);
                ActualQuick(array, pivot + 1, right);
            }
        }

        private void MaxHeapify(int[] arr, int end, int parent) {
            int left = 2 * parent + 1;
            int right = 2 * parent + 2;

            if (left <= end && right <= end) {
                if (arr[left] > arr[parent] || arr[right] > arr[parent]) {
                    if (arr[left] > arr[right]) {
                        Swap(arr, parent, left);
                        MaxHeapify(arr, end, left);
                    } else {
                        Swap(arr, parent, right);
                        MaxHeapify(arr, end, right);
                    }
                }
            } else if (left <= end) {
                if (arr[left] > arr[parent]) {
                    Swap(arr, parent, left);
                    MaxHeapify(arr, end, left);
                }
            } else {
                return;
            }
        }

        /// <summary>
        /// Partition the specified array into left part and right part.
        /// </summary>
        /// <param name="array">Array.</param>
        /// <param name="left">Left partition.</param>
        /// <param name="right">Right partition.</param>
        private int Partition(int[] array, int left, int right) {
            int pivot = array[right];     // Sets pivot to right-most element in array
            int lessThanPivot = left;

            for (int greaterThanPivot = left; greaterThanPivot < right; greaterThanPivot++) {
                if (array[greaterThanPivot] <= pivot) {
                        Swap(array, lessThanPivot, greaterThanPivot);
                        lessThanPivot++;
                }
            }

            Swap(array, lessThanPivot, right);

            return lessThanPivot;
        }

        /// <summary>
        /// Sorts then merges array.
        /// </summary>
        /// <param name="array">Name of array.</param>
        /// <param name="iStart">Starting index.</param>
        /// <param name="iMiddle">Middle index.</param>
        /// <param name="iEnd">Ending index.</param>
        private void SplitAndMerge(int[] array, int iStart, int iMiddle, int iEnd) {
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

        /// <summary>
        /// Swaps array at index A and index B.
        /// </summary>
        /// <param name="arr">Name of array.</param>
        /// <param name="A">Index A.</param>
        /// <param name="B">Index B.</param>
        private void Swap(int[] arr, int A, int B) {
            int temp = arr[A];
            arr[A] = arr[B];
            arr[B] = temp;
        }
/*-----------------------------------------------------------------------------------*/
        // Sort methods

        /// <summary>
        /// Sorts array using an iterative Bubble sort.
        /// </summary>
        /// <param name="arr">Name of array.</param>
        public void Bubble(int[] arr) {
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

        public void Cocktail(int[] array) {
            bool swapped = false;
            int iEnd = array.Length - 1;
            int iStart = 0;

            do {
                for (int i = iStart; i < iEnd; i++) {
                    if (array[i + 1] < array[i]) {
                        Swap(array, i, i + 1);
                        swapped = true;
                    }
                } iEnd--;

                if (!swapped) {
                    return;
                }

                swapped = false;

                for (int i = iEnd; i > iStart; i--) {
                    if (array[i - 1] > array[i]) {
                        Swap(array, i, i - 1);
                        swapped = true;
                    }
                } iStart++;

            } while (swapped);
        }

        public void Comb(int[] array) {
            int gap = array.Length;
            float shrink = 1.3f;
            bool sorted = false;
            int i;

            while (gap > 1 || sorted == false) {
                gap = (int)(gap / shrink);

                if (gap < 1) {
                    gap = 1;
                }

                i = 0;

                if (gap == 1) {
                    sorted = true;
                }

                while (i + gap < array.Length) {
                    if (array[i] > array[i + gap]) {
                        Swap(array, i, i + gap);

                        if (gap == 1) {
                            sorted = false;
                        }
                    } i++;
                }
            }
        }

        public void Heap(int[] arr) {
            for (int i = (arr.Length - 1) / 2; i >= 0; i--) {
                MaxHeapify(arr, arr.Length - 1, i);
            }

            int end = arr.Length - 1;
            for (int i = arr.Length - 1; i > 0; i--) {
                Swap(arr, 0, i);

                MaxHeapify(arr, --end, 0);
            }
        }

        public void Insertion(int[] array) {
            for (int i = 0; i < array.Length - 1; i++) {
                for (int j = 0; j < i + 1; j++) {
                    // If key is less than current element, replace element with key
                    if (array[i + 1] < array[j]) {
                        int key = array[i + 1];

                        // Inserts key by moving all elements one to right
                        for (int k = i + 1; k > j; k--) {
                            array[k] = array[k - 1];
                        }

                        array[j] = key;
                    }
                }
            }
        }

        /// <summary>
        /// Sorts array using merge sort algorithm.
        /// </summary>
        /// <param name="array">Name of array.</param>
        /// <param name="iStart">Starting index.</param>
        /// <param name="iEnd">Ending index.</param>
        public void Merge(int[] array) {
            ActualMerge(array, 0, array.Length - 1);
        }

        /// <summary>
        /// Quicksort the specified array.
        /// </summary>
        /// <param name="array">Array.</param>
        /// <param name="left">Left partition.</param>
        /// <param name="right">Right partition.</param>
        public void Quick(int[] array) {
            ActualQuick(array, 0, array.Length - 1);
        }

        /// <summary>
        /// Sorts elements in an array using Selection Sort.
        /// </summary>
        /// <param name="array">Name of array.</param>
        public void Selection(int[] array) {
            for (int i = 0; i < array.Length; i++) {
                int minValue = array[i];
                int minIndex = i;

                // Does not swap equal elements.
                // If current element is less than previous, make current element minValue.
                for (int j = i + 1; j < array.Length; j++) {
                    if (array[j] < minValue) {
                        minValue = array[j];
                        minIndex = j;
                    }
                }
                Swap(array, i, minIndex);
            }
        }

        public void Shell(int[] array) {
            int[] gaps = new int[] { 701, 301, 132, 57, 23, 4, 1 };
            int temp;
            int j, i;

            foreach (int gap in gaps) {
                for (i = gap; i < array.Length; i++) {
                    temp = array[i];

                    for (j = i; j >= gap && array[j - gap] > temp; j -= gap) {
                        array[j] = array[j - gap];
                    }

                    array[j] = temp;
                }
            }
        }
    }
}
