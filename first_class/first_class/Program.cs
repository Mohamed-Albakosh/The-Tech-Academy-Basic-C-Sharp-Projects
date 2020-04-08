using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_class
{
    class Program
    {
        static void Main(string[] args)
        {
            MathClass math = new MathClass();
            Console.Write("enter the first number:");
            math.first_number = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the second number:");
            math.second_number = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the third number:");
            math.third_number = Convert.ToInt32(Console.ReadLine());
            int total = math.first_number + math.second_number + math.third_number;
            Console.WriteLine(total);
            Console.ReadLine();
        }
    }
}
