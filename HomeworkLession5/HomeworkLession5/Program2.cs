using System;


namespace HomeworkLession5
{
    class Program2
    {
        static void Main(string[] args)
        {
            //Create new car
            Car car1 = new Car();
            //Show the info about the new car that i create
            Console.WriteLine("************STEP-1**************");
            Console.WriteLine(car1.GetDescription());
            //ask the user how much he want to speed his car?
            Console.WriteLine("How much kmh do you want speed the car?");
            car1.Speed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine($"~~~~Your speed is:{car1.Speed}-kmh ~~~~~\n");
            Console.ReadLine();
            // Show the info after the car slowdown by 2 kmh 
            car1.Speed -= 2;
            car1.SlowDown = 2;
            Console.WriteLine("************STEP-2**************");
            Console.ReadLine();
            Console.WriteLine($"You slow your speed by:{car1.SlowDown}-kmh\n");
            Console.WriteLine(car1.GetDescription());
            // Show the info 
            car1.Speed = 0;
            car1.SlowDown = 0;
            car1.Stop = true;
            Console.ReadLine();
            Console.WriteLine("************STEP-3**************");
            Console.WriteLine("You stop the car!!");
            Console.WriteLine(car1.GetDescription());
        }
    }
}
