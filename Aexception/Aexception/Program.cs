using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aexception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter your Age:");
                var age = Convert.ToInt32(Console.ReadLine());
                if (age <= 0)
                {
                    throw new ArgumentException("Age cannot be negative or zreo");
                    
                }
                else
                {
                    Console.WriteLine("Your Age is:"+age);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadLine();
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
