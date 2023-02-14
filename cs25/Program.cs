// using Internal;
using System;
using System.Collections.Generic;

namespace cs25
{

    public class Product
    {
        public string Name { set; get; }
        public string Origin { set; get; }
        public int ID { set; get; }
        public double Price { set; get; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<int> ds1 = new List<int>() { 7, 8, 9 }; // thêm trực tiếp

            // Thêm phần tử vào danh sách
            ds1.Add(1);
            ds1.Add(2);
            // Thêm 1 mảng vào phần tử thì trong list sẽ như sau 1 2 3 4 5
            ds1.AddRange(new int[] { 3, 4, 5 });
            Console.WriteLine($"Count element in list: {ds1.Count}");
            Console.WriteLine($"Get element in list: {ds1[1]}");
            // Chèn vào phần danh sáchh
            ds1.Insert(0, 10);
            // ds1.InsertRange(); -> chèn 1 mảng vào list
            // Xóa phần tử ở vị trí index
            ds1.RemoveAt(0);
            // Xóa phần tử trực tiếp - chỉ xóa số đầu tiên mà nó gặp
            ds1.Remove(8);
            // Duyệt qua các phần tử
            foreach (var n in ds1)
            {
                Console.WriteLine(n);
            }
            // tìm kiếm các phần tử trong danh sách
            // tìm kiến phần tử đầu tiên
            var n1 = ds1.Find((e) =>
            {
                return e % 2 == 0;
            });
            Console.WriteLine($"Return the first element in list: {n1}");

            // tìm kiếm tất cả các phần tử

            var rs = ds1.FindAll((e1) =>
            {
                return e1 > 5;
            });
            foreach (var i in rs)
            {
                Console.WriteLine(i);
            }
            // Sort

            // Product

            List<Product> products = new List<Product>(){
                new Product() {
                    Name = "Iphone X" , Price = 1000 , Origin = "China" , ID = 1
                },
                new Product() {
                    Name = "Samsung" , Price = 900 , Origin = "VietNam" , ID = 2
                },
                new Product() {
                    Name = "Vinsmart" , Price = 1400 , Origin = "VietNam" , ID = 3
                },
                new Product() {
                    Name = "Xiaomi" , Price = 1000 , Origin = "China" , ID = 4
                }
            };

            var p1 = products.Find((e) =>
            {
                return e.Origin == "China";
            });

            if (p1 != null)
            {
                Console.WriteLine($"{p1.Name} -  {p1.Price} - {p1.Origin}");
            }

            var p2 = products.FindAll((e) =>
            {
                return e.Price > 500;
            });
            foreach (var item in p2)
            {
                Console.WriteLine($"{item.Name} -  {item.Price} - {item.Origin}");
            }
            Console.WriteLine("Sort ------------------------------");
            products.Sort((p3, p4) =>
            {
                // 0 p3 == p4
                // 1 p3 > p4
                //  - 1 p3 < p4 

                // từ cao đến thấp
                // if (p3.Price == p4.Price)
                // {
                //     return 0;
                // }
                // if (p3.Price > p4.Price)
                // {
                //     return 1;
                // }
                // return -1;
                // từ thấp đến cao
                if (p3.Price == p4.Price)
                {
                    return 0;
                }
                if (p3.Price > p4.Price)
                {
                    return -1;
                }
                return 1;
            });

            foreach (var i2 in products)
            {
                Console.WriteLine($"{i2.Name} -  {i2.Price} - {i2.Origin}");
            }

        }
    }
}
