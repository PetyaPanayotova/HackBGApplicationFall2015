using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Problem_Word_Game
{
    class WordGame
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number of the rows of the table:");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter number of the colomns of the table:");
            int colomns = int.Parse(Console.ReadLine());

            char?[,] matrix = new char?[rows, colomns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colomns; j++)
                {
                    Console.Write("matrix[{0},{1}] = ", i, j);
                    matrix[i, j] = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                    PrintMatrix(matrix, rows, colomns);
                }
            }

            Console.WriteLine("Please enter the word you want to search in the table: ");
            string word = Console.ReadLine();
            char[] wordChars = word.ToCharArray();

            int counter = 0;

            for (int k = 0; k < rows; k++)
            {
                for (int l = 0; l < colomns; l++)
                {
                    bool found = true;

                    for (int m = 0; m < wordChars.Length; m++)
                    {
                        if ((l + m >= colomns) || (wordChars[m] != matrix[k, l + m]))
                        {
                            found = false;
                            break;
                        }
                    }
                    if (found)
                    {
                        counter++;
                    }
                }
            }


            for (int k = 0; k < rows; k++)
            {
                for (int l = 0; l < colomns; l++)
                {
                    bool found = true;

                    for (int m = 0; m < wordChars.Length; m++)
                    {
                        if ((l + m >= rows) || (wordChars[m] != matrix[k + m,l]))
                        {
                            found = false;
                            break;
                        }
                    }
                    if (found)
                    {
                        counter++;
                    }
                }
            }
        }



            //            PrintMatrix(matrix, rows, colomns);          
        }

        static void PrintMatrix(char?[,] matrix, int rows, int cols)
        {
            for (int a = 0; a < rows; a++)
            {
                for (int b = 0; b < cols; b++)
                {
                    if (!matrix[a, b].HasValue)
                    {
                        Console.Write("_");
                    }
                    else
                    {

                        Console.Write(matrix[a, b]);
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
