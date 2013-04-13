using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class TwoArrayCompare_2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter lenght of first array ");
            int firstLenght = int.Parse(Console.ReadLine());
            Console.Write("Enter lenght of second array ");
            int secondLenght = int.Parse(Console.ReadLine());
            int[] arrOne = new int[firstLenght];
            int[] arrTwo = new int[secondLenght];
            Console.WriteLine("Enter the first array of integers");
            for (int i = 0; i < firstLenght; i++)
            {
                Console.Write("Element {0}  ",i);
                arrOne[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the second array");
            for (int i = 0; i < secondLenght; i++)
            {
                Console.Write("Element {0}  ", i);
                arrTwo[i] = int.Parse(Console.ReadLine());
            }
            int n = firstLenght;
            if (n > secondLenght) n = secondLenght;
            for (int i = 0; i < n; i++)
            {
                if (arrOne[i] > arrTwo[i]) Console.WriteLine("Element {0} is bigger in the first array",i);
                else Console.WriteLine("Element {0} is bigger in the second array", i);
            }
            if (firstLenght != secondLenght) Console.WriteLine("The lenght of the arrays is not equal, cannot continue to compare");
            
        }
    }

