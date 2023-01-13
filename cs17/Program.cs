using System;

namespace cs17
{
    //  struct là kiểu tham trị
    class Program
    {

        public struct product
        {
            // du lieu

            public string name;
            public double price;
            // phuong thuc

            public string getInfor()
            {
                return $"Name: {name} , Price: {price}";
            }


            // contructor
            public product(string name, double price)
            {
                this.name = name;
                this.price = price;
            }


        }


        public class product2
        {
            // du lieu

            public string name;
            public double price;
            // phuong thuc

            public string getInfor()
            {
                return $"Name: {name} , Price: {price}";
            }


            // contructor
            public product2(string name, double price)
            {
                this.name = name;
                this.price = price;
            }


        }

        static void Main(string[] args)
        {
            // use struct
            product sanpam1;
            sanpam1.name = "Iphone";
            sanpam1.price = 500;
            product sanpham2 = new product("Samsung", 4000);
            sanpham2 = sanpam1;
            sanpham2.name = "Iphone X";
            Console.WriteLine($"{sanpam1.getInfor()}");
            Console.WriteLine($"{sanpham2.getInfor()}");
            // this is using compare struct and class 
            // we are having two product and product2
            // Class là tham chiếu
            // khi sử dụng những cấu trúc dữ liệu đơn giản nhỏ dùng struct và ngược lại thì dùng class
            product2 p = new product2("",0);
            p.name = "Samsung";
            p.price = 400;

            product2 p2 =  new product2("Noikia",200);
            p2 = p;
            p2.name ="SamSung Galaxy";
            Console.WriteLine($"{p.getInfor()}");
            Console.WriteLine($"{p2.getInfor()}");



        }
    }
}
