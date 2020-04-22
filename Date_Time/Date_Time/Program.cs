using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.Write("What time will be after(Enter a number):");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(DateTime.Now.AddHours(num));
            Console.ReadLine();
        }
    }
}
