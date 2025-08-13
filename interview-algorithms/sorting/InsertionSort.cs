using interview_algorithms.sorting.core;
using System.Diagnostics;

namespace interview_algorithms.sorting
{
    public class InsertionSort
    {
        public static void Run()
        {
            Console.WriteLine("Starting Insertion Sort...");
            int[] array = Builders.GenerateRandomArray();

            Stopwatch stopwatch = new();
            stopwatch.Start();

            PerformInsertionSort(array);

            stopwatch.Stop();

            Console.WriteLine($"Execution Time: {stopwatch.Elapsed.TotalMilliseconds} milliseconds");
        }

        static void PerformInsertionSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;

                // Move elements of arr[0..i-1], that are greater than key,
                // to one position ahead of their current position
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }
    }
}
