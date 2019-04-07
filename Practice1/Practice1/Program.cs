using System;

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

            Console.Write("Enter a radius: ");
            string radiusStr = ReadLine();
            int.TryParse(radiusStr, out int radius);
            Console.WriteLine($"The area of circle is: {Program.CalculateArea(radius)}");

            // check var names
            int uberflu = 2;
            int _identifier = 2;
            int \u006fidentifier = 2;
            int myVar = 2;
            int myVariable = 2;

            //check presicion
            const double Pi = Math.PI;
            double eNum = Math.E;
            Console.WriteLine(Pi); // 3.14159265358979
            Console.WriteLine(eNum); // 2.71828182845905
            //Control characters
            string newLine = "\nmystring 1";
            string tab = "\tmystring 2";
            string alert = "\amystring 3";
        }
    }
}
