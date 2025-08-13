using interview_algorithms.sorting;
using interview_algorithms.searching;
using interview_algorithms.dynamicProgramming;
using interview_algorithms.graphs;
using interview_algorithms.trees;
using interview_algorithms.strings;
using interview_algorithms.greedy;
using interview_algorithms.backtracking;
using interview_algorithms.leetCode;

namespace interview_algorithms
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("=== Interview Algorithms Demonstration ===\n");

            while (true)
            {
                DisplayMenu();
                var choice = Console.ReadLine();

                try
                {
                    switch (choice?.ToLower())
                    {
                        case "1":
                            RunSortingAlgorithms();
                            break;
                        case "2":
                            RunSearchingAlgorithms();
                            break;
                        case "3":
                            RunDynamicProgramming();
                            break;
                        case "4":
                            RunGraphAlgorithms();
                            break;
                        case "5":
                            RunTreeAlgorithms();
                            break;
                        case "6":
                            RunStringAlgorithms();
                            break;
                        case "7":
                            RunGreedyAlgorithms();
                            break;
                        case "8":
                            RunBacktrackingAlgorithms();
                            break;
                        case "9":
                            RunLeetCodeProblems();
                            break;
                        case "q":
                        case "quit":
                            Console.WriteLine("Thanks for using Interview Algorithms!");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void DisplayMenu()
        {
            Console.WriteLine("Choose an algorithm category to run:");
            Console.WriteLine("1. Sorting Algorithms");
            Console.WriteLine("2. Searching Algorithms");
            Console.WriteLine("3. Dynamic Programming");
            Console.WriteLine("4. Graph Algorithms");
            Console.WriteLine("5. Tree Algorithms");
            Console.WriteLine("6. String Algorithms");
            Console.WriteLine("7. Greedy Algorithms");
            Console.WriteLine("8. Backtracking Algorithms");
            Console.WriteLine("9. LeetCode Problems");
            Console.WriteLine("Q. Quit");
            Console.Write("\nEnter your choice: ");
        }

        static void RunSortingAlgorithms()
        {
            Console.Clear();
            Console.WriteLine("=== Sorting Algorithms ===\n");
            
            Console.WriteLine("1. Bubble Sort");
            BubbleSort.Run();
            Console.WriteLine();
            
            Console.WriteLine("2. Quick Sort");
            QuickSort.Run();
            Console.WriteLine();
            
            Console.WriteLine("3. Merge Sort");
            MergeSort.Run();
            Console.WriteLine();
            
            Console.WriteLine("4. Selection Sort");
            SelectionSort.Run();
            Console.WriteLine();
            
            Console.WriteLine("5. Insertion Sort");
            InsertionSort.Run();
            Console.WriteLine();
            
            Console.WriteLine("6. Heap Sort");
            HeapSort.Run();
        }

        static void RunSearchingAlgorithms()
        {
            Console.Clear();
            Console.WriteLine("=== Searching Algorithms ===\n");
            
            Console.WriteLine("1. Linear Search");
            LinearSearch.Run();
            Console.WriteLine();
            
            Console.WriteLine("2. Binary Search");
            BinarySearch.Run();
        }

        static void RunDynamicProgramming()
        {
            Console.Clear();
            Console.WriteLine("=== Dynamic Programming ===\n");
            
            Console.WriteLine("1. Fibonacci Series");
            Fibonacci.Run();
            Console.WriteLine();
            
            Console.WriteLine("2. Knapsack Problem");
            KnapsackProblem.Run();
        }

        static void RunGraphAlgorithms()
        {
            Console.Clear();
            Console.WriteLine("=== Graph Algorithms ===\n");
            
            Console.WriteLine("1. DFS and BFS");
            Graph.Run();
            Console.WriteLine();
            
            Console.WriteLine("2. Dijkstra's Algorithm");
            DijkstraAlgorithm.Run();
        }

        static void RunTreeAlgorithms()
        {
            Console.Clear();
            Console.WriteLine("=== Tree Algorithms ===\n");
            
            Console.WriteLine("1. Binary Search Tree");
            BinarySearchTree.Run();
        }

        static void RunStringAlgorithms()
        {
            Console.Clear();
            Console.WriteLine("=== String Algorithms ===\n");
            
            Console.WriteLine("1. String Matching");
            StringMatching.Run();
        }

        static void RunGreedyAlgorithms()
        {
            Console.Clear();
            Console.WriteLine("=== Greedy Algorithms ===\n");
            
            Console.WriteLine("1. Activity Selection");
            ActivitySelection.Run();
            Console.WriteLine();
            
            Console.WriteLine("2. Fractional Knapsack");
            FractionalKnapsack.Run();
            Console.WriteLine();
            
            Console.WriteLine("3. Huffman Coding");
            HuffmanCoding.Run();
        }

        static void RunBacktrackingAlgorithms()
        {
            Console.Clear();
            Console.WriteLine("=== Backtracking Algorithms ===\n");
            
            Console.WriteLine("1. N-Queens Problem");
            NQueensProblem.Run();
            Console.WriteLine();
            
            Console.WriteLine("2. Sudoku Solver");
            Sudoku.Run();
        }

        static void RunLeetCodeProblems()
        {
            Console.Clear();
            Console.WriteLine("=== LeetCode Problems ===\n");
            
            Console.WriteLine("1. Two Sum");
            var twoSum = new TwoSum();
            twoSum.Run();
            Console.WriteLine();
            
            Console.WriteLine("2. Find Median of Sorted Arrays");
            var median = new FindMedianSortedArrays();
            int[] nums1 = { 1, 3 };
            int[] nums2 = { 2, 4 };
            var result = median.FindMedianSortedArraysRun(nums1, nums2);
            Console.WriteLine($"Median: {result}");
            Console.WriteLine();
            
            Console.WriteLine("3. Longest Substring Without Repeating Characters");
            LengthOfLongestSubstring.Run();
        }
    }
}
