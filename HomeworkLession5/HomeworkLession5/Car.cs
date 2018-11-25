
namespace HomeworkLession5
{
    class Car
    {
        private int speed;

        public int Speed
        {
            get { return speed; }
            set
            {
                if(speed>=0)
                speed = value;
            }
        }


        private int slowDown;

        public int SlowDown
        {
            get { return slowDown; }
            set{
                if(slowDown>=0)
                    slowDown = value;
            }
        }


        private bool stop;

        public bool Stop
        {
            get { return stop; }
            set
            {
                if(!stop)
                stop = value;
            }
        }

        public string GetDescription()
        {
            return $"info car:\ngaz:{Speed}\nSlowDown:{SlowDown}\nstop:{Stop}";
        }
    }
}
