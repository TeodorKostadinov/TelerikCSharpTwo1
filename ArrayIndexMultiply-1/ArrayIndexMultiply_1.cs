using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class ArrayIndexMultiply_1
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            for (int i = 0; i < 20; i++)
            {
                arr[i] = 5*i;
                Console.WriteLine("Item {0} is with value {1}",i,arr[i]);
            }
        }
    }

