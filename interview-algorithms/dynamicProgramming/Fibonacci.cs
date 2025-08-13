using System.Diagnostics;

namespace interview_algorithms.dynamicProgramming
{
    public class Fibonacci
    {
        public static void Run()
        {
            Console.WriteLine("Starting Fibonacci calculations...");
            int n = 45;
            
            // Naive recursive approach
            Stopwatch stopwatch = new();
            stopwatch.Start();
            long result1 = FibonacciRecursive(n);
            stopwatch.Stop();
            Console.WriteLine($"Recursive Fibonacci({n}): {result1}");
            Console.WriteLine($"Recursive Time: {stopwatch.Elapsed.TotalMilliseconds} ms");
            
            // Dynamic Programming approach
            stopwatch.Restart();
            long result2 = FibonacciDP(n);
            stopwatch.Stop();
            Console.WriteLine($"DP Fibonacci({n}): {result2}");
            Console.WriteLine($"DP Time: {stopwatch.Elapsed.TotalMilliseconds} ms");
            
            // Space optimized approach
            stopwatch.Restart();
            long result3 = FibonacciOptimized(n);
            stopwatch.Stop();
            Console.WriteLine($"Optimized Fibonacci({n}): {result3}");
            Console.WriteLine($"Optimized Time: {stopwatch.Elapsed.TotalMilliseconds} ms");
        }
        
        // Naive recursive - O(2^n) time complexity
        public static long FibonacciRecursive(int n)
        {
            if (n <= 1)
                return n;
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }
        
        // Dynamic Programming - O(n) time, O(n) space
        public static long FibonacciDP(int n)
        {
            if (n <= 1)
                return n;
                
            long[] dp = new long[n + 1];
            dp[0] = 0;
            dp[1] = 1;
            
            for (int i = 2; i <= n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }
            
            return dp[n];
        }
        
        // Space optimized - O(n) time, O(1) space
        public static long FibonacciOptimized(int n)
        {
            if (n <= 1)
                return n;
                
            long prev2 = 0;
            long prev1 = 1;
            long current = 0;
            
            for (int i = 2; i <= n; i++)
            {
                current = prev1 + prev2;
                prev2 = prev1;
                prev1 = current;
            }
            
            return current;
        }
    }
}
