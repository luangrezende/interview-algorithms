using interview_algorithms.sorting.core;
using System.Diagnostics;

namespace interview_algorithms.sorting
{
    public class SelectionSort
    {
        public static void Run()
        {
            Console.WriteLine("Starting Selection Sort...");
            int[] array = Builders.GenerateRandomArray();

            Stopwatch stopwatch = new();
            stopwatch.Start();

            PerformSelectionSort(array);

            stopwatch.Stop();

            Console.WriteLine($"Execution Time: {stopwatch.Elapsed.TotalMilliseconds} milliseconds");
        }

        static void PerformSelectionSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in remaining unsorted array
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Swap the found minimum element with the first element
                if (minIndex != i)
                {
                    int temp = arr[minIndex];
                    arr[minIndex] = arr[i];
                    arr[i] = temp;
                }
            }
        }
    }
}
