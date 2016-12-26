using System;

namespace ShellSort {
    class MainClass {
        static void Main(string[] args) {
            int[] array = new int[] { 5, 7, 1, 0, 9, 4, 5, 5, 0, 3, 5, 7, 54, 3, 8, 9, 24, 6, 23, 45, 76, 12, 76, 13 };

            ShellSort(array);

            foreach (int num in array) {
                Console.Write(num);
                Console.Write(" ");
            }
        }

        static void ShellSort(int[] array) {
            int[] gaps = new int[] { 701, 301, 132, 57, 23, 4, 1};
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
