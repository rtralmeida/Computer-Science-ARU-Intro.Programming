using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassExercise
{
    class Program
    {
        static void Main(string[] args)
        {


            float[] salesData = {
                343.34f,3463.34f,343.34f,343.34f,343.34f,343.34f,
                353.34f,353.34f,353.34f,7353.34f,353.34f,35883.34f,
                343.34f,343.34f,343.34f,343.34f,343.34f,343.34f,
                853.34f,353.34f,353.34f,373.34f,353.34f,373.34f,
            };



            //float[] salesData;
            //salesData = new float[] { … 24 numbers in here …};

            for (int index = 0; index < 12; index++)
            {
                Console.WriteLine("Month " + (index + 1));
                float result = salesData[index + 12] - salesData[index];
                if (result > 0)
                    Console.WriteLine("Sales up by " + result.ToString("0.00"));
                else
                    Console.WriteLine("Sales fell by " + result.ToString("#,##0.00"));
            }

            //Pause so we can see results;
            Console.ReadLine();


        }
    }
}
