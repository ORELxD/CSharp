using System;

namespace Class_Task_oop___events
{
    delegate void Del(int x);


    class Electronics
    {

        private decimal price;

        public decimal Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                    price = value;
            }
        }

        private int watts;

        public int Watts
        {
            get { return watts; }
            set
            {
                if (value > 0 && value % 100 == 0)
                    watts = value;
            }
        }

        private int warranty;

        public int Warranty
        {
            get { return warranty; }
            set
            {
                if (value >0 && value <= 10)
                    warranty = value;
            }
        }

        private int minFullChrage;

        public int MinFullChrage
        {
            get { return minFullChrage; }
            set {
                if (value > 0)
                    minFullChrage = value; }
        }

        public Electronics(decimal price, int watts, int warranty, int minFullChrage)
        {
            Price = price;
            Watts = watts;
            Warranty = warranty;
            MinFullChrage = minFullChrage;
        }



        public event Del Charge;
        public void ChargeItem(int x)
        {
            if (minFullChrage <= x)
            {
                Charge(x);
            }
        }

        public virtual string GetInfo()
        {
            return $"Price: {Price}, Watts: {Watts}, Warranty: {Warranty}, MinFullChrage: {MinFullChrage}";
        }

    }
}
