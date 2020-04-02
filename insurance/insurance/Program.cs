using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insurance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" What is tour age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            Console.WriteLine("Have you ever had DUI?(True or False)");
            bool DUI = Convert.ToBoolean(Console.ReadLine());
            Console.ReadLine();
            Console.WriteLine(" How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());
            bool qualification = (age>15 && DUI==false && tickets<3);
            Console.WriteLine(" qualification? "+ qualification);
            Console.ReadLine();
        }
    }
}
