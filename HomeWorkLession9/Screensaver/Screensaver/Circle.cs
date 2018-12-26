using System;

namespace Screensaver
{
    class Circle
    {
        public const double pai = 3.14;
        public int AxisX { get; set; }
        public int AxisY { get; set; }
        public string Color { get; set; }

        private int radios;

        public int Radios
        {
            get { return radios; }
            set {
                if(value>=0)
                    radios = value; }
        }

        public Circle(int axisX, int axisY, string color, int radios)
        {
            AxisX = axisX;
            AxisY = axisY;
            Color = color;
            Radios = radios;
        }

        public Circle()
        {
            Console.WriteLine("Circle created\n");
        }

        public string getInfo()
        {
            return $"AxisX--> {AxisX}\nAxisY--> {AxisY}\nColor--> {Color}\nRadios--> {Radios}\nResult calcultion of space is: {Calc_Space()}\nResult calcultion of scope is: {Clac_Scope()}\n";
        }

        public double Calc_Space()
        {
            return Radios * 2* pai;
        }

        public double Clac_Scope()
        {
            return Radios * Radios * pai;
        }
    }
}
