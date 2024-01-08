using interview_algorithms.sorting.core;
using System.Diagnostics;

namespace interview_algorithms.sorting
{
    public class BubbleSort
    {
        public static void Run()
        {
            Console.WriteLine("Stating BubbleSort...");
            int[] array = Builders.GenerateRandomArray();

            Stopwatch stopwatch = new();
            stopwatch.Start();

            PerformBubbleSort(array);

            stopwatch.Stop();

            Console.WriteLine($"\nExecution Time: {stopwatch.Elapsed.TotalMilliseconds} milliseconds");
        }

        static void PerformBubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap arr[j] and arr[j + 1]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }
}
