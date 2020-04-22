using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Read_write_File
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Number:");
            string num=Console.ReadLine();
            File.WriteAllText(@"C:\Users\Mohamed\Desktop\C#\log.txt", num);
            int num1 =Convert.ToInt32( File.ReadAllText(@"C:\Users\Mohamed\Desktop\C#\log.txt"));
            Console.WriteLine(num1);
            Console.ReadLine();
        }
    }
}
