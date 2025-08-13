using System.Diagnostics;

namespace interview_algorithms.strings
{
    public class StringMatching
    {
        public static void Run()
        {
            Console.WriteLine("Starting String Matching Algorithms...");
            
            string text = "ABABDABACDABABCABCABCABCABC";
            string pattern = "ABABCABCABCABC";
            
            Console.WriteLine($"Text: {text}");
            Console.WriteLine($"Pattern: {pattern}");
            
            // Naive approach
            Stopwatch stopwatch = new();
            stopwatch.Start();
            var naiveResult = NaiveStringMatch(text, pattern);
            stopwatch.Stop();
            Console.WriteLine($"Naive approach found pattern at indices: [{string.Join(", ", naiveResult)}]");
            Console.WriteLine($"Naive time: {stopwatch.Elapsed.TotalMilliseconds} ms");
            
            // KMP approach
            stopwatch.Restart();
            var kmpResult = KMPSearch(text, pattern);
            stopwatch.Stop();
            Console.WriteLine($"KMP approach found pattern at indices: [{string.Join(", ", kmpResult)}]");
            Console.WriteLine($"KMP time: {stopwatch.Elapsed.TotalMilliseconds} ms");
        }
        
        // Naive string matching - O(nm) time complexity
        public static List<int> NaiveStringMatch(string text, string pattern)
        {
            List<int> matches = new List<int>();
            int n = text.Length;
            int m = pattern.Length;
            
            for (int i = 0; i <= n - m; i++)
            {
                int j = 0;
                while (j < m && text[i + j] == pattern[j])
                {
                    j++;
                }
                
                if (j == m)
                {
                    matches.Add(i);
                }
            }
            
            return matches;
        }
        
        // KMP (Knuth-Morris-Pratt) algorithm - O(n + m) time complexity
        public static List<int> KMPSearch(string text, string pattern)
        {
            List<int> matches = new List<int>();
            int n = text.Length;
            int m = pattern.Length;
            
            // Build failure function
            int[] lps = ComputeLPSArray(pattern);
            
            int i = 0; // index for text
            int j = 0; // index for pattern
            
            while (i < n)
            {
                if (pattern[j] == text[i])
                {
                    i++;
                    j++;
                }
                
                if (j == m)
                {
                    matches.Add(i - j);
                    j = lps[j - 1];
                }
                else if (i < n && pattern[j] != text[i])
                {
                    if (j != 0)
                        j = lps[j - 1];
                    else
                        i++;
                }
            }
            
            return matches;
        }
        
        // Compute Longest Proper Prefix which is also Suffix array
        private static int[] ComputeLPSArray(string pattern)
        {
            int m = pattern.Length;
            int[] lps = new int[m];
            int len = 0;
            int i = 1;
            
            lps[0] = 0;
            
            while (i < m)
            {
                if (pattern[i] == pattern[len])
                {
                    len++;
                    lps[i] = len;
                    i++;
                }
                else
                {
                    if (len != 0)
                    {
                        len = lps[len - 1];
                    }
                    else
                    {
                        lps[i] = 0;
                        i++;
                    }
                }
            }
            
            return lps;
        }
        
        // Rabin-Karp algorithm using rolling hash
        public static List<int> RabinKarpSearch(string text, string pattern)
        {
            List<int> matches = new List<int>();
            int n = text.Length;
            int m = pattern.Length;
            int prime = 101;
            int patternHash = 0;
            int textHash = 0;
            int h = 1;
            
            // Calculate h = pow(256, m-1) % prime
            for (int i = 0; i < m - 1; i++)
                h = (h * 256) % prime;
            
            // Calculate hash value of pattern and first window of text
            for (int i = 0; i < m; i++)
            {
                patternHash = (256 * patternHash + pattern[i]) % prime;
                textHash = (256 * textHash + text[i]) % prime;
            }
            
            // Slide the pattern over text one by one
            for (int i = 0; i <= n - m; i++)
            {
                // Check hash values
                if (patternHash == textHash)
                {
                    // Check for spurious hit
                    bool match = true;
                    for (int j = 0; j < m; j++)
                    {
                        if (text[i + j] != pattern[j])
                        {
                            match = false;
                            break;
                        }
                    }
                    
                    if (match)
                        matches.Add(i);
                }
                
                // Calculate hash value for next window
                if (i < n - m)
                {
                    textHash = (256 * (textHash - text[i] * h) + text[i + m]) % prime;
                    
                    // Convert negative value to positive
                    if (textHash < 0)
                        textHash = textHash + prime;
                }
            }
            
            return matches;
        }
    }
}
