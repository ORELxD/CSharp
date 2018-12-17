
namespace HomeWorkLession8
{
    class FoodProduct
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private double price;

        public double Price
        {
            get { return price; }
            set {
                if(price>=0)
                price = value;
            }
        }

        private bool kosher; 

        public bool Kosher
        {
            get { return kosher; }
            set {
                if(kosher==true || kosher==false)
                    kosher = value; }
        }

        private string mname; //Manufacturer name

        public string Mname
        {
            get { return mname; }
            set { mname = value; }
        }


        private int exyear; //Expiration year

        public int Exyear
        {
            get { return exyear; }
            set {exyear = value; }
        }

        public FoodProduct(string name,double price,bool kosher,string mname,int exyear)
        {
            Name = name;
            Price = price;
            Kosher = kosher;
            Mname = mname;
            Exyear = exyear;
        }

        public string GetDescription()
        {
            System.Console.WriteLine("*)Description about the food:\n-----------------------");
            string res = $"Name:{Name}\nPrice: {Price}\nKosher: {Kosher}\nManufacturer name: {Mname}\nExpiration year: {Exyear}";
            return res;
        }

        public bool Check_Exyear(int exyear)
        {
            if (exyear >= 2018 && exyear <= 2050)
                return true;
            else
                return false;
        }
    }
}
