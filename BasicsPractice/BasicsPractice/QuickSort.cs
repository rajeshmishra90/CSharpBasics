using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsPractice
{
    public class QuickSort
    {
        static public int Partition(int[] numbers, int left, int right)
        {
            int pivot = numbers[left];
            while (true)
            {
                while (numbers[left] < pivot)
                    left++;

                while (numbers[right] > pivot)
                    right--;

                if (left < right)
                {
                    int temp = numbers[right];
                    numbers[right] = numbers[left];
                    numbers[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }

        static public void SortQuick(int[] arr, int left, int right)
        {
            // For Recusrion  
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                    SortQuick(arr, left, pivot - 1);

                if (pivot + 1 < right)
                    SortQuick(arr, pivot + 1, right);
            }
        }

        public static void quickSortString(String[] arr, int low, int high)
        {
            if (arr == null || arr.Length == 0)
                return;

            if (low >= high)
                return;

            int middle = low + (high - low) / 2;
            String pivot = arr[middle];

            int i = low;
            int j = high;

            while (i <= j)
            {
                while (compare(arr[i], pivot) < 0)
                    i++;

                while (compare(arr[j], pivot) > 0)
                    j--;

                if (i <= j)
                {
                    String temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                }
            }
            if (low < j)
                quickSortString(arr, low, j);
            if (high > i)
                quickSortString(arr, i, high);
        }

        public static int compare(String a, String b)
        {
            // return 0 if 2 strings numeric values are equal
            // return 1 if a is larger
            // retrun -1 if b is larger

            int aLen = a.Length;
            int bLen = b.Length;
            if (aLen > bLen)
                return 1;
            if (aLen < bLen)
                return -1;

            //int result = a.CompareTo(b);
            int result = string.CompareOrdinal(a, b);
            if (result == 0)
                return 0;
            if (result > 0) // a is bigger
                return 1;

            return -1; // b is bigger
        }
    }
}
