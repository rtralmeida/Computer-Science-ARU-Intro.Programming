using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappinessMeter
{
    class Program
    {
        static void Main(string[] args)
        {


            int happiness = 0;

            Console.WriteLine("Please tell us ow happy you are felling on a scale of 1 to 5 ");
            happiness = Convert.ToInt32(Console.ReadLine());

            switch (happiness)
            {
                case 1:
                    Console.WriteLine("i'm very sorry to hear that , there is a confidential counselling service" + " in Student services, or you could talk to your persona tutor.");
                    break;

                case 2:
                    Console.WriteLine("im sorry to hear that, have you considered retail therapy");
                    break;

                case 3:
                    Console.WriteLine("Think of puppies and kittens");
                    break;

                case 4:
                    Console.WriteLine("Go out and share their happiness with others");
                    break;

                case 5:
                    Console.WriteLine("they have reached a place of serenity and need do nothing to risk changing that");
                    break;

                default:
                    break;
            }
            Console.ReadLine();

        }
    }
}
