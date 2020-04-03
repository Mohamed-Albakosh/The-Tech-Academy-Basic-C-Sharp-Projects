using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_test
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = new string[4];
            firstArray[0] = "Dog";
            firstArray[1] = "Cat";
            firstArray[2] = "bird";
            firstArray[3] = "bees";
            Console.WriteLine("Enter one of these index [0] [1] [2] [3] ?");
            int indx = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine(" index ["+indx+"]="+firstArray[indx]);
            Console.ReadLine();
            int[] intArray = new int[] {12,2,9,100 };
            Console.WriteLine("Enter one of these index [0] [1] [2] [3] ?");
            int indx1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" index [" + indx1 + "]=" + intArray[indx1]);
            Console.ReadLine();

            List<int> intList = new List<int>();
            intList.Add(4);
            intList.Add(50);
            intList.Add(10);
            intList.Add(80);
            Console.WriteLine("Enter one of these index [0] [1] [2] [3] ?");
            int indx2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" index [" + indx2 + "]=" + intList[indx2]);
            Console.ReadLine();
        }
    }
}
