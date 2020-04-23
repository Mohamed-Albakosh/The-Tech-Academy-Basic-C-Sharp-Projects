using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constant
{
    class Program
    {
        static void Main(string[] args)
        {
            const string name = "Mohamed";
            Console.Write("enter the age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the Country:");
            var con = Console.ReadLine();
            conClass c_constant = new conClass(name,age,con);
            Console.WriteLine(c_constant.Name+" "+c_constant.Age+" "+c_constant.Contry);
            conClass c_constant_2 = new conClass(name);
            Console.WriteLine(c_constant_2.Name + " " + c_constant_2.Age + " " + c_constant_2.Contry);
            Console.ReadLine();
        }
    }
}
