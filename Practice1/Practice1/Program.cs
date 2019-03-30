using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }
    }
}
