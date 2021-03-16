using System;

namespace KeepScreenAlive
{
    class Program
    {
        static void Main(string[] args)
        {
            var time = new TimeSpan(0, 30, 0);
            var startTime = DateTime.Now;
            Console.WriteLine($"Process started at {startTime}");

            var shouldContinue = true;
            while (shouldContinue)
            {
                var currentTime = DateTime.Now;
                shouldContinue = currentTime - startTime > time ? false : true;
                Console.WriteLine($"Keeping alive at {currentTime}");
            }

            Console.WriteLine("Process Exited \t Press enter to exit");
            Console.ReadLine();
        }
    }
}
