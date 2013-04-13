using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class SequenceOfSum_10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter lenght: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter a sum to search for: ");
            int s=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter array: ");
            int sum = 0;
            int startIndex = 0, endIndex = 0;
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                startIndex = i;
                sum = 0;
                for (int j = i; j < n; j++)
                {
                    sum = sum + arr[j];
                    if (sum == s)
                    {
                        endIndex = j;
                        break;
                    }
                }
                if (sum == s) break;
            }
            Console.WriteLine("You can get {0} from adding the sequence: ",s);
            for (int i = startIndex; i <= endIndex; i++)
            {
                Console.Write("{0}, ",arr[i]);
            }
        }
    }

