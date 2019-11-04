using System;
using System.Timers;

namespace Personal_Project
{
    public class Events
    {
        public Events()
        {
            Timer myTimer = new Timer(2000);

            myTimer.Elapsed += MyTimer_Elapsed;
            myTimer.Elapsed += MyTimer_Elapsed1;


            myTimer.Start();

            Console.WriteLine("Press enter to remove the blue event.");
            Console.ReadLine();

            myTimer.Elapsed -= MyTimer_Elapsed1;
            Console.ReadLine();

        }
        private static void MyTimer_Elapsed1(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Elasped1: {0:HH:mm:ss.fff}", e.SignalTime);


        }

        private static void MyTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Elasped: {0:HH:mm:ss.fff}", e.SignalTime);


        }
    }


}
