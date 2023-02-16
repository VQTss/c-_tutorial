using System;
using mymynamespace;
using sub =  mymynamespace.sub_myNameSpace; // đặt tên cho namesapce là sub
using SanPham;
namespace cs_namespace
{
    class Program
    {
        static void Main(string[] args)
        {
           Class1.Hello();
           sub.Class1.Hello();
           Product p = new Product();
           p.name = "Iphone";
           p.price = 1000;
            Console.WriteLine(p.ToString());

        }
    }
}
