using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class SelectionSort_7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter lenght: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter array: ");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int smallest = arr[0];
            int index = 0;
            for (int i = 0; i < n-1; i++)
            {
                for (int j = i; j < n; j++)
                {
                    if (arr[j] < smallest) { smallest = arr[j]; index = j; }
                }
                arr[index] = arr[i];
                arr[i] = smallest;
                smallest = arr[i + 1];
                index = i + 1;
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}, ",arr[i]);
            }
        }
    }

