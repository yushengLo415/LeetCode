using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algo_Implement
{
    class Algo_QuickSort
    {   
        public void swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;

        }

        public int partition(int[] arr, int start, int end)
        {
            int p = arr[end];
            int q = start;

            for (int i = start; i < end; i++)
            {
                if (arr[i] < p)
                {
                    swap(arr, i, q);
                    q++;
                }
            }

            swap(arr, end, q);

            return q;
        }


        public void QuickSort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int pivot = partition(arr, start, end);
                QuickSort(arr, start, pivot - 1);
                QuickSort(arr, pivot + 1, end);
            }
        }

        /*static int Main()
        {
            Algo_QuickSort q = new Algo_QuickSort();
            int[] arr = new int[8] { 9, 2, 3, 5, 4, 7, 1, 6 };
            q.QuickSort(arr, 0, arr.Length - 1);
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.ReadKey();
            return 0;
        }*/
    }
}
