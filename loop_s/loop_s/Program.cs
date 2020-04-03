using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_s
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            bool isday = true;
            while (isday)
            {
                Console.WriteLine(" inter your a day:");
                string day = Console.ReadLine();
                switch (day)
                {
                    case "monday":
                        Console.WriteLine(" Monday is not holiday! ");
                        break;
                    case "tuesday":
                        Console.WriteLine(" Monday is not holiday! ");
                        break;
                    case "thursday":
                        Console.WriteLine(" thursday is not holady! ");
                        break;
                    case "friday":
                        Console.WriteLine(" friday is not holady! ");
                        break;
                    case "saturday":
                        Console.WriteLine(" saturday is a holady! ");
                        isday = false;
                        break;
                    case "sunday":
                        Console.WriteLine(" Monday is a holady! ");
                        isday = false;
                        break;
                }
                Console.Read();

            }
            bool isnumber = true;
            
            double result = 0;
            do 
            {
                Console.WriteLine(" inter your a number:");
                int num = Convert.ToInt32(Console.ReadLine());
                
                result = num % 2;
                if (result == 0)
                {
                    Console.WriteLine(" The  number is Even");
                }
                else
                {
                    Console.WriteLine(" The  number is Odd");
                    isnumber = false;
                }

            }
            while (isnumber);
            Console.Read();

        }
    }
}
