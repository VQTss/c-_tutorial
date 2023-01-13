using System;

namespace cs08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] games = { "Alien Shooter", "Tic Tac Toe", "Snake", "Puzzle", "Football" };

            // try
            // {
            //     Console.WriteLine(games[Convert.ToInt32(Console.ReadLine())]);
            // }
            // catch (System.Exception)
            // {
            //     Console.WriteLine("Invalid Number");
            // }
            // int[] a = new int[10];
            // for (int k = 0; k < 10; k++)
            // {
            //     a[k] = k * 2;
            // }
            // Mul - Array 
            int[,] num = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (var j = 0; j < num.GetLength(1); j++)
                {
                    Console.Write(num[i,j]);
                }
                Console.WriteLine();
            }

            // 
            int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }


        }
    }
}
