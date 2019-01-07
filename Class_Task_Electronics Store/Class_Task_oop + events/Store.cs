using System;

namespace Class_Task_oop___events
{
    class Store
    {
        public Electronics[] ElecDevices = new Electronics[6];

        public void check(int num)
        {
            int i;
            switch (num)
            {
                case 1:
                    Console.WriteLine("You want to buy computer:");
                    for (i = 0; i < ElecDevices.Length; i++)
                    {
                        if (ElecDevices[i] is Computer)
                        {
                            Console.WriteLine($"Pc:{ElecDevices[i].GetInfo()}, in index {i}");
                        }
                    }
                    break;

                case 2:
                    Console.WriteLine("You want to buy phone:");
                    for (i = 0; i < ElecDevices.Length; i++)
                    {
                        if (ElecDevices[i] is Phone)
                        {
                            Console.WriteLine($"Phone:{ElecDevices[i].GetInfo()}, in index {i}");
                        }
                    }
                    break;

                default:
                    Console.WriteLine("non-vaild Plase try again:");
                    num = Convert.ToInt32(Console.ReadLine());
                    check(num);
                    Console.Clear();
                    break;
            }
        }

     
        public string Buy(int device)
        {
            return $"You need to pay:{ElecDevices[device].Price}, Warranty you get is: {ElecDevices[device].Warranty}";
        }

    }
}
