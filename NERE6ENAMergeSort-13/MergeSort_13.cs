using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class MergeSort_13
    {
        static void Merge(int[] arr, int[] temp, int l, int m, int r)
        {
            int i = l, j = m + 1, k = l;

            
            while (i <= m && j <= r)
                if (arr[i] < arr[j]) temp[k++] = arr[i++];
                else temp[k++] = arr[j++];

            while (i <= m) temp[k++] = arr[i++]; 
            while (j <= r) temp[k++] = arr[j++];

            for (i = l; i <= r; i++) arr[i] = temp[i]; 
        }

        static void MergeSort(int[] arr, int[] temp, int l, int r)
        {
            if (l >= r) return;

            int m = l + (r - l) / 2; 

            MergeSort(arr, temp, l, m);
            MergeSort(arr, temp, m + 1, r);

            Merge(arr, temp, l, m, r); 
        }

        static void Main()
        {
            Console.WriteLine("Enter lenght: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter array:  ");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int[] temp = new int[n];
            MergeSort(arr, temp, 0, arr.Length - 1);

            foreach (int item in arr) Console.WriteLine(item);
        }
    }

