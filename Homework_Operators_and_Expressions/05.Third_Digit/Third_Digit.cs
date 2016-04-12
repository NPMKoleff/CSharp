using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Third_Digit
{
    class Third_Digit
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int numberChecked = (number / 100) % 10;
            switch (numberChecked)
            {
                case 0: Console.WriteLine("false 0"); break;
                case 1: Console.WriteLine("false 1"); break;
                case 2: Console.WriteLine("false 2"); break;
                case 3: Console.WriteLine("false 3"); break;
                case 4: Console.WriteLine("false 4"); break;
                case 5: Console.WriteLine("false 5"); break;
                case 6: Console.WriteLine("false 6"); break;
                case 7: Console.WriteLine("true"); break;
                case 8: Console.WriteLine("false 8"); break;
                case 9: Console.WriteLine("false 9"); break;

            }
        }
    }
}
