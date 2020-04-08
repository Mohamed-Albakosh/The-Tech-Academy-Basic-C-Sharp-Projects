using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_assignmen2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter how many Array elements:");
            int idx = Convert.ToInt32(Console.ReadLine());
            string[] StArray = new string[idx];
            for (int i = 0; i < StArray.Length; i++)
            {
                Console.Write("Element[" + i + "]:");
                string elem = Console.ReadLine();
                StArray[i] = elem;

            }
            for (int j = 0; j < StArray.Length; j++)
            {
                Console.WriteLine("Element[" + j + "]:" + StArray[j]);
            }

            int num = 0;
            while (num < 3)
            {

                Console.WriteLine(num);
                num++;
            }
            int num_1 = 0;
            Console.ReadLine();
            while (num_1 <= 3)
            {

                Console.WriteLine(num_1);
                num_1++;
            }

            List<string> s_list = new List<string>() { "Apple", "Dogs", "Moon", "Fish" };
            Console.Write("Search for:");
            string elem_2 = Console.ReadLine();
            string ser_f = " ";
            foreach (string score in s_list)
            {
                if (score == elem_2)
                {
                    ser_f = score;
                    break;
                }

            }
            if (ser_f != elem_2)
            {
                Console.WriteLine("The " + elem_2 + " is not in the list");
            }
            else
            {
                Console.WriteLine(elem_2);
            }
            string[] animal = new string[] { "Dog", "Cat", "Tigard", "elefant" };
            for (int index = 0; index < animal.Length; index++)
            {
                if (animal[index] == "Tigard")
                {
                    Console.Write("Element[" + index + "]: " + animal[index]);
                    Console.ReadLine();
                }

            }
            List<string> list_2 = new List<string>() { "Apple", "bird", "star", "Moon", "sun", "star" };
            List<string> match = new List<string>();
            List<int> Midx = new List<int>();
            Console.Write("select text to search for in the List:{Apple, bird,star,Moon, sun,star}:");
            string elem_3 = Console.ReadLine();
            int index_3 = 0;
            while (index_3 < list_2.Count)
            {
                if (list_2[index_3] == elem_3)
                {
                    match.Add(list_2[index_3]);
                    Midx.Add(index_3);

                }
                index_3++;
            }
            if (match.Count <= 0)
            {
                Console.WriteLine("The " + elem_3 + " is not in the list");
            }
            else
            {
                foreach (string item in match)
                {
                    Console.WriteLine(item);
                    
                }
                foreach (int item_2 in Midx)
                {
                    Console.WriteLine(item_2);

                }
                List<string> colors = new List<string>() { "white", "blue", "red", "black" ,"red"};
                List<string> colorsTemp = new List<string>();
                foreach (string color in colors)
                {
                    foreach (string element in colorsTemp)
                    {
                        if (color == element)
                        {
                            Console.WriteLine("The string " + color + " has appeared before");
                        }
                    }
                    colorsTemp.Add(color);
                }
               

                Console.ReadLine();

            }
        }
    }
}
