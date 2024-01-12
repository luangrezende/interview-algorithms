namespace interview_algorithms.leetCode
{
    public class DetermineifStringHalvesAreAlike
    {
        private int index;

        public bool HalvesAreAlike(string word)
        {
            char[] vogals = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            int middleString = word.Length / 2;
            var charArray = ToCharArray(word);

            var arrayA = PopulateArray(charArray, middleString);
            var arrayB = PopulateArray(charArray, middleString);

            int countVogalsArrayA = CalculateVogalsCount(vogals, arrayA);
            int countVogalsArrayB = CalculateVogalsCount(vogals, arrayB);

            return countVogalsArrayA == countVogalsArrayB;
        }

        private int CalculateVogalsCount(char[] vogals, char[] word)
        {
            int countVogals = 0;
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < vogals.Length; j++)
                {
                    if (vogals[j] == word[i])
                    {
                        countVogals++;
                    }
                }
            }

            return countVogals;
        }

        private char[] ToCharArray(string word)
        {
            int index = 0;
            char[] array = new char[word.Length];

            for (int i = 0; i < word.Length; i++)
            {
                array[index] = word[i];
                index++;
            }

            return array;
        }

        private char[] PopulateArray(char[] charArray, int middleString)
        {
            char[] array = new char[charArray.Length];
            for (int i = 0; i < middleString; i++)
            {
                array[i] = charArray[index];
                index++;
            }

            return array;
        }
    }
}
