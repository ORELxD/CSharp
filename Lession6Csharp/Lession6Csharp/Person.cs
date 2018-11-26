namespace Lession6Csharp
{
    class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private Address p_address;

        public Address P_address
        {
            get { return p_address; }
            set { p_address = value; }
        }

        public Person(string name, Address p_address)
        {
            Name = name;
            P_address = p_address;
        }

        public Person(){ }

        //----------Method----------------
        public string GetInfo()
        {
            string status = $"City: {P_address.City}\nCountry: {P_address.Country}\nStreet: {P_address.Street}\nNumberHouse: {P_address.NumHouse}";
            return $"Name:{Name}\naddress:\n{status}";
        }

    }
}
