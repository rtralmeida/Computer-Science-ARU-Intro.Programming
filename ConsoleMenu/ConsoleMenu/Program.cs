using System;

namespace ConsoleMenu
{
    class Program
    {
        static void Main(string[] args)
        {

            string userResponse = "";
            int userChoice, numTrys = 0;
            bool exitProgram = false;

            do
            {

                Console.WriteLine("Program menu: Please select one of the following options");
                Console.WriteLine("1) Distance in miles");
                Console.WriteLine("2) Distance in Kilometres");
                Console.WriteLine("3) Distance in astromical units");
                Console.WriteLine("0) Exit Program");


                userResponse = Console.ReadLine();
                userChoice = Int32.Parse(userResponse);



                switch (userChoice)
                {
                    case 1:
                        Console.WriteLine("We will work in miles");
                        break;
                    case 2:
                        Console.WriteLine("We will work in kilometers");
                        break;
                    case 3:
                        Console.WriteLine("We will work in AU");
                        break;
                    case 0:
                        Console.WriteLine("Exit Program");
                        exitProgram = true;
                        break;
                    default:
                        ++numTrys;
                        Console.WriteLine("You did not enter a valid response, please enter 1, 2 or 3");
                        Console.WriteLine("You have {0} more changes to enter a correct answer", 3 - numTrys);
                        break;
                }

            } while (numTrys < 3 && !exitProgram);


            Console.ReadLine();


        }

    }
}
