using System;

namespace Class_Task_oop___events
{
    class Computer:Electronics
    {
        public bool PcOrLap { get; set; }

        public Computer(bool pcOrLap,decimal price, int watts, int warranty, int minFullChrage):base(price,watts,warranty,minFullChrage)
        {
            PcOrLap=pcOrLap;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $" PcOrLap: {PcOrLap}";
        }

    }
}
