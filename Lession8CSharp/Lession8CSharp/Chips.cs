using System;

namespace Lession8CSharp
{
    class Chips:Food
    {
        private bool isExtreaBig;

        public bool IsExtreaBig
        {
            get { return isExtreaBig; }
            set { isExtreaBig = value; }
        }

        private bool isWithDipp;

        public bool IsWithDipp
        {
            get { return isWithDipp; }
            set { isWithDipp = value; }
        }


        public Chips(bool isExtreaBig,bool IsWithDipps, double Price, bool isVeg) : base(Price, isVeg)
        {
            IsExtreaBig = isExtreaBig;
            IsWithDipp = isWithDipp;
        }
    }
}
