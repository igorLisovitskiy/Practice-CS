using System;

namespace Practice1
{
    class Program
    {

        const double Pi = Math.PI;

        static int Sum(long x, int y)
        {
            return (int) (x + y);
        }

        static double ArithmeticMean(int x, int y, int z)
        {
            return (double)(x + y + z) / 2;
        }

        static double AreaOfCircle(double radius)
        {

            return Pi * Math.Pow(radius, 2);
        }

        static double CylinderVolume(int height, int radius)
        {
            return Pi * radius * 2 * height;
        }


        static double CylinderArea(int height, int radius)
        {
            return 2 * (Pi * radius) * (radius + height);
        }
          
        public static double CalculateArea(int radius)
        {
            const double Pi = 3.14;
            return Pi * radius * radius;

        }

        static void Main(string[] args)
        {

            // Narrowing Primitive Conversion
            long n1 = 32301;
            short n2 = 15;
            Console.WriteLine($"{n1} + {n2} = {Program.Sum(n1, n2)}");
            decimal dec = 7.98845m;
            int i1 = 455;
            int i2 = 84500;
            Console.WriteLine((short)i1);
            Console.WriteLine((short)i2);
            Console.WriteLine($"int rounds down decimal {dec} to {(int) dec}");

            Console.WriteLine(Program.AreaOfCircle(4));
            Console.WriteLine(Program.ArithmeticMean(4, 4, 2));
            Console.WriteLine(Program.CylinderVolume(4, 2));
            Console.WriteLine(Program.CylinderArea(4, 2));

            Console.Write("Enter a radius: ");
            string radiusStr = Console.ReadLine();
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
            //Console.WriteLine(Pi); // 3.14159265358979
            //Console.WriteLine(eNum); // 2.71828182845905

            //Control characters
            string newLine = "\nmystring 1";
            string tab = "\tmystring 2";
            string alert = "\amystring 3";
        }
    }
}
