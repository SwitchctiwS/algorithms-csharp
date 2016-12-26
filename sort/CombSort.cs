using System;

namespace CombSort {
    class MainClass {
        static void Main(string[] args) {
            int[] array = new int[] { 5, 7, 1, 0, 9, 4, 5, 5, 0, 3, 5, 7, 54, 3, 8, 9, 24, 6, 23, 45, 76, 12, 76, 13 };

            CombSort(array);

            foreach (int num in array) {
                Console.Write(num);
                Console.Write(' ');
            }
        }

        static void CombSort(int[] array) {
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
                    }

                    i++;
                }
            }
        }

        static void Swap(int[] array, int A, int B) {
            int temp = array[A];
            array[A] = array[B];
            array[B] = temp;
        }
    }
}
