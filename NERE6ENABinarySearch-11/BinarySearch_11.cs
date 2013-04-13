using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class BinarySearch_11
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter lenght: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number to search for: ");
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter array:  ");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(arr);
            bool found = false;
            for (int lowEnd = 0, highEnd = arr.Length - 1; lowEnd <= highEnd; )
            {
                int middle = lowEnd + (highEnd - lowEnd) / 2;

                if (arr[middle] < k) lowEnd = middle + 1;
                else if (arr[middle] > k) highEnd = middle - 1;
                else
                {
                    found = true;
                    Console.WriteLine("The searched item is on position {0} in the ordered array",middle);
                    break;
                }
            }
            if (found == false) Console.WriteLine("Item not found");
        }
    }

