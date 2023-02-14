using System;


/*
tham trị là cách thức mặc định khi tham số đó là kiểu giá trị.
    Có nghĩa là gán tham số bằng một biến, thì giá trị của biến được copy và sử dụng trong phương thức như biến cục bộ, 
    còn bản thân biến bên ngoài không hề ảnh hưởng.
tham chiếu là cách thức mặc định khi tham số đó là kiểu tham chiếu, 
    thì bản thân biến ở tham số sẽ được hàm sử dụng trực tiếp (tham chiếu) chứ không tạo ra một biến cục bộ trong hàm, 
    nên nó có tác động trực tiếp đến biến này bên ngoài.

*/

namespace cs05
{
    class Program
    {

        // ref tham số với dạng tham chiếu
        static void Sqr(ref int x)
        {
            x *= x;
        }

        static void GetValues(out int a, out int b)
        {
            a = 10;
            b = 15;
        }
        static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        // static void xinChao(string first_name, string last_name)
        // {
        //     Console.WriteLine($"{first_name} {last_name}");
        // }


        // Tham số mặc định
        static void xinChao(string first_name, string last_name = "Vo")
        {
            Console.WriteLine($"{first_name} {last_name}");
        }

        static void binhphuong(ref int x , out int a){
            x = x * x;
            a = x;
            Console.WriteLine(a);
        }


        static void Main(string[] args)
        {
            int a = 3;
            Sqr(ref a);
            Console.WriteLine(a);
            int c, b;
            GetValues(out c, out b);
            Console.WriteLine("Before Swap:" + c + " " + b);
            swap(ref c, ref b);
            Console.WriteLine("Then Swap:" + c + " " + b);
            // Overloading
            int x = 20;
            int y = 30;
            var result1 = Calculator.Cal_sum(x, y);
            Console.WriteLine($"Method sum by integer: {result1}");
            // Truyền tham số 1 
            xinChao(first_name: "Thai");
            // Truyền tham số 2
            xinChao(first_name: "Thai", last_name: "Tran");
            int test;
            int t = 2;
            binhphuong(ref t, out test);
            binhphuong(ref t, out test);
            binhphuong(ref t, out test);
            Console.WriteLine($"x = {t}");
            Console.WriteLine($"test = {test}");
        }
    }
}
