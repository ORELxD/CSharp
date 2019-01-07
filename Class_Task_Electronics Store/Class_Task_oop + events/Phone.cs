using System;

namespace Class_Task_oop___events
{
    class Phone:Electronics
    {
        public bool SmartPhone { get; set; }

        private string phoneNumber;

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set {
                if(value.Length == 10)
                phoneNumber = value; }
        }

        public Phone(string phoneNumber, bool smartPhone, decimal price, int watts, int warranty, int minFullChrage):base(price,watts,warranty,minFullChrage)
        {
            PhoneNumber = phoneNumber;
            SmartPhone = smartPhone;
        }

        public override string GetInfo()
        {
            return base.GetInfo()+ $"SmartPhone{SmartPhone}, PhoneNumber{PhoneNumber}";
        }

        public string SendMessasge<T>(T message,string DestPhone)
        {
            return $"Phone Number : {PhoneNumber},Send messasge: {message}, to: {DestPhone}";
        }
    }
}
