using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Quadratic_Equation
{
    class Quadratic_Equation
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double discriminant = b * b - 4 * a * c;

            if (discriminant < 0)
            {
                Console.WriteLine("no real roots");
            }
            else if (discriminant == 0)
            {
                double root = (-b) / (2 * a);
                Console.WriteLine("{0:f2}", root);
            }
            else
            {
                double firstRoot = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double secondRoot = (-b - Math.Sqrt(discriminant)) / (2 * a);
                if (firstRoot > secondRoot)
                {
                    Console.WriteLine("{0:f2}", secondRoot);
                    Console.WriteLine("{0:f2}", firstRoot);
                }
                else
                {
                    Console.WriteLine("{0:f2}", firstRoot);
                    Console.WriteLine("{0:f2}", secondRoot);
                }
            }
        }
    }
}
