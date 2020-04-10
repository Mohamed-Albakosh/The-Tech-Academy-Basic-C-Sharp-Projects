using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Class_2
{
    class MathClass
    {
        public MathClass()
        {
            Number = 0;
           

        }
        public int Number { get; set; }
        
        public int AddNumber(int num_1,int num_2=0)
        {
           int  total = 0;
             total = num_1 + num_2;
            return total;
        }
        

    }
}
