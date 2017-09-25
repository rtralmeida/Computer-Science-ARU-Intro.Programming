using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, course;
            string message;

            Console.WriteLine("Please enter your name");
            
            // Here we use readline to put string data into a variable;
            name = Console.ReadLine();

            //Ask the course name 
            Console.WriteLine("Please enter your course name");
            course = Console.ReadLine();

            //Construct a welcome message
            message = "Welcome... " + name + " To " + "Anglia Ruskin";
            message += " to the couse " + course;
            //write the message to the console
            Console.WriteLine(message);
            //here we use readline justo to 'pause' the program
            Console.ReadLine();

        }
    }
}
