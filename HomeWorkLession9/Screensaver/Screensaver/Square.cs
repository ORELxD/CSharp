using System;

namespace Screensaver
{
    class Square
    {
        public int AxisX { get; set; }
        public int AxisY { get; set; }
        public string Color { get; set; }

        private int side;

        public int Side
        {
            get { return side; }
            set {
                if(value>=0)
                side = value; }
        }

        public Square(int axisX, int axisY, string color, int side)
        {
            AxisX = axisX;
            AxisY = axisY;
            Color = color;
            Side = side;
        }

        public string getInfo()
        {
            return $"AxisX--> {AxisX}\nAxisY--> {AxisY}\nColor--> {Color}Radios--> {Side}\nResult calcultion of space is: {Calc_Space()}\nResult calcultion of scope is: {Clac_Scope()}\n";
        }

        public Square()
        {
            Console.WriteLine("Square created\n");
        }

        public double Calc_Space()
        {
            return Side * Side;
        }

        public double Clac_Scope()
        {
            return Side * 4;
        }

    }
}
