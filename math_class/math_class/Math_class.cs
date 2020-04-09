using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math_class
{
    public class Math_class
    {
        public Math_class()
        {
            Number = 0;
            Number_2 = 0;
            name = "";
            
        }
        public int Number { get; set; }
        public decimal Number_2 { get; set; }
        public string name { get; set; }
        public   int AddNumber(int num)
        {
            return Number=num + 2;
        }
        public  decimal AddNumber(decimal num_2)
        {
            return Number_2 = num_2 + 10;
        }
        public string AddNumber(string num_3)
        {
            return  num_3;
        }

    }
}
