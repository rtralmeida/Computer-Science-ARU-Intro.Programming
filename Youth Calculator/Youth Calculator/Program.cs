using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Youth_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            string userAge, userName;
            int ageIan = 43;
            decimal ageDiff, ageInMonths;

            Console.WriteLine("What is your age?");
            userAge = Console.ReadLine();

            Console.WriteLine("What is your name?");
            userName = Console.ReadLine();

            ageDiff = (ageIan - Convert.ToInt32(userAge));
            Console.WriteLine("{0} are {1} younger than Ian", userName, ageDiff);


            ageInMonths = Convert.ToDecimal(ageDiff) * 12;
            Console.WriteLine("Or {0} month's old ",ageInMonths);
            Console.ReadLine();

            //4- Shows the negative number
            //5- I have no ideia what is "comparision age as well"???
            //
        }
    }
}
