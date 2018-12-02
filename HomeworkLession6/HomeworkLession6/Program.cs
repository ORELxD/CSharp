using System;


namespace HomeworkLession6
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.5.1
            Clock myClock = new Clock(0,0,30,15);
            //1.5.2
            Console.WriteLine(myClock.show());
            Console.Read();  
            //1.5.3
            myClock.Miliseconds += 2;
            Console.Read();
            //1.5.4
            Console.WriteLine(myClock.show());
            //1.5.5
            Console.Read();
            myClock.setMidDay();
            //1.5.6
            myClock.Miliseconds += 3;
            //1.5.7
            Console.Read();
            Console.WriteLine(myClock.show());
            Console.Read();
            //1.5.8
            Clock YourClock = new Clock();
            //1.5.9
            YourClock.setMidNight();
            //1.5.10
            Console.WriteLine(YourClock.show());
            Console.WriteLine(" ");
        }
    }
}
