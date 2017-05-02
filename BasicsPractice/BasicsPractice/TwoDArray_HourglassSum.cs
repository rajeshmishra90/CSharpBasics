using System;

namespace BasicsPractice
{
    internal class TwoDArray_HourglassSum
    {
        public static void Mainn(string[] args)
        {
            int[][] arr = new int[6][];
            for (int arr_i = 0; arr_i < 6; arr_i++)
            {
                string[] arr_temp = Console.ReadLine().Split(' ');
                arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
            }

            int row = 6;
            int col = 6;
            int[,] TwoDArr = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    TwoDArr[i, j] = arr[i][j];
                }
            }
            int max = int.MinValue;

            for (int startRow = 0; startRow < row - startRow - 1 + 3; startRow++)
            {
                for (int startCol = 0; startCol < col - startCol - 1 + 3; startCol++)
                {
                    int currentSum = 0;
                    currentSum = TraverseCube(TwoDArr, startRow, startCol);
                    if (currentSum > max)
                    {
                        max = currentSum;
                    }
                }
            }
            Console.WriteLine(max);
        }

        private static int TraverseCube(int[,] TwoDArr, int startRow, int startCol)
        {
            int sum = 0;
            for (int i = startRow; i < startRow + 3; i++)
            {
                for (int j = startCol; j < startCol + 3; j++)
                {
                    if ((startRow + 1 == i && startCol == j) || (startRow + 1 == i && startCol + 2 == j))
                    {
                    }
                    else
                        sum += TwoDArr[i, j];
                }
            }
            return sum;
        }
    }
}