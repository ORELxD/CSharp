using System;

namespace HomeworkLession6
{
    class Clock
    {
        //1.1
        private int miliseconds;

        public int Miliseconds
        {
            get { return miliseconds; }
            set { miliseconds = value; }
        }

        private int seconds;

        public int Seconds
        {
            get { return seconds; }
            set { seconds = value; }
        }

        private int minutes;

        public int Minutes
        {
            get { return minutes; }
            set { minutes = value; }
        }

        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        private int hours;

        public int Hours
        {
            get { return hours; }
            set { hours = value; }
        }


        //1.1
        public void tick()
        {
            miliseconds = miliseconds + 1000;
            seconds = seconds + 1;
            minutes = minutes + seconds / 60;
            hours = hours + minutes / 60;
            miliseconds = miliseconds % 60;
            seconds = seconds % 60;
            minutes = minutes % 60;
            hours = hours % 24;
        }

        //1.2
        public string show()
        {
            string h, m, s, ms;
            if (hours < 10)
            {
                h = hours.ToString() + "0";
            }
            else
                h = hours.ToString();

            if (minutes < 10)
            {
                m = minutes.ToString() + "0";
            }
            else
                m = minutes.ToString();

            if (seconds < 10)
            {
                s = seconds.ToString() + "0";
            }
            else
                s = seconds.ToString();

            if (miliseconds < 1)
            {
                ms = miliseconds.ToString() + "0";
            }
            else
                ms = miliseconds.ToString();
            if((hours+minutes+seconds+miliseconds)==0)
            {
                Console.WriteLine("It's a MidNight\n--------------");
            }
            else
                if(hours+minutes+seconds+miliseconds==12)
                Console.WriteLine("It's MidDay");

            return $"The current time is:{h}:{m}:{s}:{ms}";
        }
         //1.3
         public void setMidNight()
        {
            miliseconds = 0;
            seconds = 0;
            minutes = 0;
            hours = 0;
        }

        public void setMidDay()
        {
            miliseconds = 00;
            seconds = 00;
            minutes = 00;
            hours = 12;
        }

        public Clock(int milliseconds, int seconds, int minutes, int hours)
        {
            Miliseconds = milliseconds;
            Seconds = seconds;
            Minutes = minutes;
            Hours = hours;
        }

        public Clock()
        {

        }

    }
}
