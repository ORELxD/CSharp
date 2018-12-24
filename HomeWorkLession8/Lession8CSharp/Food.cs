
namespace Lession8CSharp
{
    class Food
    {
        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public bool IsVeg { get; set; }

        public Food(double Price, bool isVeg)
        {
            Price = price;
            IsVeg = IsVeg;
        }

    }
}
