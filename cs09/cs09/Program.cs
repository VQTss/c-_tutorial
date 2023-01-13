using System;
using System.Linq;

namespace cs09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] num = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine(num.Length); // column number
            Console.WriteLine(num.Rank); // row numbers
            int[] number = { 1, 2, 3, 4, 5 };
            Console.WriteLine($"Max number: {number.Max()}");
            Console.WriteLine($"Min number: {number.Min()}");
            Console.WriteLine($"Sum number: {number.Sum()}");
            /*     int[ ] arr = new int[5];
                 for (int i = 0; i < 5; i++)
                 {
                     arr[i] = Convert.ToInt32(Console.ReadLine());
                 }
                 Console.WriteLine(arr.Max() + arr.Min()); */
            string[] words = {
                "home",
                "programming",
                "victory",
                "C#",
                "football",
                "sport",
                "book",
                "learn",
                "dream",
                "fun"
            };

            string letter = Console.ReadLine();

            int count = 0;

            //your code goes here
            foreach (var item in words)
            {
                if (item.Contains(letter))
                {
                    Console.WriteLine(item);
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No match");
            }

        }
    }
}
