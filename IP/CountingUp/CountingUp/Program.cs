using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingUp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable to store our total number
            double total = 1.0f;
            Console.WriteLine("Total currently {0}", total);
            total += 2;
            Console.WriteLine("Total now: {0}", total);
            total += 1;
            Console.WriteLine("Total changed to: {0}", total);
            //shorthand from of addition (equivalents for */ and -)
            total += 3;
            Console.WriteLine("Total finally : {0}", total);
            //readline to stop cosing before we can read results
            Console.ReadKey();

        }
    }
}
