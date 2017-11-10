using System;
using System.Collections.Generic;

namespace TemperatureConversion
{


    class Program
    {
        // Create a dictionary that contains all menu option
        // You only need to add another item and create the desired method
        public static Dictionary<string, Func<float, float>> Menu = new Dictionary<string, Func<float, float>>
            {
                { "K", Kelvin },
                { "C", Celsius },
                { "F", Fahrenheit },
                { "E", Exit },
            };


        static void ShowMethods(Type type)
        {
            foreach (var method in type.GetMethods())
            {
                //var parameters = method.GetParameters();
                //var parameterDescriptions = string.Join
                //    (", ", method.GetParameters()
                //                 .Select(x => x.ParameterType + " " + x.Name)
                //                 .ToArray());

                Console.WriteLine("{0} {1})",
                                  method.ReturnType,
                                  method.Name);
            }
            Console.ReadLine();

        }

        public static void Main(string[] args)
        {

            ShowMethods(typeof(Program));


            float degrees;
            //Print all menu options
            string userChoice = DisplayMainMenu();




            Console.WriteLine(DisplayMainMenu() + "ola");
            Console.WriteLine("");



            //typeof(MyType).GetMethod("add").Invoke(null, new[] { arg1, arg2 })


            //Program program = new Program();
            //MethodInfo method = typeof(Program).GetMethod(Menu[userChoice]);
            //method.Invoke(program, new Object[] { degrees });
            //Console.ReadLine();




            do
            {
                Console.WriteLine("Please enter the value that you want to convert");

            } while (!float.TryParse(Console.ReadLine(), out degrees));




        }

        static public string DisplayMainMenu()
        {
            string userChoice;

            do
            {
                Console.Clear();
                Console.WriteLine("Please Choose your selection");

                //loops and Prints each menu option
                //foreach (KeyValuePair<string, string> pair in Menu)
                //{
                //    Console.WriteLine(pair.Key + " - " + pair.Value);
                //}

                userChoice = Console.ReadLine().ToUpper();
            }
            while (!Menu.ContainsKey(userChoice));


            return userChoice;

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


        public static float Exit(float temp)
        {
            Console.WriteLine("bye bye");
            Console.ReadKey();
            Environment.Exit(0);
            return 0;


        }

    }
}