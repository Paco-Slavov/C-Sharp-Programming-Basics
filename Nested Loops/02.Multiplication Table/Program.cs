﻿using System;

namespace _02.Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int n1 = 1; n1 < args.Length; n1++)
            {
                for (int n2 = 1; n2 <= 10; n2++)
                {
                    int result = n1 * n2;
                    Console.WriteLine($"{n1} * {n2} = {result}");
                }
            }
        }
    }
}