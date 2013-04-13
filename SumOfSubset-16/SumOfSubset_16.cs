using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class SumOfSubset_16
    {
        
        static int[] arr;
        static int[] memory;
        static int j = 0;
        static int Subset(int[] arr,int s,int n)
        {
            for (int i = 0; i < n; i++)
			{
                if (arr[i] != 0)
                {
                    if (arr[i] == s)
                    {
                        memory[j] = arr[i];
                        j++;
                        return 1;
                    }
                    else
                    {
                        if (arr[i] < s)
                        {
                            int temp = arr[i];
                            s = s - arr[i];
                            arr[i] = 0;
                            int back=Subset(arr,s, n);
                            arr[i] = temp;
                            if (back == 1)
                            {
                                memory[j] = arr[i];
                                j++;
                                return 1;
                            }
                        }
                    }
                }
			}
            return 0;
        }
        static void Main(string[] args)
        {
            //rekursiq
            //funkciqta 6te e moga li s tozi masiv da namerq sumata
            //izvajdame 4isloto ot sumata, zdraskvame go ot masiva
            //moga li s tozi masiv da namerq sumata i tn dokato sumata stane ravna na edno ot 4islata

            Console.WriteLine("Enter lenght: ");
            int n = int.Parse(Console.ReadLine());
            arr = new int[n];
            memory = new int[n];
            Console.WriteLine("Enter sum to look for: ");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter array: ");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int back = Subset(arr,s, n);
            if (back == 0) Console.WriteLine("You can't get the sum form this set");
            else
            {
                Console.WriteLine("There is a subset");
                for (int i = 0; i < j; i++)
                {
                    Console.Write("{0} + ",memory[i]);
                }
            }
        }
    }

