using System;

namespace Class_Task_oop___events
{
    class Program
    {
        static void Main(string[] args)
        {
            Store Mystore = new Store();
            Mystore.ElecDevices[0] = new Computer(true,3000,1000,4,100);
            Mystore.ElecDevices[1] = new Computer(true,5000,1500,5,150);
            Mystore.ElecDevices[2] = new Computer(false,1500,1200,1,0);
            Mystore.ElecDevices[3] = new Phone("0544885581",true,1000,200,7,50);
            Mystore.ElecDevices[4] = new Phone("0544885582", true,6000,500,2,20);
            Mystore.ElecDevices[5] = new Phone("0544885583",true,1500,300,1,100);

            //First Buy
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("-----------Computers supply: ------------");
            Console.BackgroundColor = ConsoleColor.Black;
            Mystore.check(1);
            Console.WriteLine(Mystore.Buy(0));
            Console.ForegroundColor = ConsoleColor.Green;
            Mystore.ElecDevices[0].Charge += s => Console.WriteLine($"Charge Time: {s}"); ;
            Mystore.ElecDevices[0].ChargeItem(120);
            Console.ForegroundColor = ConsoleColor.White;

            //Second Buy
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\n-----------Pelephones supply: -----------");
            Console.BackgroundColor = ConsoleColor.Black;
            Mystore.check(2);
            Console.WriteLine(Mystore.Buy(4));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Mystore.ElecDevices[4].Charge += s => Console.WriteLine($"Charge Time: {s}"); ;
            Mystore.ElecDevices[4].ChargeItem(70);
            Console.ForegroundColor = ConsoleColor.White;

            // Send messages: 
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\n-----Send messages:-----");
            Console.BackgroundColor = ConsoleColor.Black;
            var x = (Phone)Mystore.ElecDevices[4];
            Console.WriteLine(x.SendMessasge(3, "0765432345"));
            Console.WriteLine(x.SendMessasge("How r you?", "0504342333"));
            Console.WriteLine(x.SendMessasge(true, "0765432345"));



        }
    }
}
