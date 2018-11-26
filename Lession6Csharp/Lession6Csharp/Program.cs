using System;

namespace Lession6Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Name = "Orel";
            p1.P_address = new Address("Bait-arya","Israel","MeirAriel",16);
            Console.WriteLine(p1.GetInfo());
        }
    }
}
