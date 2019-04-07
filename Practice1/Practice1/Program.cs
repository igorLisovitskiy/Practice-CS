﻿using System;
using static System.Console;

namespace Practice1
{
    class Program
    {
        public static double CalculateArea(int radius)
        {
            const double Pi = 3.14;
            return Pi * radius * radius;
        }

        static void Main(string[] args)
        {
            Write("Enter a radius: ");
            string radiusStr = ReadLine();
            int.TryParse(radiusStr, out int radius);
            WriteLine($"The area of circle is: {Program.CalculateArea(radius)}");
        }
    }
}
