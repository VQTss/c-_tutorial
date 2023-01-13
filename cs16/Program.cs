using System;
using static System.Console;

using testNS;

using xyz = testNS.ACB;

using SanPham;

namespace cs16
{
    class Program
    {
        static void Main(string[] args)
        {
            // testNS.Hello.Xinchao();
            // xyz.Hello.Xinchao();
            Product p = new Product();
            p.name = "Iphone";
            p.price = 500;
            p.description = "This is a phone";
            WriteLine($"{p.getInfor()}");
        }
    }
}
