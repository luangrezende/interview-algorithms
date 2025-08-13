namespace interview_algorithms.sorting.core
{
    public class Builders
    {
        public static int[] GenerateRandomArray(int size = 9999)
        {
            Random random = new();
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(1, 10000);
            }

            return array;
        }
        
        public static int[] GenerateSortedArray(int size = 9999)
        {
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = i + 1;
            }
            return array;
        }
        
        public static int[] GenerateReverseSortedArray(int size = 9999)
        {
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = size - i;
            }
            return array;
        }
        
        public static int[] GenerateNearlySortedArray(int size = 9999, int swaps = 10)
        {
            int[] array = GenerateSortedArray(size);
            Random random = new();
            
            for (int i = 0; i < swaps; i++)
            {
                int index1 = random.Next(size);
                int index2 = random.Next(size);
                
                int temp = array[index1];
                array[index1] = array[index2];
                array[index2] = temp;
            }
            
            return array;
        }
    }
}
