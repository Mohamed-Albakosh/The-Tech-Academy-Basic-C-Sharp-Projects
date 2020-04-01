using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" inter your number:");
            string num = Console.ReadLine();
            int number = Convert.ToInt32(num);
            int mul_num = number * 50;
            Console.WriteLine(mul_num);
            Console.ReadLine();
            Console.WriteLine(" inter your number:");
            string num_2 = Console.ReadLine();
            int number_2 = Convert.ToInt32(num_2);
            int add_num = number_2 + 25;
            Console.WriteLine(add_num);
            Console.ReadLine();

            Console.WriteLine(" inter your flout number:");
            string num_3 = Console.ReadLine();
            int numb_3=Convert.ToInt32(num_3);
            double D_num = Convert.ToDouble(numb_3) / 12.5;
            Console.WriteLine(D_num);
            Console.ReadLine();

            Console.WriteLine(" inter your number:");
            string num_4 = Console.ReadLine();
            int number_4 = Convert.ToInt32(num_4);
            bool B_num = number_4 < 50;
            Console.WriteLine(B_num);
            Console.ReadLine();

            Console.WriteLine(" inter your number:");
            string num_5 = Console.ReadLine();
            int number_5 = Convert.ToInt32(num_5);
            int R_num = number_5 % 7;
            Console.WriteLine(R_num);
            Console.ReadLine();

           
           
           
        }
    }
}
