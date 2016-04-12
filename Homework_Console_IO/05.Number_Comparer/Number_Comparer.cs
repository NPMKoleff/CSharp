using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Number_Comparer
{
    class Number_Comparer
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double biggerNumber = Math.Max(firstNumber, secondNumber);
            Console.WriteLine(biggerNumber);
        }
    }
}
