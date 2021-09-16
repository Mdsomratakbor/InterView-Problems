using System;

namespace InterView_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] twoDimantionalArray = new int[2, 3];
            Console.WriteLine("Please enter 2D Array Elements :");
            for(int i=0; i<2; i++)
            {
                for(int j=0; j<3; j++)
                {
                    twoDimantionalArray[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int rows = twoDimantionalArray.GetLength(0);
           int columns =   twoDimantionalArray.GetLength(1);
            for(int column = 0; column < columns; column++)
            {
                for(int row =0; row < rows; row++)
                {
                    Console.Write($"{twoDimantionalArray[row, column]} ");
                }
            }
            Console.ReadKey();

        }
    }
}
