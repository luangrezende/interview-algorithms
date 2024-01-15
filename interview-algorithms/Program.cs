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
            var test = new Solution();

            int[] nums1 = { 1, 3 };
            int[] nums2 = { 2, 4 };

            var result = test.FindMedianSortedArrays(nums1, nums2);
        }

        public class Solution
        {
            public double FindMedianSortedArrays(int[] nums1, int[] nums2)
            {
                int totalLength = nums1.Length + nums2.Length;
                int[] mergedArray = new int[totalLength];

                int i = 0, j = 0, k = 0;

                while (i < nums1.Length && j < nums2.Length)
                {
                    if (nums1[i] < nums2[j])
                        mergedArray[k++] = nums1[i++];
                    else
                        mergedArray[k++] = nums2[j++];
                }

                while (i < nums1.Length)
                    mergedArray[k++] = nums1[i++];

                while (j < nums2.Length)
                    mergedArray[k++] = nums2[j++];

                if (totalLength % 2 == 0)
                {
                    int middle1 = mergedArray[totalLength / 2 - 1];
                    int middle2 = mergedArray[totalLength / 2];
                    return (double)(middle1 + middle2) / 2;
                }
                else
                {
                    return mergedArray[totalLength / 2];
                }
            }
        }
    }
}
