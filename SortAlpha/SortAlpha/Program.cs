using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlpha
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] fruits = new string[]

            { "Pear", "Blueberry", "Watermelon", "Pomegranate", "Carambola" };

            Console.WriteLine("underordered");
            foreach (var f in fruits)
            {
                Console.WriteLine(f + "\n");
            }


            Array.Sort(fruits);




            Console.WriteLine("Ordered");


            foreach (var f in fruits)
            {
                Console.WriteLine(f + "\n");
            }



            Console.ReadLine();

        }
    }
}
