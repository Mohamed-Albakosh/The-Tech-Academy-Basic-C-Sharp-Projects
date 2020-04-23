using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constant
{
    public class conClass
    {
        public conClass(string name): this(name,10,"USA")
        { }
        public conClass( string name,int ag,string con)
        {
            Name = name;
            Age = ag;
            Contry = con;
          
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Contry { get; set; }
    }
}
