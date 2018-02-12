using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDice
{
    class Program
    {
       static Random r = new Random();

        static void Main(string[] args)
        {

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(Generator());
            }

            Console.ReadKey();

        }

        public static int Generator() {

            return r.Next(1, 6);
        }
    }
}
