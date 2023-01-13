using System;

namespace cs01
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 10;
            if (a > b)
            {
                Console.WriteLine("Số a lớn hơn hoặc bằng số b");
            }
            else if (a < b)
            {
                Console.WriteLine("Số a nhỏ hơn số b");
            }
            else
            {
                Console.WriteLine("Hai số a, b bằng nhau");
            }
            int age = 18;
            var mgs = (age >= 18) ? "Đủ điều kiện" : "Không đủ điều kiện";
            Console.WriteLine(mgs);
        }

    }
}
