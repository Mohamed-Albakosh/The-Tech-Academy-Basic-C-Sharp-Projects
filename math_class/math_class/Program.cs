using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math_class
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("enter int  number:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter decimal number:");
            decimal num_2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("enter the name:");
            string name = Console.ReadLine();


            Math_class math = new Math_class();
            
            
            Console.WriteLine(math.AddNumber(num));
            Console.WriteLine(math.AddNumber(num_2));
            Math_class nam = new Math_class();
            Console.WriteLine(nam.AddNumber(name));



            Console.ReadLine();
        }
    }
}
