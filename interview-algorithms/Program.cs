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
    }
}
