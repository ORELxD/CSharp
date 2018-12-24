using System;

namespace Lession8CSharp
{
    class Pizza:Food
    {
        private int numOfSlices;

        public int NumOfSlices
        {
            get { return numOfSlices; }
            set { numOfSlices = value; }
        }

        private int numOfToppings;

        public int NumOfToppings
        {
            get { return numOfToppings; }
            set { numOfToppings = value; }
        }

        public Pizza(int numOfToppings, int numOfSlices,double Price,bool isVeg) :base (Price,isVeg)
        {
            NumOfSlices = numOfSlices;
            NumOfToppings = numOfToppings;
        }
    }
}
