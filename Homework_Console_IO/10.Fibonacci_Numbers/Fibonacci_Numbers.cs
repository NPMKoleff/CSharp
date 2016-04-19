using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Fibonacci_Numbers
{
    class Fibonacci_Numbers
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            if (numberOfLines == 1)
            {
                Console.WriteLine(0);
            }
            else
            {
                long n = 0;
                long m = 1;
                long p = 1;
                Console.Write("{0}", n);
                Console.Write(", {0}", m);

                for (int i = 2; i < numberOfLines; i++)
                {
                    p = n + m;
                    Console.Write(", {0}", p);
                    n = m;
                    m = p;
                }
                Console.WriteLine();
            }
        }
    }
}
