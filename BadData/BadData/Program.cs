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
            int numberFromUser = 0;
            string userInput = "";

            Console.WriteLine("please enter a number between 1 and 10. Then press Enter.");
            userInput = Console.ReadLine();

            // conver imput string into a int
            numberFromUser = Int32.Parse(userInput);


            if (Int32.TryParse(userInput, out numberFromUser))
            {
                numberFromUser++;
                Console.WriteLine("Result plus one is : {0}", numberFromUser);
            }
            else
            {
                Console.WriteLine("An erro occurred. Did you enter a number?");
            }

            // Pause
            Console.ReadLine();

        }
    }
}
