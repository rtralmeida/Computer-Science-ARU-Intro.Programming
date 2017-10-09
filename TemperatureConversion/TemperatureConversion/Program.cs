using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string userAnswer = "";
            double temp;



            Console.WriteLine("Program menu: Please type the temprature in Celcius or Fahrenheit or Kelvin");
            userAnswer = Console.ReadLine();

            temp = Convert.ToDouble(userAnswer);




            Console.WriteLine("{0}º Celcius is {1} Fahrenheit", temp, (temp * 1.8) + 32);
            Console.WriteLine("{0}º Fahrenheit is {1} Celcius ", temp, (temp - 32) / 1.8);
            Console.WriteLine("{0}º Fahrenheit is {1} Kelvin", temp, (5 / 9 * (temp - 32) + 273));
            Console.WriteLine("{0}º Celcius is {1} Kelvin",temp,  temp + 273);

            Console.ReadLine();


        }

    }
}
