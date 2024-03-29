﻿using System;

class Combinations
{
    static void Check(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + 1 + (i == arr.Length - 1 ? "\n" : " "));
    }

    static void Combination(int[] arr, int n, int i, int next)
    {
        if (i == arr.Length)
        {
            Check(arr);
            return;
        }

        for (int j = next; j < n; j++)
        {
            arr[i] = j;

            Combination(arr, n, i + 1, j + 1);
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter number of all elements");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number of els to choose from");
        int[] arr = new int[int.Parse(Console.ReadLine())];

        Combination(arr, n, 0, 0);
    }
}