﻿using System;
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
              person.FirstName = "Sample";
              person.LastName = "Student";
                person.SayName();
            IQuittable iQ = new Employee();
            iQ.Quit("Quit the game ");
            
           
            Console.ReadLine();
        }
    }
}
