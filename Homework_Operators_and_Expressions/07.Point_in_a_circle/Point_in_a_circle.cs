using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Point_in_a_circle
{
    class Point_in_a_circle
    {
        static void Main(string[] args)
        {
            int radius = 2;
            int xCenter = 0;
            int yCenter = 0;
            double xCoordinate = double.Parse(Console.ReadLine());
            double yCoordinate = double.Parse(Console.ReadLine());
            double distance = Math.Abs(Math.Sqrt(Math.Pow(xCoordinate, 2) + Math.Pow(yCoordinate, 2)) - radius + 2);
            if ((Math.Pow(xCoordinate - xCenter, 2) + Math.Pow(yCoordinate - yCenter, 2)) <= Math.Pow(radius, 2))
            {
                Console.WriteLine("yes {0:f2}", distance);
            }
            else
            {
                Console.WriteLine("no {0:f2}", distance);
            }
        }
    }
}
