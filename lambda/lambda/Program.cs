using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employees> employee = new List<Employees>();
            Employees emp_1 = new Employees();
            emp_1.FirstName = "MOhamed";
            emp_1.LastName = "Albakosh";
            emp_1.ID = 1;
            employee.Add(emp_1);
            Employees emp_2 = new Employees();
            emp_2.FirstName = "Joe";
            emp_2.LastName = "mark";
            emp_2.ID = 2;
            employee.Add(emp_2);
            Employees emp_3 = new Employees();
            emp_3.FirstName = "Joe";
            emp_3.LastName = "martin";
            emp_3.ID = 3;
            employee.Add(emp_3);
            Employees emp_4 = new Employees();
            emp_4.FirstName = "peter";
            emp_4.LastName = "galber";
            emp_4.ID = 4;
            employee.Add(emp_4);
            Employees emp_5 = new Employees();
            emp_5.FirstName = "Adam";
            emp_5.LastName = "Sal";
            emp_5.ID = 5;
            employee.Add(emp_5);
            Employees emp_6 = new Employees();
            emp_6.FirstName = "Jassy";
            emp_6.LastName = "Tommas";
            emp_6.ID = 6;
            employee.Add(emp_6);
            Employees emp_7 = new Employees();
            emp_7.FirstName = "Jim";
            emp_7.LastName = "Ally";
            emp_7.ID = 7;
            employee.Add(emp_7);
            Employees emp_8 = new Employees();
            emp_8.FirstName = "jiff";
            emp_8.LastName = "Tommy";
            emp_8.ID = 8;
            employee.Add(emp_8);
            Employees emp_9 = new Employees();
            emp_9.FirstName = "Jassmin";
            emp_9.LastName = "Sam";
            emp_9.ID = 9;
            employee.Add(emp_9);
            Employees emp_10 = new Employees();
            emp_10.FirstName = "Kim";
            emp_10.LastName = "Tom";
            emp_10.ID = 10;
            employee.Add(emp_10);
            List<Employees> employee_Joe = new List<Employees>();
            foreach (var element in employee)
            {
               if (element.FirstName=="Joe")
                    {
                    employee_Joe.Add(element);
                    }
            }
            List<Employees> employee_Joe_2 =employee.Where(x=> x.FirstName=="Joe").ToList();
            List<Employees> employee_ID = employee.Where(x => x.ID > 5).ToList();
            foreach (var elem in employee_Joe_2)
            {
                Console.WriteLine(elem.ID+"  "+elem.FirstName+" "+elem.LastName);
            }
            foreach (var elem1 in employee_ID)
            {
                Console.WriteLine(elem1.ID + "  " + elem1.FirstName + " " + elem1.LastName);
            }
            Console.ReadLine();







        }
    }
}
