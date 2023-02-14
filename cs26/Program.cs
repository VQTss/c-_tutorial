using System.Collections.Generic;
using System;

namespace cs26
{
    class Program
    {
        public class Product
        {
            public string Name { set; get; }
            public string Origin { set; get; }
            public int ID { set; get; }
            public double Price { set; get; }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Sorted List");
            SortedList<string,Product> products = new SortedList<string, Product>();
            products["sp1"] = new Product(){Name="Iphone X",Price = 1000, Origin  = "China"};
            products["sp2"] = new Product(){Name="Samsung",Price = 900, Origin  = "Korean"};
            products.Add("sp3",new Product(){Name="Nokia",Price = 1000, Origin  = "Japan"});

            // Lấy tất cả khác key trong sorted list
            var keys = products.Keys;
            // Lấy tất cả các value trong sorted list
            var values = products.Values;

            foreach (var k in keys)
            {
                Console.WriteLine(products[k].Name);
            }
            
            foreach (KeyValuePair<string,Product> item in products)
            {
                Console.WriteLine($"{item.Key} - {item.Value.Name}");
            }
        }
    }
}
