using System;

namespace CocktailShakerSort {
    class MainClass {
        static void Main(string[] args) {
            int[] array = new int[] { 5, 7, 1, 0, 9, 4, 5, 5, 0, 3, 5, 7, 54, 3, 8, 9, 24, 6, 23, 45, 76, 12, 76, 13 };

            CocktailShakerSort(array);

            foreach (int num in array) {
                Console.Write(num);
                Console.Write(" ");
            }
        }

        static void CocktailShakerSort(int[] array) {
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

        static void Swap(int[] array, int A, int B) {
            int temp = array[A];
            array[A] = array[B];
            array[B] = temp;
        }
    }
}
