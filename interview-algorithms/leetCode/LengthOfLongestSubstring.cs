using System.Diagnostics;

namespace interview_algorithms.leetCode
{
    public class LengthOfLongestSubstring
    {
        public static void Run()
        {
            Console.WriteLine("Starting Longest Substring Without Repeating Characters...");
            
            string[] testCases = {
                "abcabcbb",  // Expected: 3 (abc)
                "bbbbb",     // Expected: 1 (b)
                "pwwkew",    // Expected: 3 (wke)
                "dvdf",      // Expected: 3 (vdf)
                ""           // Expected: 0
            };
            
            var solution = new LengthOfLongestSubstring();
            
            foreach (string testCase in testCases)
            {
                Stopwatch stopwatch = new();
                stopwatch.Start();
                
                int result = solution.LengthOfLongestSubstringRun(testCase);
                
                stopwatch.Stop();
                
                Console.WriteLine($"Input: \"{testCase}\" -> Length: {result} (Time: {stopwatch.Elapsed.TotalMilliseconds:F2}ms)");
            }
        }
        
        public int LengthOfLongestSubstringRun(string text)
        {
            int count = 0;
            HashSet<char> charSet = new();
            int left = 0;

            for (int right = 0; right < text.Length; right++)
            {
                while (charSet.Contains(text[right]))
                {
                    charSet.Remove(text[left]);
                    left++;
                }

                charSet.Add(text[right]);
                count = Math.Max(count, right - left + 1);
            }

            return count;
        }
        
        // Alternative implementation with dictionary for better performance
        public int LengthOfLongestSubstringOptimized(string s)
        {
            Dictionary<char, int> charIndexMap = new Dictionary<char, int>();
            int maxLength = 0;
            int left = 0;

            for (int right = 0; right < s.Length; right++)
            {
                if (charIndexMap.ContainsKey(s[right]))
                {
                    left = Math.Max(left, charIndexMap[s[right]] + 1);
                }

                charIndexMap[s[right]] = right;
                maxLength = Math.Max(maxLength, right - left + 1);
            }

            return maxLength;
        }
    }
}
