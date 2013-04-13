using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class LexicographicArrayCompare_3
    {
        static void Main(string[] args)
        {
            Console.Write("Enter lenght of first array ");
            int firstLenght = int.Parse(Console.ReadLine());
            Console.Write("Enter lenght of second array ");
            int secondLenght = int.Parse(Console.ReadLine());
           char[] arrOne = new char[firstLenght];
            char[] arrTwo = new char[secondLenght];
            Console.WriteLine("Enter the first array of characters");
            for (int i = 0; i < firstLenght; i++)
            {
                Console.Write("Element {0}  ", i);
                arrOne[i] = char.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the second array");
            for (int i = 0; i < secondLenght; i++)
            {
                Console.Write("Element {0}  ", i);
                arrTwo[i] = char.Parse(Console.ReadLine());
            }
            int n = firstLenght;
            if (n > secondLenght) n = secondLenght;
            bool different = false;
            for (int i = 0; i < n; i++)
            {
                if (arrOne[i] > arrTwo[i])
                {
                    Console.WriteLine("The first array is bigger lexicographically");
                    different = true;
                    break;
                }
                if (arrOne[i] < arrTwo[i])
                {
                    Console.WriteLine("The second array is bigger lexicographically");
                    different = true;
                    break;
                }
            }
            if (different == false)
            {
                if (firstLenght == secondLenght ) Console.WriteLine("Arrays are equal");
                if (firstLenght > secondLenght ) Console.WriteLine("First array is bigger");
                if (firstLenght < secondLenght ) Console.WriteLine("Second array is bigger");
            } 
        }
    }

