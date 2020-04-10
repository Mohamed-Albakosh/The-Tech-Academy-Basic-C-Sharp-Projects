using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClass_3
{
   public class MathClass
    {
        public MathClass()
        {
            Number = 0;


        }
        public int Number { get; set; }

        public  void AddNumber(int FirstNumber, int SeconedNumber)
        {
            int total = 0;
            total = FirstNumber + SeconedNumber;
            Console.WriteLine(total);
        }
    }
}
