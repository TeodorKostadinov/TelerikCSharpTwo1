﻿using System;

class SumOfNumberedElements
{
    static void Check(int[] arr, int[] indices, int k, int sum)
    {
        int currentSum = 0;
        for (int i = 0; i <= k; i++) currentSum += arr[indices[i]];

        if (currentSum == sum) for (int i = 0; i <= k; i++) Console.Write(arr[indices[i]] + (i == k ? " = " + sum + "\n" : " + "));
    }

    static void Combination(int[] arr, int[] indices, int k, int sum, int i, int next)
    {
        if (i > k) return;

        for (int j = next; j < arr.Length; j++)
        {
            indices[i] = j;

            if (i == k) Check(arr, indices, k, sum);

            Combination(arr, indices, k, sum, i + 1, j + 1);
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter arrays lenght: ");
        int[] arr = new int[int.Parse(Console.ReadLine())];
        Console.WriteLine("Enter number of additives");
        int k = int.Parse(Console.ReadLine())-1;
        Console.WriteLine("Enter sum to look for");
        int sum = int.Parse(Console.ReadLine());
        for (int i = 0; i < arr.Length; i++) arr[i] = int.Parse(Console.ReadLine());

        int[] indices = new int[arr.Length];
        Combination(arr, indices, k, sum, 0, 0);
    }
}