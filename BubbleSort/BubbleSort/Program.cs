using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]
            {
                10,80,1100,90,50,1,5,3,7,2,9
            };


            foreach (var n in numbers)

            {
                Console.WriteLine(n);
            }



            Console.WriteLine("-------------------------------------------");

            Console.ReadLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }


            }
            Console.ReadLine();

            foreach (var n in numbers)

            {
                Console.WriteLine(n);
            }
            Console.ReadLine();

        }
    }
}
