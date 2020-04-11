using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Employee: Person, IQuittable
    {
        public int ID { get; set; }
        public override void SayName()
        {
            Console.WriteLine("Name:[" + FirstName + " " + LastName + "]");

        }
        public static bool operator== (Employee  id_1,Employee id_2)
        {
            if (id_1.ID == id_2.ID)
            {
                return true;
            }
            else
            {
                return false;
            }
            
                
         
        }
        public static bool operator !=(Employee id_1, Employee id_2)
        {

            if (id_1.ID != id_2.ID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Quit(string name)
        {
            Console.WriteLine(" ["+name+"]");
        }
    }
}
