using System;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNum;
            do
            {
                Console.WriteLine("Insira um numero");

            } while (!Int32.TryParse(Console.ReadLine(), out userNum));


            Console.WriteLine("The factorial is:{0}", RecursiveFactorial(userNum));
            Console.ReadLine();

        }


        static int RecursiveFactorial(int value)
        {
            if (value == 1)
            {
                return value;

            }
            else
            {
                Console.WriteLine("factorial" + RecursiveFactorial(value - 1));
                return value * RecursiveFactorial(value - 1);

            }

        }
    }
}
