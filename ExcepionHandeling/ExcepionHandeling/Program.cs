using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepionHandeling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> list_number = new List<int> { 8, 10, 6, 9, 4 };
                Console.Write("Enter divided number:");
                int divid_num = Convert.ToInt32(Console.ReadLine());
                foreach (int num in list_number)
                {
                    int D_number = num / divid_num;
                    Console.WriteLine(D_number);

                }
                Console.ReadLine();
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Please type a whole number.");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
