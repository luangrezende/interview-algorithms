using interview_algorithms.sorting.core;
using System.Diagnostics;

namespace interview_algorithms.sorting
{
    public class MergeSort
    {
        public static void Run()
        {
            Console.WriteLine("Stating MergeSort...");
            int[] array = Builders.GenerateRandomArray();

            Stopwatch stopwatch = new();
            stopwatch.Start();

            PerformMergeSort(array, 0, array.Length - 1);

            stopwatch.Stop();

            Console.WriteLine($"\nExecution Time: {stopwatch.Elapsed.TotalMilliseconds} milliseconds");
        }

        static void PerformMergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                PerformMergeSort(arr, left, middle);
                PerformMergeSort(arr, middle + 1, right);

                Merge(arr, left, middle, right);
            }
        }

        static void Merge(int[] arr, int left, int middle, int right)
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;

            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            Array.Copy(arr, left, leftArray, 0, n1);
            Array.Copy(arr, middle + 1, rightArray, 0, n2);

            int i = 0, j = 0, k = left;

            while (i < n1 && j < n2)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    arr[k] = leftArray[i];
                    i++;
                }
                else
                {
                    arr[k] = rightArray[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                arr[k] = leftArray[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                arr[k] = rightArray[j];
                j++;
                k++;
            }
        }
    }
}
