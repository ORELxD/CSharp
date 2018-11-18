using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixTask
{
    class HomeworkFix
    {
        static void Main(string[] args)
        {
            //--------------------------------ClassTaskMatrix-------------------------------------------------

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
