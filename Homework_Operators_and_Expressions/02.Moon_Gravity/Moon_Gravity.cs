using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Moon_Gravity
{
    class Moon_Gravity
    {
        static void Main(string[] args)
        {
            double weight = double.Parse(Console.ReadLine());
            double weightOnTheMoon = weight * 0.17;
            Console.WriteLine("{0:f3}", weightOnTheMoon);
        }
    }
}
