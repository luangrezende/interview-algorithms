namespace interview_algorithms.leetCode
{
    public class LengthOfLongestSubstring
    {
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
    }
}
