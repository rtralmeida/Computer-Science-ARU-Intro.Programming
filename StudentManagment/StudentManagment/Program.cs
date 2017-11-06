using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagment
{
    class Program
    {
        static void Main(string[] args)
        {
            int userChoice;
            const int MAX_STUDENTS = 100;

            string[] studentNames = new string[MAX_STUDENTS];
            float[] studentMarks = new float[MAX_STUDENTS];
            for (int index = 0; index < MAX_STUDENTS; index++)
            {
                studentNames[index] = "EMPTY";
                studentMarks[index] = -1;

            }

            do
            {
                Console.Clear();
                Console.WriteLine("1 - View Students");
                Console.WriteLine("2 - add Student");
                Console.WriteLine("3 - edit Students");
                Console.WriteLine("4 - delete Students");
                Console.WriteLine("5 - exit");
                Console.Write("Please pick one");
                Int32.TryParse(Console.ReadLine(), out userChoice);



                switch (userChoice)
                {
                    case 1:
                        Console.WriteLine("Displaying student Data:");
                        Console.WriteLine("Number | Name | Mark");
                        for (int index = 0; index < MAX_STUDENTS; index++)
                        {
                            Console.WriteLine("{0} - {1} -> {2} Marks", index + 1, studentNames[index], studentMarks[index]);
                        }

                        break;

                    case 2:
                        int freeSpacePosition = 0;
                        for (; freeSpacePosition < MAX_STUDENTS; freeSpacePosition++)
                        {
                            if (studentNames[freeSpacePosition] == "EMPTY")
                            {

                            }


                        }
                        if (freeSpacePosition < MAX_STUDENTS)
                        {
                            Console.WriteLine("Student name:");
                            studentNames[freeSpacePosition] = Console.ReadLine();
                            Console.WriteLine("Student mark:");
                            studentMarks[freeSpacePosition] = Convert.ToSingle(Console.ReadLine());

                        }
                        Console.WriteLine("Create new student:");
                        Console.ReadLine();


                        break;

                    case 3:

                        for (int index = 0; index < MAX_STUDENTS; index++)
                        {
                            Console.WriteLine("{0} - {1} -> {2} Marks", index + 1, studentNames[index], studentMarks[index]);
                        }

                        int editPosition;

                        do
                        {
                            Console.Write("What student you want to edit");
                            editPosition = Convert.ToInt32(Console.ReadLine()) - 1;

                        } while (editPosition < 0 || editPosition >= MAX_STUDENTS);

                        Console.WriteLine("Student name:");
                        studentNames[editPosition] = Console.ReadLine();
                        Console.WriteLine("Student mark:");
                        studentMarks[editPosition] = Convert.ToSingle(Console.ReadLine());


                        break;

                    case 4:

                        for (int index = 0; index < MAX_STUDENTS; index++)
                        {
                            Console.WriteLine("{0} - {1} -> {2} Marks", index + 1, studentNames[index], studentMarks[index]);
                        }

                        int deletePosition;

                        do
                        {
                            Console.Write("What student you want to delete");
                            deletePosition = Convert.ToInt32(Console.ReadLine()) - 1;

                        } while (deletePosition < 0 || deletePosition >= MAX_STUDENTS);



                        Console.WriteLine("Are you sure? YES/NO");
                        string confirmation = Console.ReadLine().ToLower();
                        if (confirmation=="y")
                        {
                            studentNames[deletePosition] = "EMPTY";
                            studentMarks[deletePosition] = -1;

                        }
                        else
                        {
                            Console.WriteLine("No changes were made");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Bye Bye");
                        Console.ReadLine();

                        break;

                    default:
                        break;

                }
            } while (userChoice != 5);


        }
    }
}
