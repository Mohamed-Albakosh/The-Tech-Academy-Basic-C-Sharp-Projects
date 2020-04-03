using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_test
{
    class Program
    {
        static void Main(string[] args)
        {
            string str_1 = "Mohamed";
            string str_2 = "Sleman";
            string str_3= "Albakosh";
            string full_name = str_1 +" "+ str_2+" "+str_3 ;
            Console.WriteLine(full_name.ToUpper());
            Console.Read();

        }
    }
}
