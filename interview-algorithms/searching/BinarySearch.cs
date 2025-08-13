using interview_algorithms.sorting.core;
using System.Diagnostics;

namespace interview_algorithms.searching
{
    public class BinarySearch
    {
        public static void Run()
        {
            Console.WriteLine("Starting Binary Search...");
            int[] array = Builders.GenerateRandomArray();
            Array.Sort(array); // Binary search requires sorted array
            
            int target = array[array.Length / 2]; // Pick middle element as target
            
            Stopwatch stopwatch = new();
            stopwatch.Start();
            
            int result = PerformBinarySearch(array, target);
            
            stopwatch.Stop();
            
            Console.WriteLine($"Target {target} found at index: {result}");
            Console.WriteLine($"Execution Time: {stopwatch.Elapsed.TotalMilliseconds} milliseconds");
        }
        
        public static int PerformBinarySearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;
            
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                
                if (arr[mid] == target)
                    return mid;
                    
                if (arr[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            
            return -1; // Target not found
        }
        
        // Recursive implementation
        public static int PerformBinarySearchRecursive(int[] arr, int target, int left, int right)
        {
            if (left > right)
                return -1;
                
            int mid = left + (right - left) / 2;
            
            if (arr[mid] == target)
                return mid;
                
            if (arr[mid] < target)
                return PerformBinarySearchRecursive(arr, target, mid + 1, right);
            else
                return PerformBinarySearchRecursive(arr, target, left, mid - 1);
        }
    }
}
