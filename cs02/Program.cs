using System;

namespace cs02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Hello, World!");
            // Reset lại màu bình thường
            Console.ResetColor();

            int a = 123;
            double b = 456.7789;
            // format string
            Console.WriteLine($"Biến a =  {a}, biến b = {b}");
            Console.WriteLine("Biến a =  {0}, biến b = {1}", a, b);

            string userLogin;
            Console.Write("User input: ");
            userLogin = Console.ReadLine();

            Console.WriteLine($"Tên nhập vào là: {userLogin}");


            Console.Write("Nhập một số thức : ");
            // Nhập chuỗi - chuyển ngay chuỗi đó thành số thực
            double dinput = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Số đã nhập là: {dinput}");


            const string MON = "THỨ HAI";
            Console.WriteLine(MON);

            char input = Console.ReadKey().KeyChar;
            switch (input)
            {
                case 'x':
                    {
                        Console.WriteLine("You pressed x...");
                        break;
                    }
                case 'y':
                    {
                        Console.WriteLine("You pressed y..");
                        break;
                    }
                default:
                    Console.WriteLine("Unknown Command.");
                    break;
            }
        }
    }
}
