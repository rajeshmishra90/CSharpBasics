using System;

namespace BasicsPractice
{
    public class RotateMatrix
    {
        //Given an image represented by an NxN matrix, where each pixel in the image is 4 bytes, write a method to rotate the image by 90 degrees.Can you do this in place

        public static void MainRot(string[] args)
        {
            int n = 4;
            int[,] matrix = new int[n, n];
            initializeMatrix(matrix, n);
            Console.WriteLine("Input: ");
            printMatrix(matrix, n);
            Rotate(matrix, n);
            printMatrix(matrix, n);
        }

        public static void Rotate(int[,] matrix, int n)
        {
            for (int layer = 0; layer < n / 2; layer++)
            {
                int last = n - 1 - layer;
                for (int i = layer; i < last; i++)
                {
                    int offset = i - layer;
                    int temp = matrix[layer, i];
                    //left to top
                    matrix[layer, i] = matrix[last - offset, layer];

                    //bottom to left
                    matrix[last - offset, layer] = matrix[last, last - offset];

                    // right to bottom
                    matrix[last, last - offset] = matrix[i, last];

                    //top to right
                    matrix[i, last] = temp;
                    Console.Write("Current Status: ");
                    printMatrix(matrix, n);
                }
            }
        }

        public static void rotate(int[,] matrix, int n)
        {
            for (int layer = 0; layer < n / 2; ++layer)
            {
                Console.Write("\n--------------Starting an iteration of OUTER FOR LOOP------------------");

                int last = n - 1 - layer;
                for (int i = layer; i < last; ++i)
                {
                    int offset = i - layer;
                    int buffer = matrix[layer, i]; // save top
                    Console.WriteLine("\n--------------Starting an iteration of inner for loop------------------");
                    Console.WriteLine("layer =" + layer);

                    Console.WriteLine("last =" + last);
                    Console.WriteLine("i =" + i);

                    Console.WriteLine("buffer = " + buffer);
                    Console.WriteLine("offset = i-layer = " + offset);

                    // left -> top
                    matrix[layer, i] = matrix[last - offset, layer];

                    // bottom -> left
                    matrix[last - offset, layer] = matrix[last, last - offset];

                    // right -> bottom
                    matrix[last, last - offset] = matrix[i, last];

                    // top -> right
                    matrix[i, last] = buffer; // right <- saved top

                    //print
                    Console.WriteLine("Current Status: ");
                    printMatrix(matrix, n);
                    Console.WriteLine("--------------Finished an iteration of inner for loop------------------");
                }
                Console.WriteLine("--------------Finished an iteration of OUTER FOR LOOP------------------");
            }
        }

        public static void printMatrix(int[,] matrix, int n)
        {
            Console.Write("\n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(" " + matrix[i, j]);
                }
                Console.Write("\n");
            }
        }

        public static void initializeMatrix(int[,] matrix, int n)
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = (int)(rnd.Next(1, 100));
                }
            }
        }
    }
}