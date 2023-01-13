using System;

namespace cs17
{
    //  truct là kiểu tham trị
    class Program
    {
        
        public struct product{
            // du lieu

            public string name;
            public double price;
            // phuong thuc

            public string getInfor(){
                return $"Name: {name} , Price: {price}";
            }


            // contructor
            public product(string name, double price){
                this.name = name;
                this.price = price;
            }


        }
        

        
        static void Main(string[] args)
        {
           product sanpam1;
        
            sanpam1.name  = "Iphone";
            sanpam1.price = 500;
            Console.WriteLine($"{sanpam1.getInfor()}");
            product sanpham2 =  new product("Samsung",4000);
            Console.WriteLine($"{sanpham2.getInfor()}");
        }
    }
}
