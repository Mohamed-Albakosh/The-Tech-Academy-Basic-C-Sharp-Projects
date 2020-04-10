using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Class_2
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
            Console.WriteLine(math.AddNumber(num,num_2));
            Console.WriteLine("here we pass one number");
            Console.WriteLine(math.AddNumber(num));
            Console.ReadLine();
        }
    }
}
