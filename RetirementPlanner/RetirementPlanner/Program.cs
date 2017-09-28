using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetirementPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable declarations for the input and calculations 
            string inputAge;
            decimal age;
            decimal oldAge = 65;
            decimal difference;
            Console.WriteLine("Please enter yout age in whole years");
            inputAge = Console.ReadLine();
            //inputAge = Console.ReadLine();
            //now we need to call a methot to conver from one datatype to another
            //as we cant subtract a number from a string.
            //Convert lile console is a library of functions within the System Library
            //and this is age different type of comment syntax
            age = Convert.ToDecimal(inputAge);
            //with these numbers we can do maths
            difference = oldAge - age;
            //we cloud have buil the message to show the user ourselves
            // or we can use this alternative syntax
            Console.WriteLine("In {0} years you will be 65 years old", difference);
            //wait for the yser to hit enter
            Console.ReadLine();


        }
    }
}
