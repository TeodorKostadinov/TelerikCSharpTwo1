using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class MaximumSumOfK_6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter lenght: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of additives: ");
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter array:  ");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(arr);
            Array.Reverse(arr);
            int sum = 0;
            for (int i = 0; i < k; i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine("The maximum sum with {0} elements from the array is {1}",k,sum);
        }
    }

