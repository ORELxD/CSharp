namespace Lession6Csharp
{
    class Address
    {
        //----------Properties----------------
        private string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        private string country;

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        private string street;

        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        private int numHouse;

        public int NumHouse
        {
            get { return numHouse; }
            set { numHouse = value; }
        }

        //----------Cunstractor----------------
        public Address(string city,string country,string street,int numHouse)
        {
            City = city;
            Country = country;
            Street = street;
            NumHouse = numHouse;
        }

        

    }
}
