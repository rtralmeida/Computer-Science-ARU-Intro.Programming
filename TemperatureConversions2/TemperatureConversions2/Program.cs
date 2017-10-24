using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConversion
{


    class Program
    {



        public static void Main(string[] args)
        {
            Program p = new Program();
            p.DisplayMainMenu();


        }

        public void DisplayMainMenu()
        {
            float temp;
            string userChoice;
            bool valid;


            Dictionary<string, string> dictMenu = new Dictionary<string, string>
            {

                { "K", "Kelvin()" },
                { "C", "Celsius()" },
                { "F", "Fahrenheit()" },
                { "e", "Exit()" }

            };



            do
            {

                Console.Clear();
                Console.WriteLine("Please Choose your selection");

                foreach (KeyValuePair<string, string> pair in dictMenu)
                {
                    Console.WriteLine(pair.Key + " - " + pair.Value);
                }

                userChoice = (Console.ReadLine()).ToUpper();

            }
            while (!dictMenu.ContainsKey(userChoice));



            Console.WriteLine("Please enter the value that you want to convert");

            while (!float.TryParse(Console.ReadLine(), out temp))
            {
                Console.Clear();

                Console.WriteLine("Try again, press any key to try again");

                Console.Clear();
                Console.WriteLine("Please enter the value that you want to convert");

            }


            Program program = new Program();

            MethodInfo method = typeof(Program).GetMethod("Kelvin");

            method.Invoke(program, new Object[] { temp });

            Console.ReadLine();
        }



        public static float Kelvin(float temp)
        {

            Console.WriteLine("{0}º Kelvin is {1} Fahrenheit", temp, ((temp * 9) / 5) - 459.67);
            Console.WriteLine("{0}º Kelvin is {1} Celsius", temp, (temp - 273.15));

            return 0;

        }


        public static float Celsius(float temp)

        {

            Console.WriteLine("{0}º Celsius is {1} Fahrenheit", temp, (temp * 1.8) + 32);
            Console.WriteLine("{0}º Celsius is {1} Kelvin", temp, temp + 273);

            return 0;

        }


        public static float Fahrenheit(float temp)
        {

            Console.WriteLine("{0}º Fahrenheit is {1} Celcius ", temp, (temp - 32) / 1.8);
            Console.WriteLine("{0}º Fahrenheit is {1} Kelvin", temp, (5 / 9 * (temp - 32) + 273));

            return 0;

        }

    }
}