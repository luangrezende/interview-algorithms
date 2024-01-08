using interview_algorithms.sorting.core;
using System.Diagnostics;

namespace interview_algorithms.sorting
{
    public class QuickSort
    {
        public static void Run()
        {
            Console.WriteLine("Stating QuickSort...");
            int[] array = Builders.GenerateRandomArray();

            Stopwatch stopwatch = new();
            stopwatch.Start();

            PerformQuickSort(array, 0, array.Length - 1);

            stopwatch.Stop();

            Console.WriteLine($"\nExecution Time: {stopwatch.Elapsed.TotalMilliseconds} milliseconds");
        }

        static void PerformQuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int partitionIndex = Partition(arr, low, high);

                PerformQuickSort(arr, low, partitionIndex - 1);
                PerformQuickSort(arr, partitionIndex + 1, high);
            }
        }

        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;

                    // Swap arr[i] and arr[j]
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // Swap arr[i + 1] and arr[high] (pivot)
            int tempPivot = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = tempPivot;

            return i + 1;
        }
    }
}
