using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorSales
{
    class Program
    {
        static void Main(string[] args)
        {

            VectorClass vector = new VectorClass(5, 6);
            Console.WriteLine("Together:{0}", vector.AddThemTogether());


            Console.WriteLine("##########################################");
            Console.WriteLine("##########################################");


            VectorClass newVector = new VectorClass(7);
            Console.WriteLine("x:{0}", vector.x);
            Console.WriteLine("Y:{0}", vector.y);


            Console.WriteLine("The product of the X and Y pros is:{0}", vector.MultiplyValues());


            Console.WriteLine("##########################################");
            Console.WriteLine("DOT PRODUCT");


            VectorClass vectorAA = new VectorClass(2, 3);
            VectorClass vectorBB = new VectorClass(4, 5);

            Console.WriteLine((vectorAA.x * vectorBB.x) + (vectorAA.y * vectorBB.y));



            Console.WriteLine("##########################################");
            Console.WriteLine("Cross Prodduct");


            VectorClass vectorA = new VectorClass(2, 3, 4);
            VectorClass vectorB = new VectorClass(5, 6, 7);


            int cX = (vectorA.y * vectorB.z) - (vectorA.z * vectorB.y);
            int cY = (vectorA.z * vectorB.x) - (vectorA.x * vectorB.z);
            int cZ = (vectorA.x * vectorB.y) - (vectorA.y * vectorB.x);
            Console.WriteLine("Answer: a × b = ({0},{1},{2}) ", cX, cY, cZ);





            Console.ReadLine();
        }
    }
}
