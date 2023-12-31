﻿using System;
using System.Threading;

namespace Exam5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string yesOrNo = Console.ReadLine();
            double start = 5364;
            int days = 1;

            while (yesOrNo != "END")
            {
                if (yesOrNo == "Yes")
                    days++;

                if (days > 5)
                    break;

                double meters = double.Parse(Console.ReadLine());
                start += meters;

                if (start >= 8848)
                    break;
                yesOrNo = Console.ReadLine();
            }
            if (start >= 8848)
                Console.WriteLine($"Goal reached for {days} days!");
            
            else
            {
                Console.WriteLine("Failed!");
                Console.WriteLine($"{start}");
            }
        }
    }
}
