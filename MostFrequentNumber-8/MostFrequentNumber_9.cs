using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class MostFrequentNumber_9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter lenght: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int counter = 1, memory,counterBiggest=1;
            Console.WriteLine("Enter array: ");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(arr);
            memory = arr[0];
            for (int i = 1; i < n; i++)
            {
                if (arr[i - 1] == arr[i]) counter++;
                else
                {
                    if (counter > counterBiggest)
                    {
                        counterBiggest = counter;
                        memory = arr[i - 1];
                    }
                    counter = 1;

                }
            }
            Console.WriteLine("The most frequent number is {0}, repeated {1} times",memory,counterBiggest);

        }
    }
