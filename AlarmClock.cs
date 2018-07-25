using System;
using System.Timers;

namespace AlarmClock
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            
            Console.WriteLine("enter a number of seconds... ");
            number = Convert.ToInt32(Console.ReadLine());

            Timer aTimer = new Timer();
            aTimer.Interval = number * 1000;

            aTimer.Elapsed += OnTimedEvent;

            aTimer.Enabled = true;
            Console.ReadLine();
        }
        
        private static void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("The threshold was reached at {0}", e.SignalTime);
            Environment.Exit(0);
        }
    }
}
