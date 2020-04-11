using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
              Employee person = new Employee();
                person.ID = 31;
              person.FirstName = "Sample";
              person.LastName = "Student";
                person.SayName();
            Employee person_2 = new Employee();
            person_2.ID = 41;
            person_2.FirstName = "Mohamed";
            person_2.LastName = "Student";
            person_2.SayName();
          if (  person == person_2)
            {
                Console.WriteLine(" they are equal");
            }
          else
            {
                Console.WriteLine(" they are not equal");
            }
           // IQuittable iQ = new Employee();
          //  iQ.Quit("Quit the game ");
            
           

            Console.ReadLine();
        }
    }
}
