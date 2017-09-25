using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessCard
{
    class BusinessCard
    {
        static string name = "Rui", phone = "912", occupation = "stud";
        static void Main(string[] args)
        {
            BusinessCard.Print(name, phone, occupation);

            Console.WriteLine("Name:");
            name = Console.ReadLine();
            Console.WriteLine("phone:");

            phone = Console.ReadLine();
            Console.WriteLine("occupation:");

            occupation = Console.ReadLine();
            BusinessCard.Print(name, phone, occupation);
            Console.ReadKey();

        }
        public static void Print(string name, string phone, string occupation)
        {
            Console.WriteLine(name + "\n" + phone + "\n" + occupation + "\n\n\n");

        }
    }
}
