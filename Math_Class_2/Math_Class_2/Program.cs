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
            MathClass math = new MathClass();
            Console.Write("enter how many numbers chose (1 or 2):");
            int optn = Convert.ToInt32(Console.ReadLine());
            if (optn == 2)
            {
                Console.Write("enter first number:");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.Write("enter second number:");
                int num_2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(math.AddNumber(num, num_2));
                Console.ReadLine();
             }
            else
            {
                Console.Write("enter first number:");
                int num_3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("here we pass one number");
                Console.WriteLine(math.AddNumber(num_3));
                Console.ReadLine();
            }
        }
    }
}
