using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClass_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter first number:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter second number:");
            int num_2 = Convert.ToInt32(Console.ReadLine());
            MathClass math = new MathClass();
            math.AddNumber(num,num_2);
            math.AddNumber(FirstNumber: num, SeconedNumber: num_2);


            Console.ReadLine();
        }
    }
}
