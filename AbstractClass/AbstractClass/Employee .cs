using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Employee: Person, IQuittable
    {

        public override void SayName()
        {
            Console.Write("Name:[" + FirstName + " " + LastName + "]");

        }
        public void Quit(string name)
        {
            Console.Write(" ["+name+"]");
        }
    }
}
