using System;


namespace HomeWorkLession8
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodProduct [] foods = new FoodProduct[5];
            foods[0] =new FoodProduct("Popcorn", 22, true, "none", 2019);
            foods[1] = new FoodProduct("Burger", 36.50,false, "McDonald's", 2018);
            foods[2] = new FoodProduct("Pizza", 13, false, "Dominos", 2010);
            foods[3] = new FoodProduct("Sushi", 35, false, "japanica", 2019);
            foods[4] = new FoodProduct("Nachos", 8.50, true, "unico", 2019);

            Console.WriteLine("Food Product\n##############\n");

            for (int i=0;i<5;i++){
                Console.WriteLine(foods[i].GetDescription());
                if (foods[i].Check_Exyear(foods[i].Exyear))
                    Console.WriteLine("Expiration year It's OK");
                else
                    Console.WriteLine("Expiration year pass a way");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~\n\n");
            }

        }
    }
}
