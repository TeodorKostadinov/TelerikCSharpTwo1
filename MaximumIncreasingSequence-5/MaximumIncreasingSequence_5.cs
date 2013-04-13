using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class MaximumIncreasingSequence_5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter lenght: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int counter = 1, counter2=1;
            arr[0] = int.Parse(Console.ReadLine());
            int memory = arr[0];
            for (int i = 1; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i - 1] < arr[i]) counter++;
                else 
                { 
                    if(counter>counter2){counter2 = counter; memory=i-1;}
                    counter = 1; 
                }
            }
            if (counter > counter2) { counter2 = counter; memory = n-1; }
            Console.Write("The maximum sequence of equal elements is ");
            for (int i = 0; i < counter2; i++)
            {
                Console.Write("{0}, ",arr[memory-counter2+i+1]);
            }
            Console.WriteLine(" with lenght {0}",counter2);
        }
    }

