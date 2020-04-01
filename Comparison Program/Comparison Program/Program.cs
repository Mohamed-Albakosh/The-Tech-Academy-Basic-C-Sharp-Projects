using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparison_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Person 1");
            Console.WriteLine(" inter Hourly Rate:");
            int  hourly  = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(hourly);
            Console.WriteLine(" Hours worked per week");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine( hours);
            Console.ReadLine();

            Console.WriteLine(" Person 2");
            Console.WriteLine(" inter Hourly Rate:");
            int hourly_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(hourly_2);
            Console.WriteLine(" Hours worked per week");
            int hours_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(hours_2);
            Console.ReadLine();
            Console.WriteLine(" Annual salary Person 1");
            int annual_1 = hourly * hours;
            Console.WriteLine(annual_1);
            Console.ReadLine();
            Console.WriteLine(" Annual salary Person 2");
            int annual_2 = hourly_2 * hours_2;
            Console.WriteLine(annual_2);
            Console.ReadLine();
            Console.WriteLine(" Does Person 1 make more money than Person 2?");
            bool annual_money = annual_1 > annual_2;
            Console.WriteLine(annual_money);
            Console.ReadLine();

        }
    }
}
