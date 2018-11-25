//using System;

//namespace HomeworkLession5
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //Create 3 new cookies
//            Cookie cookie1 = new Cookie();
//            Cookie cookie2 = new Cookie();
//            Cookie cookie3 = new Cookie();
            
//            //input cookie1
//            cookie1.Gluten = true;
//            cookie1.Eggs = 3;
//            cookie1.Suger = 0.7;
//            cookie1.Flour=1.3;

//            //input cookie2
//            cookie2.Gluten = false;
//            cookie2.Eggs = 2;
//            cookie2.Suger = 0.6;
//            cookie2.Flour = 1.2;

//            //Show the Descroption of Cookies
//            Console.WriteLine("***************STEP-1*****************");
//            Console.WriteLine("------------------------------");
//            Console.WriteLine("Recipe of Cookies");
//            Console.WriteLine("------------------------------");
//            Console.WriteLine($"*cookie1:\n{cookie1.GetDescription()}");
//            Console.WriteLine("");
//            Console.WriteLine($"*cookie2:\n{cookie2.GetDescription()}");
//            Console.WriteLine("");


//            //update the amount of suger
//            cookie1.Suger = 0.4;

//            //Show the Recipe of Cookies after change the amount of suger to 0.4
//            Console.WriteLine("***************STEP-2*****************");
//            Console.WriteLine("------------------------------");
//            Console.WriteLine("Recipe of Cookies");
//            Console.WriteLine("------------------------------");
//            Console.WriteLine($"*cookie1:\n{cookie1.GetDescription()}");
//            Console.WriteLine("");
//            Console.WriteLine($"*cookie2:\n{cookie2.GetDescription()}");
//            Console.WriteLine("");


//            // take all Recipe Cookie1  and put it on Cookie2
//            cookie2 = cookie1;

//            //Show the Recipe of Cookies, after take Recipe cookie1 and put into cookie2 
//            Console.WriteLine("***************STEP-3*****************");
//            Console.WriteLine("------------------------------");
//            Console.WriteLine("Recipe of Cookies");
//            Console.WriteLine("------------------------------");
//            Console.WriteLine($"*cookie1:\n{cookie1.GetDescription()}");
//            Console.WriteLine("");
//            Console.WriteLine($"*cookie2:\n{cookie2.GetDescription()}");
//            Console.WriteLine("");

//            cookie2.Eggs = 5;
//            //Show the Recipe of Cookies after change amount of eggs in cookie2
//            Console.WriteLine("***************STEP-4*****************");
//            Console.WriteLine("------------------------------");
//            Console.WriteLine("Recipe of Cookies");
//            Console.WriteLine("------------------------------");
//            Console.WriteLine($"*cookie1:\n{cookie1.GetDescription()}");
//            Console.WriteLine("");
//            Console.WriteLine($"*cookie2:\n{cookie2.GetDescription()}");
//            Console.WriteLine("");

//            // 1ברגע שביצענו השמה של עוגיה1 בתוך עוגיה2 , עוגיה2 מצביע בתוך ההיפ לעוגיה1 ואז כל פעם שנבצע שינוי בעוגיה2 בעצם אנחנו מצביעים בהיפ על עוגיה

    

//        }
//    }
//}
