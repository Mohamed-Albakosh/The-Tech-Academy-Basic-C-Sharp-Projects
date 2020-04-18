using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_A
{
    class Program
    {
        static void Main(string[] args)
        {
            numberStruct num = new numberStruct();
            num.Amount = 8;
            Console.WriteLine(num.Amount);
            Console.ReadLine();
        }
    }
}
