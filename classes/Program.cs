using System;
using Algorithms;

namespace Main {
    class Program {
        static void Main(string[] args) {
            Sort sort = new Sort();
            Search search = new Search();

            int[] arr = RandomArray(101);
            Console.WriteLine("Before:");
            WriteArray(arr);
            Console.WriteLine();

            sort.Shell(arr); // Sorting algorithm
            Console.WriteLine("After:");
            WriteArray(arr);
            Console.WriteLine();


            int key = 10;
            int index = search.Binary(arr, key, 0, arr.Length - 1); // Search algorithm
            Console.WriteLine($"Key {key} found at index {index}");

        }

        static int[] RandomArray() {
            int[] arr = new int[100];
            for (int i = 0; i < arr.Length; i++) {
                arr[i] = i;
            }

            Random rand = new Random();
            for (int j = arr.Length - 1; j >= 0; j--) {
                int k = rand.Next(j + 1);

                int temp = arr[k];
                arr[k] = arr[j];
                arr[j] = temp;
            }

            return arr;
        }

        static int[] RandomArray(int n) {
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++) {
                arr[i] = i;
            }

            Random rand = new Random();
            for (int j = arr.Length - 1; j >= 0; j--) {
                int k = rand.Next(j + 1);

                int temp = arr[k];
                arr[k] = arr[j];
                arr[j] = temp;
            }

            return arr;
        }

        static int[] RandomArray(int n, int seed) {
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++) {
                arr[i] = i;
            }

            Random rand = new Random(seed);
            for (int j = arr.Length - 1; j >= 0; j--) {
                int k = rand.Next(j + 1);

                int temp = arr[k];
                arr[k] = arr[j];
                arr[j] = temp;
            }

            return arr;
        }

        static void WriteArray(int[] arr) {
            foreach (int i in arr) {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
