using System;

namespace Screensaver
{
    class Program
    {
        static void Main(string[] args)
        {
            int N=1;
            do
            {
                Console.Clear();
                Console.WriteLine("Please Enter your choice:\n1)Circle\n2)Square");
                Console.Write("\nYour choice:");
                N = Convert.ToInt32(Console.ReadLine());
            } while (N!=1&&N!=2);

            
            switch (N)
            {
                case 1:
                    Circle C = new Circle();
                    Console.WriteLine("Enter X:");
                    C.AxisX = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Y:");
                    C.AxisY = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Color:");
                    C.Color = Console.ReadLine();
                    Console.WriteLine("Enter size of 'Radios':");
                    C.Radios = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n");
                    Console.WriteLine(C.getInfo());
                    break;
                case 2:
                    Square S = new Square();
                    Console.WriteLine("Enter X:");
                    S.AxisX = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Y:");
                    S.AxisY = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Color:");
                    S.Color = Console.ReadLine();
                    Console.WriteLine("Enter size of 'Side':");
                    S.Side = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n");
                    Console.WriteLine(C.getInfo());
                    break;
                default:
                    break;
            }



        }
    }
}
