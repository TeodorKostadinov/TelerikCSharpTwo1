using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class PermutationOfN
    {
        static void Permutate(int n,bool[] numberIsUsed,string output)
        {
            string outputNew = output;
            
            bool[] copyUsed=new bool[n];
            bool flag = false;
            for (int i = 0; i < n; i++)
            {
                copyUsed[i] = numberIsUsed[i];
                if (numberIsUsed[i] == false) flag = true;
            }
            if (!flag)
            {
                Console.WriteLine(output);
                return;
            }
            for (int i = 1; i <= n; i++)
            {
                if (numberIsUsed[i-1] == false)
                {
                    outputNew = output + i;
                    copyUsed[i - 1] = true;
                    Permutate(n, copyUsed, outputNew);
                    copyUsed[i - 1] = false;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number :");
            int n = int.Parse(Console.ReadLine());
            bool[] numberIsUsed = new bool[n];
            string output = "";
            Permutate(n, numberIsUsed, output);
        }
    }

