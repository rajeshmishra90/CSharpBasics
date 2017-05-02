using System;

namespace BasicsPractice
{
    internal class DecimalToBinaryConversion
    {
        public static void Main2(string[] args)
        {
            int decimalNumber = Convert.ToInt32(Console.ReadLine());
            int countOfOnes = GetOnesOccurance(decimalNumber);
            Console.WriteLine(countOfOnes);
        }

        private static int GetOnesOccurance(int decimalNumber)
        {
            int maxCountOfOnes = 0;
            bool isOne = false;
            int remainder = decimalNumber;
            int occurance = 0;
            while (remainder != 0)
            {
                Int32 bit = decimalNumber % 2;
                remainder = decimalNumber / 2;
                if (bit == 1)
                {
                    if (isOne)
                        occurance += 1;
                    else
                        occurance = 1;
                    isOne = true;
                }
                else
                {
                    isOne = false;
                }
                if (occurance > maxCountOfOnes)
                    maxCountOfOnes = occurance;
                decimalNumber = remainder;
            }
            return maxCountOfOnes;
        }
    }
}