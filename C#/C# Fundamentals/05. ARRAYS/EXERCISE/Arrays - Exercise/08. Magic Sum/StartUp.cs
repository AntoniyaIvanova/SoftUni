﻿namespace _08._Magic_Sum
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int uniqueSum = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == uniqueSum)
                    {
                        Console.WriteLine(numbers[i] + " " + numbers[j]);
                    }
                }
            }
        }
    }
}

