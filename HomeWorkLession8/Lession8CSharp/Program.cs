using System;

namespace Lession8CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Food[] arr = new Food[6];
            arr[0] = new Pizza(2, 8,15,true);
            arr[1] = new Pizza(1, 6,15, true);
            arr[2] = new Pizza(4, 4, 15, false);
            arr[3] = new Chips(true, false, 10, true);
            arr[4] = new Chips(false, false, 12, true);
            arr[5] = new Chips(true, true, 14, true);

            for (int i = 0; i < 6; i++)
            { 
                if(arr[i] is Pizza)
                    Console.Write($"pizza {i+1}\n~~~~~~~~~\nPrice: {((Pizza)arr[i]).Price}\nIsVeg: {((Pizza)arr[i]).IsVeg}\nNumOfSlices: {((Pizza)arr[i]).NumOfSlices}\nNumOfToppings: {((Pizza)arr[i]).NumOfToppings}\n\n");
                else
                    Console.Write($"Chips {i + 1}\n~~~~~~~~~\nPrice: {((Chips)arr[i]).Price}\nIsVeg: {((Chips)arr[i]).IsVeg}\nIsExtreaBig: {((Chips)arr[i]).IsExtreaBig}\nIsWithDipp: {((Chips)arr[i]).IsWithDipp}\n\n");
            }
        }
    }
}
