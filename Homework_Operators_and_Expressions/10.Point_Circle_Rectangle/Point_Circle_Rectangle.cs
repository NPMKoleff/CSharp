using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Point_Circle_Rectangle
{
    class Point_Circle_Rectangle
    {
        static void Main(string[] args)
        {
            double radius = 1.5;
            double xCenter = 1;
            double yCenter = 1;
            double xCoordinate = double.Parse(Console.ReadLine());
            double yCoordinate = double.Parse(Console.ReadLine());
            bool isInsideCircle = false;
            bool isInsideRectangle = false;
            if ((Math.Pow(xCoordinate - xCenter, 2) + Math.Pow(yCoordinate - yCenter, 2)) <= Math.Pow(radius, 2))
            {
                isInsideCircle = true;
            }
            if ((xCoordinate >= -1 && xCoordinate <= 5) && (yCoordinate >= -1 && yCoordinate <= 1))
            {
                isInsideRectangle = true;
            }
            if (isInsideCircle == true && isInsideRectangle == true)
            {
                Console.WriteLine("inside circle inside rectangle");
            }
            else if (isInsideCircle == false && isInsideRectangle == true)
            {
                Console.WriteLine("outside circle inside rectangle");
            }
            else if (isInsideCircle == true && isInsideRectangle == false)
            {
                Console.WriteLine("inside circle outside rectangle");
            }
            else if (isInsideCircle == false && isInsideRectangle == false)
            {
                Console.WriteLine("outside circle outside rectangle");
            }
        }
    }
}
