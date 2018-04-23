using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomDickHarry
{
    class Program
    {
        public static string FileName = @"D:/test.txt";


        public static List<Person> persons = new List<Person>();

        static void Main(string[] args)
        {

            ReadFile();


            
            Console.WriteLine("firstname");
            string firstname = Console.ReadLine();

            Console.WriteLine("lastname");
            string lastname = Console.ReadLine();

            Console.WriteLine("jobtitle");
            string jobtitle = Console.ReadLine();



            Person newp = new Person();
            newp.FirstName = firstname;
            newp.LastName = lastname;
            newp.JobTitle = jobtitle;
            newp.savetoFile();

            Console.ReadLine();




        }

        public static void ReadFile()
        {
            try
            {
                StreamReader reader = new StreamReader(FileName);

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    string[] fields = line.Split(',');

                    Person p = new Person();
                    p.FirstName = fields[0];
                    p.LastName = fields[1];
                    p.JobTitle = fields[2];
                    persons.Add(p);
                }

                reader.Close();

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File {0} not found", FileName);
            }

            foreach (var ppl in persons)
            {
                Console.WriteLine(ppl.FirstName + "" + ppl.LastName + " is a" + ppl.JobTitle);
            }


            Console.ReadLine();

        }
    }
}
