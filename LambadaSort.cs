using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class Student
    {
        private int grade;

        public int Grade
        {
            get { return grade; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    grade = value;
                }
            }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0 && value <= 120)
                {
                    age = value;
                }
            }
        }

        public string Name { get; set; }

        public Student(int grade, int age, string name)
        {
            Grade = grade;
            Age = age;
            Name = name;
        }

        public Student(int gr)
        {

        }

        public string toString()
        {
            return $"Name: {Name}\nAge: {Age}\nGrade: {Grade}";
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentArr = new List<Student>(5);
            studentArr.Add(new Student(100, 27, "orel"));
            studentArr.Add(new Student(100, 23, "or"));
            studentArr.Add(new Student(95, 25, "roi"));
            studentArr.Add(new Student(97, 25, "rea"));
            studentArr.Add(new Student(75, 29, "E"));

            
            studentArr.Sort((emp1, emp2) => emp1.Grade.CompareTo(emp2.Grade));
            Console.WriteLine("----------------Sort by grades---------------");
            studentArr.ForEach(x => Console.WriteLine(x.toString() + "\n"));
            studentArr.Sort((emp1, emp2) => emp1.Age.CompareTo(emp2.Age));
            Console.WriteLine("----------------Sort by Age---------------");
            studentArr.ForEach(x => Console.WriteLine(x.toString() + "\n"));
            studentArr.Sort((emp1, emp2) => emp1.Name.CompareTo(emp2.Name));
            Console.WriteLine("----------------Sort by Names---------------");
            studentArr.ForEach(x => Console.WriteLine(x.toString() + "\n"));
            Console.ReadLine();

        }
    }
}
