using interview_algorithms.sorting;
using interview_algorithms.types;

namespace interview_algorithms
{
    public class Program
    {
        public static void Main()
        {
            var myArray = new MyArray();

            myArray.Add(100);
            myArray.Add(200);
            myArray.Add(300);
            myArray.Add(400);
            
            Console.WriteLine(myArray.Read(1));
        }
    }
}
