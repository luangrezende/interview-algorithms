using interview_algorithms.sorting.core;
using System.Diagnostics;

namespace interview_algorithms.searching
{
    public class LinearSearch
    {
        public static void Run()
        {
            Console.WriteLine("Starting Linear Search...");
            int[] array = Builders.GenerateRandomArray();
            int target = array[array.Length / 2]; // Pick middle element as target
            
            Stopwatch stopwatch = new();
            stopwatch.Start();
            
            int result = PerformLinearSearch(array, target);
            
            stopwatch.Stop();
            
            Console.WriteLine($"Target {target} found at index: {result}");
            Console.WriteLine($"Execution Time: {stopwatch.Elapsed.TotalMilliseconds} milliseconds");
        }
        
        public static int PerformLinearSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                    return i;
            }
            return -1; // Target not found
        }
        
        // Generic version
        public static int PerformLinearSearch<T>(T[] arr, T target) where T : IEquatable<T>
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals(target))
                    return i;
            }
            return -1; // Target not found
        }
    }
}
