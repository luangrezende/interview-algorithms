using System.Drawing;

namespace interview_algorithms.types
{
    public class MyArray
    {
        private int index;
        private int[] array;

        public MyArray()
        {
            index = 0;
            array = new int[10];
        }

        public void Add(int value)
        {
            array[index] = value;
            index++;
        }

        public void Override(int key, int value)
        {
            array[key] = value;
        }

        public void Remove(int key)
        {
            array[key] = 0;
        }

        public int Read(int key)
        {
            return array[key];
        }

        public void Fit()
        {
            int index = 0;
            var arrayTemp = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                {
                    arrayTemp[index] = array[i];
                    index++;
                }
            }

            array = arrayTemp;
        }

        public void Resize(int size)
        {
            var arrayTemp = new int[size];

            for (int i = 0; i < array.Length; i++)
            {
                arrayTemp[i] = array[i];
            }

            array = arrayTemp;
        }
    }
}
