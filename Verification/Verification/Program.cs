using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verification
{
    class Program
    {

        static void Main(string[] args)
        {
            float square;

            float value;

            do
            {

                Console.WriteLine("Please insert a number:");
                if (float.TryParse(Console.ReadLine(), out value))
                {
                    continue;

                }

            }
            while ((value < 0) || (value < 100 || value > 1000));
            square = (float)Math.Sqrt(value);
            Console.WriteLine("Result:{0}", square);

            Console.WriteLine("Please enter a string ");
            string size = Console.ReadLine();
            if(size.Length == 7)
                Console.WriteLine("The string size is:{0}",size.Length);
            else
                Console.WriteLine("Wrong string size");

            Console.ReadLine();

        }
    }
}


//Task

//Create a console application to calculate the square root of a number provided by the user.Hint: The Math library contains a function to calculate a square root.
//Run the program and enter -1
//Note that the result is 'Not a number' or NaN
//Now modify the program so that the value the user entered is checked to see if it is valid(i.e. 0 or greater) before attempting the calculation.If the value is not valid, the program must ask the user again until they do enter a valid number.
//Run the program and enter -1 to check this validation takes place


//Questions
//How would you check that the number entered was in a certain range, say 100-1000?
//If the number was out of this range, how could you set it to the nearest valid number? Would it be wise to do so?
//How would you check that a string entered was the correct length, such as a 7 character SID?
