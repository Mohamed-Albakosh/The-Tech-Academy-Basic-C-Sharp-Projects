using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_class
{
    class MathClass
    {
        public MathClass()
        {
            Number = 0;
        }
        public int Number { get; set; }

        public int AddNumber()
        {
            return Number = Number + 2;
        }
        public int mult_Number()
        {
            return Number = Number * 2;
        }
        public int D_Number()
        {
            return Number = Number ^ 2;
        }
    }
}
