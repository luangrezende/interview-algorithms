using interview_algorithms.types;
using System;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;

namespace interview_algorithms
{
    public class Program
    {
        public static void Main()
        {
            var test = new Solution2();

            var result = test.LengthOfLongestSubstring("pwwkew");
        }

        public class Solution
        {
            public int LengthOfLongestSubstring(string text)
            {
                int index = 0;
                int count = 0;
                int countTemp = 0;
                int countTempFor = 0;
                char[] arrayTemp = new char[text.Length];

                for (int i = 0; i < text.Length; i++)
                {
                    Calculate(i, text, ref index, ref count, ref countTemp, ref countTempFor, ref arrayTemp);
                }


                return count;
            }

            private static void Calculate(
                int countFor, 
                string text, 
                ref int index, 
                ref int count, 
                ref int countTemp, 
                ref int countTempFor, 
                ref char[] arrayTemp)
            {
                for (int i = countFor; i < text.Length; i++)
                {
                    countTempFor = i;
                    for (int j = 0; j < arrayTemp.Length; j++)
                    {
                        if (arrayTemp[j].ToString() == "\0")
                            continue;

                        if (arrayTemp[j] == text[i])
                        {
                            arrayTemp = new char[text.Length];
                            countTemp = 0;
                            index = 0;
                            
                            break;
                        }
                    }

                    countTemp++;

                    count = countTemp > count
                       ? countTemp
                       : count;

                    arrayTemp[index] = text[i];
                    index++;
                }
            }
        }

        public class Solution2
        {
            public int LengthOfLongestSubstring(string text)
            {
                int count = 0;

                for (int i = 0; i < text.Length; i++)
                {
                    int result = Calculate(i, text);

                    count = result > count
                       ? result
                       : count;
                }

                return count;
            }

            private static int Calculate(
                int countFor,
                string text)
            {
                int count = 0;
                int index = 0;
                char target = text[countFor];
                char[] arrayTemp = new char[text.Length];

                for (int i = countFor + 1; i < text.Length; i++)
                {
                    arrayTemp[index] = text[i];
                    index++;

                    for (int j = 0; j < arrayTemp.Length; j++)
                    {
                        if (arrayTemp[j].ToString() == "\0")
                            continue;

                        if (arrayTemp[j] == target)
                        {
                            break;
                        }
                        else
                        {
                            count++;
                        }
                    }

                    //if (target != text[i])
                    //    count++;
                    //else
                    //    break;
                }

                return count;
            }
        }
    }
}
