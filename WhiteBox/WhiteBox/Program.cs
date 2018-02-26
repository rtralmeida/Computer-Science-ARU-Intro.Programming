//Author: Ian Brown
//SID: 7654321
//Edited: 05/10/14
using System;


namespace DistanceConverter
{
    class Program
    {
        enum distanceUnit
        {
            kilometre,
            mile,
            astronomicalUnit
        }

        const float KM_IN_MILE = 1.6f;
        const float AU_IN_MILE = 1f / 92955807.3f;

        static void Main(string[] args)
        {
            //variable declarations
            string userResponse = "";
            float distance = 0f;
            float conversionFactor = 1f;
            distanceUnit currentUnit, desiredUnit;

            Console.WriteLine("Distance Conversion Utility");
            Console.WriteLine("Please choose the units you are using to start with");

            currentUnit = DistanceMenu();

            Console.WriteLine("Please enter your current distance");
            userResponse = Console.ReadLine();
            distance = Convert.ToSingle(userResponse);

            Console.WriteLine("Please choose the units you wish to convert to");
            desiredUnit = DistanceMenu();

            switch (currentUnit)
            {
                case distanceUnit.mile:
                    conversionFactor = 1f;
                    break;
                case distanceUnit.kilometre:
                    conversionFactor = 1f / KM_IN_MILE;
                    break;
                case distanceUnit.astronomicalUnit:
                    conversionFactor = 1f / AU_IN_MILE;
                    break;
            }

            switch (desiredUnit)
            {
                case distanceUnit.mile:
                    conversionFactor *= 1f;
                    break;
                case distanceUnit.kilometre:
                    conversionFactor *= KM_IN_MILE;
                    break;
                case distanceUnit.astronomicalUnit:
                    conversionFactor *= AU_IN_MILE;
                    break;
            }

            Console.WriteLine("The converted value is {0}", conversionFactor * distance);
            Console.ReadLine();
        }

        private static distanceUnit DistanceMenu()
        {
            string userResponse;
            distanceUnit result = distanceUnit.kilometre;
            bool validResponse = true;
            do
            {
                //Assume a valid response

                //print a menu
                Console.WriteLine("Program Menu: Please select one of the following options");
                Console.WriteLine("M) Distance in miles");
                Console.WriteLine("K) Distance in kilometres");
                Console.WriteLine("A) Distance in astronomical units");
                userResponse = Console.ReadLine();

                //Process the user response a little to make it easier to match
                userResponse = userResponse.ToUpper();  //Makes it all upper case
                userResponse = userResponse.Trim(); //Takes off any spare spaces

                //Process user input for menu
                switch (userResponse)
                {
                    case "M":
                        result = distanceUnit.mile;
                        validResponse = true;
                        break;
                    case "K":
                        result = distanceUnit.kilometre;
                        validResponse = true;
                        break;
                    case "A":
                        result = distanceUnit.astronomicalUnit;
                        validResponse = true;
                        //More code can go here...
                        break;
                    default:
                        Console.WriteLine("You did not enter a valid response, please enter A, K or M");
                        validResponse = false;
                        break;
                }

            } while (!validResponse);
            return result;
        }
    }
}
