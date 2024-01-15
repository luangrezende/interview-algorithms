namespace interview_algorithms.leetCode
{
    public class TwoSum
    {
        public void Run()
        {
            var nums = new int[] { 3, 2, 3 };
            var result = TwoSumRun(nums, 6);
        }

        public int[] TwoSumRun(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if ((nums[i] + nums[j]) == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return new int[0];
        }
    }
}
