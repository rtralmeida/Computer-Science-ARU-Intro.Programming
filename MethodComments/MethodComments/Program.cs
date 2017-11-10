using System;

namespace GeometryCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exitProgram = false;
            int userChoice;

            float side1, side2, hypotenuse;

            while (!exitProgram)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("1- Box Calculation");
                    Console.WriteLine("2- Check triangle right-angle");
                    Console.WriteLine("3- Exit Program");
                    Console.Write("Please select what calculations do you want to do:");

                } while (!int.TryParse(Console.ReadLine(), out userChoice) || userChoice < 1 || userChoice > 3);


                switch (userChoice)
                {
                    case 1:
                        float width, height, depth;


                        Console.WriteLine("Calculation of an Rectuangular box");

                        do
                        {
                            Console.Write("Insert with");

                        } while ((!float.TryParse(Console.ReadLine(), out width)) || (width < 0));


                        do
                        {
                            Console.Write("Insert Height");
                        } while (!float.TryParse(Console.ReadLine(), out height) || height < 0);


                        do
                        {
                            Console.Write("Insert depth");
                        } while (!float.TryParse(Console.ReadLine(), out depth) || depth < 0);


                        Console.WriteLine("The volume is:{0} unit^3", VolumeCalculation(width, height, depth));
                        break;
                    case 2:

                        Console.WriteLine("Check if triangle is righ-angle");

                        do
                        {
                            Console.Write("Insert one of the sides");

                        } while ((!float.TryParse(Console.ReadLine(), out side1)) || (side1 < 0));

                        do
                        {
                            Console.Write("Insert the other side");

                        } while ((!float.TryParse(Console.ReadLine(), out side2)) || (side2 < 0));

                        do
                        {
                            Console.Write("Insert the hypotenuse");

                        } while ((!float.TryParse(Console.ReadLine(), out hypotenuse)) || (hypotenuse < 0));


                        if (TriangleCalculation(side1, side2, hypotenuse))
                        {
                            Console.WriteLine("This is an righ-angled triangle");

                        }
                        else
                        {
                            Console.WriteLine("This is NOT an righ-angled triangle");


                        }
                        break;
                    default:
                        Console.WriteLine("Godbye ");
                        exitProgram = true;
                        break;
                }
                Console.ReadKey();
            }


        }
        /// <summary>
        /// This check if a triangle is right angled or not
        /// applying the pitagoras teorem we can check if the square hypotenuse is equal to the sum of each square sides
        /// </summary>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        /// <param name="hypotenuse"></param>
        /// <returns></returns>

        public static bool TriangleCalculation(float side1, float side2, float hypotenuse)
        {
            // Use of inline if 
            //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator

            return (Math.Pow(hypotenuse, 2) == Math.Pow(side1, 2) + Math.Pow(side2, 2)) ? true : false;

        }
        /// <summary>
        /// Calculate the volume of a retangular box
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="depth"></param>
        /// <returns></returns>

        public static float VolumeCalculation(float width, float height, float depth)
        {

            return width * height * depth;

        }
    }
}
