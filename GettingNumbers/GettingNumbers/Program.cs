using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable to hold a number
            decimal numberFromUser = 0m;
            string userImput = "";
            
            Console.WriteLine("please enter a number between 1 and 10. Then press Enter.");
            userImput = Console.ReadLine();

            // conver imput string into a int
            numberFromUser = Decimal.Parse(userImput);
            //add one to the number, prove we can
            numberFromUser++;
            Console.WriteLine("Result plus one is :{0}", numberFromUser);

            // Pause
            Console.ReadLine();

        }
    }
}
