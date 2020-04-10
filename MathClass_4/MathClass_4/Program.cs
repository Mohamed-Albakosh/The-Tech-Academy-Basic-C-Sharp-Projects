using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClass_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the number:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the  number:");
            double num_2 = Convert.ToDouble(Console.ReadLine());

            // MathClass math = new MathClass();
            // math.AddNumber(num);
            MathClass.AddNumber(num);
           Console.WriteLine( MathClass.AddNumber(num_2));


            Console.ReadLine();
        }
    }
}
