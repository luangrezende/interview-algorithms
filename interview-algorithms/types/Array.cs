using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace interview_algorithms.types
{
    public class MyArray
    {
        private int index;
        private readonly int[] array;

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
    }
}
