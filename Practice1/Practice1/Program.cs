using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class Program
    {
        static int Sum(long x, int y)
        {
            return (int) (x + y);
        }

        static void Main(string[] args)
        {
            long n1 = 32301; // implicit
            short n2 = 15;
            Console.WriteLine($"{n1} + {n2} = {Program.Sum(n1, n2)}");
        }
    }
}
