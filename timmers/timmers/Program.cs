using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading;

namespace timmers
{
    class Program
    {
        private static Timer aTimer;
        
        public static void Main()
        {
            // Create a timer and set a two second interval.
            aTimer = new Timer(null, null, 0, 1500);

            // Hook up the Elapsed event for the timer. 

            // Have the timer fire repeated events (true is the default)
            aTimer.AutoReset = true;

            // Start the timer
            aTimer.Enabled = true;

            Console.WriteLine("Press the Enter key to exit the program at any time... ");
            Console.ReadLine();
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0:hh:mm:ss:fff}", e.SignalTime);
        }

    }
}
