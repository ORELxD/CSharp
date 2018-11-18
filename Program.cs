using System;


namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //----------------------------simple print----------------------------------------------
            Console.WriteLine("Simple Print");
            //----------------------------simple input----------------------------------------------
            //-'ReadLine()'- a function that returns the input from the keyboard as a string
            //this take all the input untill the user presses 'enter'
            Console.WriteLine("Take input from user:");
            string str;
            str=Console.ReadLine();
            Console.WriteLine($"input user is:{ str}");
            //--------------------------convert from string to number--------------------------------
            int num1 = Convert.ToInt32("6");
            double num2 = Convert.ToDouble("6.7");
            Console.WriteLine($"convert string to int:{num1}");
            Console.WriteLine($"convert string to double:{num2}");
            //--------------------------convert from number to string--------------------------------
            string strnum1 = Convert.ToString(4);
            string strnum2 = Convert.ToString(7.8);
            Console.WriteLine($"convert int to string:{strnum1}");
            Console.WriteLine($"convert double to string:{strnum2}");
            //--------------------------Array--------------------------------
            int[] arr = new int[4] { 2, 4, 6, 8 };
            Console.WriteLine("-----------my array-------------");
            for (int i = 0; i < 4; i++)
            {
                Console.Write(arr[i]+"|");
            }
            Console.Write("\n");
            */


            //--------------------------------ClassTask1-------------------------------------------------
            /*
            int mul, elm;
            Console.WriteLine("Please Enter a two numbers with type int:");
            Console.WriteLine("Num1-length of array:");
            elm =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Num2-How much multiply each index:");
            mul= Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[elm];
            Console.WriteLine($"num of elements:{elm},num of mul:{mul}");
            Console.WriteLine("array content:");
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = mul * i;
                Console.Write(arr1[i] + "|");
            }
            */


            //--------------------------------ClassTask2-------------------------------------------------
            /*int n1 = 0;
            do
            {
                Console.WriteLine("Enter Number Between 3-9:");
                n1 = Convert.ToInt32(Console.ReadLine());
            } while (n1 < 3 && n1 > 9);

            int[][] matrix1 = new int[n1][];
            int x=0;
            Console.WriteLine("---------------------My matrix-------------------");
            for (int row = 0; row < matrix1.Length; row++)
            {
                matrix1[row] = new int[row + 1];
                for (int col = 0; col < matrix1[row].Length; col++)
                {
                    matrix1[row][col] = x + 1;
                }
                x++;
            }


            foreach (int[] row in matrix1)
            {
                foreach (int col in row)
                {
                    Console.Write($"{col}.");
                }
                Console.WriteLine("");
            }
            */


            //--------------------------------ClassTask3-------------------------------------------------
            
            int size = 5;
            string[][] matrix = new string[size][];
            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new string[size];
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (col == row)
                    {

                        matrix[row][col] = "main | ";
                        if (size / 2 == row && size / 2 == col)
                            matrix[row][col] = "center | ";
                    }
                    else if (row + col == size - 1)
                        matrix[row][col] = "sub | ";
                    else if (row < col)
                        matrix[row][col] = "up | ";
                    else if (row > col)
                        matrix[row][col] = "down | ";
                }
            }

            foreach (string[] row in matrix)
            {
                foreach (string col in row)
                {
                    Console.Write(col);
                }
                Console.WriteLine(" ");
            }
            
        }
        
    }
}

