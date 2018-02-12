using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCopier
{


    class MainClass
    {
        public static void ChangeMyInt(int value)
        {
            value += 10;

        }

        public static void ChangeMyInt(ref int value)
        {
            value += 10;
        }
        public static void ChangeMyInt(ref int refValue, int value)
        {
            refValue = value;
        }

        public static void Main(string[] args)
        {
            int myInt = 5;

            ChangeMyInt(myInt);
            Console.WriteLine("'myvalue' contents afer passing to method by VALUE {0}", myInt);


            ChangeMyInt(ref myInt);
            Console.WriteLine("'myvalue' contents afer passing to method by REFERNCE {0}", myInt);
            Console.WriteLine(" ");


            Console.WriteLine("Creating first Object based on MyObjectClassV1");
            MyObjectClassV1 objOne = new MyObjectClassV1();
            Console.WriteLine("Checking first Object Position property...{0}", objOne.Position);
            Console.WriteLine("modifying first Object 'position' property...");
            objOne.Position = 10;
            Console.WriteLine("new first object position property value is {0}", objOne.Position);
            Console.WriteLine("");



            Console.WriteLine("Creating second Object based on MyObjectClassV2");
            MyObjectClassV2 objTwo = new MyObjectClassV2();
            Console.WriteLine("Checking second Object Position property...{0}", objTwo.Position);
            Console.WriteLine("modifying second Object 'position' property...");
            objTwo.Position = 10;
            Console.WriteLine("new second object position property value is {0}", objTwo.Position);
            Console.WriteLine("");




            Console.WriteLine("Creating third Object based on MyObjectClassV3");
            MyObjectClassV3 objThree = new MyObjectClassV3();
            Console.WriteLine("Checking second Object Position property...{0}", objThree.Position);
            Console.WriteLine("modifying third Object 'position' property...");
            objThree.Position = 10;
            Console.WriteLine("new third object position property value is {0}", objThree.Position);


            Console.WriteLine("#############################################");

            MyObjectClassV3 objThreeOne = new MyObjectClassV3();
            objThreeOne.Position = 34;
            Console.WriteLine("Value {0}", objThreeOne.Position);


            MyObjectClassV3 objThreeTwo = new MyObjectClassV3();
            objThreeTwo.Position = 68;
            Console.WriteLine("Value {0}", objThreeTwo.Position);


            Console.WriteLine("Question 1!!");
            Console.WriteLine("#############################################");
            Console.WriteLine("");

            ChangeMyInt(ref myInt, 6);
            Console.WriteLine(myInt);






            Console.WriteLine("Question 1!!");
            Console.WriteLine("#############################################");
            Console.WriteLine("");

            MyObjectClassV4 classFour = new MyObjectClassV4();
            classFour.IntProp = 4;
            Console.WriteLine("The value int of the prop is:{0}",classFour.IntProp);


            classFour.StringProp = "this is a string";
            Console.WriteLine("The string prop have this string in it: {0}",classFour.StringProp);
            Console.ReadLine();

        }

    }
}
