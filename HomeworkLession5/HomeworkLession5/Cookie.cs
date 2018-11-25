
namespace HomeworkLession5
{
    class Cookie
    {
        // var gluten get+set
        private bool gluten;

        public bool Gluten
        {
            get { return gluten; }
            set{
                if(!gluten)
                gluten =value;
            }
        }

        // var eggs get+set
        private int eggs;

        public int Eggs
        {
            get { return eggs; }
            set {
                if(value>0)
                eggs = value;
            }
        }

        // var suger get+set
        private double sugar;

        public double Suger
        {
            get { return sugar; }
            set
            {
                if (value > 0)
                    sugar = value;
            }
        }

        // var flour get+set
        private double flour;

        public double Flour
        {
            get { return flour; }
            set {
                if (value > 0)
                    flour = value;
            }
        }

        //Function that print the Descroption of Cookies
        public string GetDescription()
        {
            return $"#Gluten- {Gluten}\n#Eggs- {Eggs}\n#Suger- {Suger}\n#Flour- {Flour}" ;
        }

    }
}
