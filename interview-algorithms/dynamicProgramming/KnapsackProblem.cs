using System.Diagnostics;

namespace interview_algorithms.dynamicProgramming
{
    public class KnapsackProblem
    {
        public class Item
        {
            public int Weight { get; set; }
            public int Value { get; set; }
            public string Name { get; set; } = "";
        }
        
        public static void Run()
        {
            Console.WriteLine("Starting Knapsack Problem...");
            
            Item[] items = {
                new Item { Weight = 10, Value = 60, Name = "Item1" },
                new Item { Weight = 20, Value = 100, Name = "Item2" },
                new Item { Weight = 30, Value = 120, Name = "Item3" }
            };
            
            int capacity = 50;
            
            Stopwatch stopwatch = new();
            stopwatch.Start();
            
            int maxValue = KnapsackDP(items, capacity);
            
            stopwatch.Stop();
            
            Console.WriteLine($"Maximum value in knapsack: {maxValue}");
            Console.WriteLine($"Execution Time: {stopwatch.Elapsed.TotalMilliseconds} ms");
        }
        
        // 0/1 Knapsack using Dynamic Programming
        public static int KnapsackDP(Item[] items, int capacity)
        {
            int n = items.Length;
            int[,] dp = new int[n + 1, capacity + 1];
            
            // Build table dp[][] in bottom-up manner
            for (int i = 0; i <= n; i++)
            {
                for (int w = 0; w <= capacity; w++)
                {
                    if (i == 0 || w == 0)
                    {
                        dp[i, w] = 0;
                    }
                    else if (items[i - 1].Weight <= w)
                    {
                        dp[i, w] = Math.Max(
                            items[i - 1].Value + dp[i - 1, w - items[i - 1].Weight],
                            dp[i - 1, w]
                        );
                    }
                    else
                    {
                        dp[i, w] = dp[i - 1, w];
                    }
                }
            }
            
            return dp[n, capacity];
        }
        
        // Space optimized version using 1D array
        public static int KnapsackOptimized(Item[] items, int capacity)
        {
            int[] dp = new int[capacity + 1];
            
            foreach (var item in items)
            {
                for (int w = capacity; w >= item.Weight; w--)
                {
                    dp[w] = Math.Max(dp[w], dp[w - item.Weight] + item.Value);
                }
            }
            
            return dp[capacity];
        }
    }
}
