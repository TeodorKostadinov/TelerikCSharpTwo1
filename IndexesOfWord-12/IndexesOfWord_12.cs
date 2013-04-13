using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class IndexesOfWord_12
    {
        static void Main(string[] args)
        {
            char[] arr = new char[29];
            Console.WriteLine("Write a word, no caps");
            string word = Console.ReadLine();
            //I create this array because it is said so in the task. 
            //It is not said, however, to use it to find the indexes. 
            //The printed numbers corespond to the indexes in the array
            for (int i = 0; i < 26; i++)
            {
                arr[i] = (char)((int)'a' + i);
            }

            Console.WriteLine("The indexes of the word are: ");
            foreach (char letter in word)
            {
                Console.Write("{0}, ",(int)(letter)-(int)('a'));
            }
        }
    }

