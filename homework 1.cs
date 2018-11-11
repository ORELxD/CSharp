using System;


namespace MetrixTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //create Matrix 3X3
            string[][] matrix1 = { new string[] {"main", "  up  ", " sub" }, new string[] { "down", "center", " up " }, new string[] { "sub ", " down ", "main"} };
            Console.WriteLine("My matrix with loop for:");
            Console.WriteLine("_________________");
  
            for (int row=0;row<matrix1.Length;row++)
            {
                for(int col=0;col<matrix1[row].Length;col++)
                { 
                Console.Write( $"{matrix1[row][col]}|");
                }
                Console.WriteLine(" ");
                Console.WriteLine("____ ______ _____");
                Console.WriteLine(" ");
            }
            Console.WriteLine("My matrix with loop foreach:");
            Console.WriteLine("_________________");
            foreach(string[] matrixItem in matrix1)
            {
                foreach(string arrItem in matrixItem)
                {
                    Console.Write($"{arrItem}|");
                }
                Console.WriteLine(" ");
                Console.WriteLine("____ ______ _____");
                Console.WriteLine(" ");
            }
        }
    }
}
