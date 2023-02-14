using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int discount = Convert.ToInt32(Console.ReadLine());

            Dictionary<string, int> coffee = new Dictionary<string, int>();
            coffee.Add("Americano", 50);
            coffee.Add("Latte", 70);
            coffee.Add("Flat White", 60);
            coffee.Add("Espresso", 60);
            coffee.Add("Cappuccino", 80);
            coffee.Add("Mocha", 90);


            //your code goes here
            foreach (KeyValuePair<string, int> item in coffee)
            {
                double t = item.Value * (discount / 100.0);

                int a = item.Value - Convert.ToInt32(t);
                coffee[item.Key] = a;
                Console.WriteLine($"{item.Key}: {coffee[item.Key]}");
            }


        }
    }
}