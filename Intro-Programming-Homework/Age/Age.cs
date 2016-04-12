using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age
{
    class Age
    {
        static void Main(string[] args)
        {
            DateTime birthday = Convert.ToDateTime(Console.ReadLine());
            DateTime timeNow = DateTime.Now;

            int age = timeNow.Year - birthday.Year;
            if ((timeNow.Month < birthday.Month) || (timeNow.Month == birthday.Month && timeNow.Day < birthday.Day))
            {
                age--;
            }
            Console.WriteLine(age);
            Console.WriteLine(age + 10);
        }
    }
}
