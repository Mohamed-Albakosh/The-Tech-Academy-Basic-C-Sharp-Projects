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
            Console.WriteLine("enter the number:");
            math.Number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(math.AddNumber());
            Console.WriteLine(math.mult_Number());
            Console.WriteLine(math.D_Number());
            Console.ReadLine();
        }
    }
}
