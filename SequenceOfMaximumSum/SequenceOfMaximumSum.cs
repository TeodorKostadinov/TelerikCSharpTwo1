using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class SequenceOfMaximumSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter lenght: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int maxSum = int.MinValue;
            int allSum = 0;
            int startIndex = 0;
            int startTemp = 0;
            int endIndex = 0;

            Console.WriteLine("Enter array: ");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            
            for (int i = 0; i < arr.Length; i++)
            {
                allSum =allSum+ arr[i];

                if (arr[i] > allSum)
                {
                    allSum = arr[i];
                    startTemp = i;
                }
                if (allSum > maxSum)
                {
                    maxSum = allSum;
                    startIndex = startTemp;
                    endIndex = i;
                }
            }

            Console.WriteLine("The maximal sum is: {0}", maxSum);
            for (int i = startIndex; i <= endIndex; i++)
            {
                Console.Write("{0} + ",arr[i]);
            }
        }
    }

