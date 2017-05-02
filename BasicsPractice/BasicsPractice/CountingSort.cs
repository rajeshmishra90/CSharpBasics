using System;

namespace BasicsPractice
{
    internal class CountingSort
    {
        private static void Main1(string[] args)
        {
            try
            {
                int numbers = Convert.ToInt32(Console.ReadLine());
                int[] inputArray = new int[numbers];
                for (int i = 0; i < numbers; i++)
                {
                    inputArray[i] = Convert.ToInt32(Console.ReadLine());
                }
                int[] sortedOutput = CountSort(inputArray, numbers);
                for (int i = 0; i < numbers; i++)
                {
                    Console.WriteLine(sortedOutput[i]);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private static int[] CountSort(int[] inputArray, int numbers)
        {
            int range = 1000000;
            int[] sortedArray = new int[numbers];
            int[] countArray = new int[range + 1];
            int i = 0;
            for (i = 0; i < numbers; ++i)
            {
                countArray[inputArray[i]] = countArray[inputArray[i]] + 1;
            }

            for (i = 1; i <= range; i++)
            {
                countArray[i] = countArray[i] + countArray[i - 1];
            }

            for (i = 0; i < numbers; i++)
            {
                sortedArray[countArray[inputArray[i]] - 1] = inputArray[i];
                countArray[inputArray[i]] = countArray[inputArray[i]] - 1;
            }

            return sortedArray;
        }
    }
}