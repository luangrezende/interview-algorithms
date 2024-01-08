namespace interview_algorithms.sorting.core
{
    public class Builders
    {
        public static int[] GenerateRandomArray()
        {
            int arraySine = 9999;

            Random random = new();
            int[] array = new int[arraySine];

            for (int i = 0; i < arraySine; i++)
            {
                array[i] = random.Next();
            }

            return array;
        }
    }
}
